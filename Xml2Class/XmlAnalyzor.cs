using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Xml2Class
{
    public class XmlAnalyzor: DatagramAnalyzor
    {
        public override ClassesInfo AnalysistDatagram(string sXml)
        {
            XmlClassesInfo xci = new XmlClassesInfo();

            System.Xml.XmlDocument doc = new XmlDocument();
            doc.LoadXml(sXml);

            xci.DocType = doc.DocumentType;
            var ele = doc.DocumentElement;
            AnalysistXmlEle(ele,  xci);
     
            return xci;
        }

        private XmlClassDef AnalysistXmlEle(XmlElement ele, XmlClassesInfo xci)
        {
            // 0 如果是简单元素，直接返回null就好
            if (IsSimplyElement(ele))
            {
                return null;
            }

            // 1.生成此类型, prefix为命名空间，localname为Name
            XmlClassDef c;
            c = new XmlClassDef()
            {
                IsRoot = xci.dicClasses.Count == 0,
                Name = ele.LocalName + "Class",
                XmlNameSpaceUri = ele.NamespaceURI,
                XmlPreFix = ele.Prefix,
            };
            xci.AddNameSpace(ele.NamespaceURI, ele.Prefix);

            var iAttrCount = 0;
            var iEleCount = 0;

            // 1.1 如果此类型已经存在，那么用旧类型。
            if (xci.dicClasses.ContainsKey(c.FullName))
            {
                c = xci.dicClasses[c.FullName] as XmlClassDef;
            }
            else
            {
                // 将本节点类型加入库中。
                xci.dicClasses.Add(c.FullName, c);
            }
            
            if (c.Properties == null)
            {
                c.Properties = new Dictionary<string, PropertyDef>();
            }

            // 本节点下的属性列表
            var thisPropertys = new Dictionary<string, PropertyDef>();

            // 2.遍历所有的属性

            foreach (XmlAttribute att in ele.Attributes)
            {
                // 2.0 忽略prefix为xmlns的属性，这是命名空间的定义。
                if (att.Prefix.ToLower() == "xmlns")
                {
                    continue;
                }

                iAttrCount++;
                
                // 2.2 如果此属性在属性里有多个存在，那么将之改为多重模式
                XmlPropertyDef pd = null;
                if (thisPropertys.ContainsKey(att.LocalName))
                {
                    pd = c.Properties[att.LocalName] as XmlPropertyDef; // 一定存在
                    pd.IsMulti = true;
                    pd.AddExampleValue(att.Value);
                }
                else if (c.Properties.ContainsKey(att.LocalName)) // 如果本节点不存在但过去有存在。
                {
                    pd = c.Properties[att.LocalName] as XmlPropertyDef; // 一定存在
                    pd.AddExampleValue(att.Value);
                    pd.NotNull = false;
                }
                else // 都不存在。
                {
                    // 2.1 生成字串型属性. NamespaceURI为命名空间，localname为Name. 
                    pd = new XmlPropertyDef()
                    {
                        Name = att.LocalName,
                        IsMulti = false,
                        NotNull = false,
                        Type = "string",
                        ValueSource = XmlValueSource.Attribute,
                        XmlNameSpaceUri = att.NamespaceURI,
                        XmlPreFix = att.Prefix,
                       
                    };
                    xci.AddNameSpace(att.NamespaceURI, att.Prefix);

                    pd.AddExampleValue(att.Value);
                    c.Properties.Add(pd.Name, pd);
                    thisPropertys.Add(pd.Name, pd);
                }
            }
            // 3.遍历所有的子节点
            foreach (XmlNode subnode in ele.ChildNodes)
            {
                // 除去不处理的项。
                if (!(subnode is XmlElement))
                {
                    continue;
                }
                XmlElement subele = subnode as XmlElement;
                iEleCount++;

                XmlPropertyDef pd = null;

                // 3.3 如果此属性名在属性里已经存在，那么将之改为多重模式
                if (thisPropertys.ContainsKey(subele.LocalName))
                {
                    pd = c.Properties[subele.LocalName] as XmlPropertyDef; // 一定存在
                    pd.IsMulti = true;
                }
                else if (c.Properties.ContainsKey(subele.LocalName)) // 如果本节点不存在但过去有存在。
                {
                    pd = c.Properties[subele.LocalName] as XmlPropertyDef; // 一定存在
                    pd.NotNull = false;
                }
                else
                {
                    // 2.1 先生成字串型属性. 
                    pd = new XmlPropertyDef()
                    {
                        Name = subele.LocalName,
                        IsMulti = false,
                        NotNull = false,
                        Type = "string",
                        ValueSource = XmlValueSource.SubElement,
                        XmlNameSpaceUri = subele.NamespaceURI,
                        XmlPreFix = subele.Prefix,
                    };

                    xci.AddNameSpace(subele.NamespaceURI, subele.Prefix);

                    c.Properties.Add(pd.Name, pd);
                    thisPropertys.Add(pd.Name, pd);
                }

                // 3.1 递归，为每一个子节点生成类型定义。
                var clsdef = AnalysistXmlEle(subele, xci);

                // 3.2 如果没有返回空，那么该属性改为对应的类型。
                if (clsdef != null)
                {
                    pd.Type = clsdef.FullName;
                }
                else
                {
                    // 是个简单的子元素，加入示例数据
                    pd.AddExampleValue(subele.InnerText);
                }
            }

            // 如果子节点一个没有，而属性有，那么为子节点生成一个Text字段
            if (iAttrCount > 0 && iEleCount == 0)
            {
                if (c.Properties.ContainsKey("Text"))
                {
                    var pdText = c.Properties["Text"];
                    pdText.AddExampleValue(ele.InnerText);
                }
                else
                {
                    var pdText = new XmlPropertyDef()
                    {
                        Name = "Text",
                        IsMulti = false,
                        NotNull = false,
                        Type = "string",
                        ValueSource = XmlValueSource.Text,
                    };
                    pdText.AddExampleValue(ele.InnerText);
                    c.Properties.Add(pdText.Name, pdText);
                }
            }

            return c;
        }

        private bool IsSimplyElement(XmlElement ele)
        {
            var iAttrCount = 0;
            foreach (XmlAttribute att in ele.Attributes)
            {
                // 2.0 忽略prefix为xmlns的属性，这是命名空间的定义。
                if (att.Prefix.ToLower() == "xmlns")
                {
                    continue;
                }

                iAttrCount++;
            }
            int iEleCount = 0;
            // 3.遍历所有的子节点
            foreach (XmlNode subele in ele.ChildNodes)
            {
                // 除去不处理的项。
                if (!(subele is XmlElement))
                {
                    continue;
                }

                iEleCount++;
            }
            if (iAttrCount == 0 && iEleCount == 0)
            {
                return true;
            }
            return false;
        }
    }
}
