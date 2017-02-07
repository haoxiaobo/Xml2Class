using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace Xml2Class
{
    public class CSharpGenerator : ClassFileGeneratorBase
    {
        public override void GenClasses(XmlClassesInfo xci, string sBaseNameSpace, string sBasePath)
        {
            var classes = (from c in xci.dicClasses.Values
                           orderby c.IsRoot
                           select c).ToArray();
            foreach (var c in classes)
            {
                this.GenClass(c, xci, sBaseNameSpace, sBasePath);
            }
        }

        private void GenClass(XmlClassDef c, XmlClassesInfo xci, string sBaseNameSpace, string sBasePath)
        {
            string sPath = Path.Combine(sBasePath, sBaseNameSpace, c.XmlPreFix);
            string sFileName = c.Name + "Class.gen.cs";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }

            using (Stream stm = new FileStream(Path.Combine(sPath, sFileName), 
                FileMode.Create, FileAccess.Write))
            {
                this.GenClass(c, xci, sBaseNameSpace, stm);
            }
        }

        private void GenClass(XmlClassDef c, XmlClassesInfo xci,
            string sBaseNameSpace, Stream stm)
        {
            using (StreamWriter sw = new StreamWriter(stm))
            {
                this.GenClassFileHeader(c, xci, sBaseNameSpace, sw);
                this.GenClassDefHeader(c, xci, sBaseNameSpace, sw);

                foreach (var pd in c.Properties.Values)
                {
                    this.GenClassPropertiesDef(pd, c, xci, sBaseNameSpace, sw);
                }

                this.GenClassDefTail(c, xci, sBaseNameSpace, sw);
                this.GenClassFileTail(c, xci, sBaseNameSpace, sw);
            }
        }

        private void GenClassFileHeader(XmlClassDef c, XmlClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            sw.WriteLine(@"//---------------------------------------------------");
            sw.WriteLine(@"// class {0}Class", c.FullName);
            sw.WriteLine(@"// date: {0:yyyy-MM-dd HH:mm}", DateTime.Now);
            sw.WriteLine(@"// 本代码由 Xml2Class 生成器 (by Haoxiaobo) 自动生成");
            sw.WriteLine(@"//---------------------------------------------------");

            sw.WriteLine(
@"using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Linq; 
using {0};
",
sBaseNameSpace);

            sw.Write("namespace {0}", sBaseNameSpace);
            if (!string.IsNullOrWhiteSpace(c.XmlPreFix))
            {
                sw.Write("." + c.XmlPreFix);
            }
            sw.WriteLine();

            sw.WriteLine("{{", c.XmlPreFix);
            return;
        }
        private void GenClassFileTail(XmlClassDef c, XmlClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            sw.WriteLine("}");
            return;
        }

        private void GenClassDefHeader(XmlClassDef c, XmlClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            sw.WriteLine(@"
    /// <summary>
    /// {0} 类
    /// </summary>", c.FullName);
            sw.WriteLine("    [Serializable]");
            if (c.IsRoot) {
                sw.WriteLine("    [XmlRoot(ElementName = \"{0}\",Namespace = \"{1}\")]", c.Name, c.XmlNameSpaceUri);

                foreach (var cls in xci.dicClasses.Values)
                {
                    sw.WriteLine("    [XmlInclude(typeof({0}Class))]", cls.FullName);
                }
            }
            sw.WriteLine(
@"    public partial class {0}Class
    {{",
     c.Name
);
            return;
        }

        private void GenClassDefTail(XmlClassDef c, XmlClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            sw.WriteLine("    }");
        }

        private void GenClassPropertiesDef(XmlPropertyDef pd, XmlClassDef c, XmlClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            sw.WriteLine(
            @"
        /// <summary>
        /// {0}
        /// </summary>", pd.Name);

            if (pd.ExampleValues != null && pd.ExampleValues.Values.Count != 0)
            {
                sw.WriteLine("        /// <example>{0}</example>", 
                    this.GetExampleText(pd.ExampleValues));
            }
            
            if (pd.ValueSource == XmlValueSource.Attribute)
            {
                sw.WriteLine("        [XmlAttribute]");
            }
            else if (pd.ValueSource == XmlValueSource.Text)
            {
                sw.WriteLine("        [XmlText]");
            }
            else
            {
                sw.WriteLine("        [XmlElement(ElementName = \"{0}\", Namespace = \"{1}\")]",
                    pd.Name, pd.XmlNameSpaceUri
                    );
            }
           
            sw.WriteLine("        public {0}{1} {2} {{ get; set; }}", 
                xci.dicClasses.ContainsKey(pd.TypeName)?(pd.TypeName+"Class"):pd.TypeName, 
                pd.IsMulti?"[]":"", pd.Name);
        }

        private string GetExampleText(Dictionary<string, string> dicExampleValues)
        {
            
            // 最多10项数据
            return string.Join(", ", dicExampleValues.Values.Take(10)
                .Select(s=> {
                    return "[" + HttpUtility.HtmlEncode(s) + "]";
                })
                .ToArray()
                );
        }
    }
}
