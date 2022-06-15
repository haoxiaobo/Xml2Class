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
    public class JavaGenerator : ClassFileGeneratorBase
    {
        public override void GenClasses(ClassesInfo xci, string sBaseNameSpace, string sBasePath)
        {   
            var classes = (from c in xci.dicClasses.Values
                           orderby c.IsRoot
                           select c).ToArray();
            foreach (var c in classes)
            {
                this.GenClass(c, xci, sBaseNameSpace, sBasePath);
            }
        }

        private void GenClass(ClassDef c, ClassesInfo xci, string sBaseNameSpace, string sBasePath)
        {
            string sPath;
            if (c is XmlClassDef )
                sPath = Path.Combine(sBasePath, sBaseNameSpace, (c as XmlClassDef).XmlPreFix);
            else
                sPath = Path.Combine(sBasePath, sBaseNameSpace);

            string sFileName = c.Name + ".gen.java";
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

        private void GenClass(ClassDef c, ClassesInfo xci,
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

        private void GenClassFileHeader(ClassDef c, ClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            XmlClassDef xc = c as XmlClassDef;

            sw.WriteLine(@"//---------------------------------------------------");
            sw.WriteLine(@"// class {0}", xc?.FullName??c.Name);
            sw.WriteLine(@"// date: {0:yyyy-MM-dd HH:mm}", DateTime.Now);
            sw.WriteLine(@"// 本代码由 Xml2Class 生成器 (by Haoxiaobo) 自动生成");
            sw.WriteLine(@"//---------------------------------------------------");

            sw.WriteLine(
@"import java.lang;
import {0};
",
sBaseNameSpace);

            sw.Write("namespace {0}", sBaseNameSpace);
            if (!string.IsNullOrWhiteSpace(xc?.XmlPreFix))
            {
                sw.Write("." + xc.XmlPreFix);
            }
            sw.WriteLine();

            sw.WriteLine("{");
            return;
        }
        private void GenClassFileTail(ClassDef c, ClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            sw.WriteLine("}");
            return;
        }

        private void GenClassDefHeader(ClassDef c, ClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            XmlClassDef xc = c as XmlClassDef;

            sw.WriteLine(@"
    /***
    * {0} 类
    **/", xc?.FullName??c.Name);
            sw.WriteLine("    @Serializable");
            if (c.IsRoot) {
                sw.WriteLine("    @XmlRoot(ElementName = \"{0}\",Namespace = \"{1}\")", c.Name, xc?.XmlNameSpaceUri);

                foreach (var cls in xci.dicClasses.Values)
                {
                    var xcls = cls as XmlClassDef; 
                    sw.WriteLine("    @XmlInclude(typeof({0}Class))", xcls?.FullName??cls.Name);
                }
            }
            sw.WriteLine(
@"    public class {0}
    {{",
     c.Name
);
            return;
        }

        private void GenClassDefTail(ClassDef c, ClassesInfo xci, string sBaseNameSpace, StreamWriter sw)
        {
            sw.WriteLine("    }");
        }

        private void GenClassPropertiesDef(PropertyDef pd, ClassDef c, ClassesInfo xci, 
            string sBaseNameSpace, StreamWriter sw)
        {
            XmlClassDef xc = c as XmlClassDef;
            XmlPropertyDef xpd = pd as XmlPropertyDef;

            sw.WriteLine(
            @"
        /*** 
        * {0}", pd.Name);

           

            if (pd.ExampleValues != null && pd.ExampleValues.Values.Count != 0)
            {   
                sw.WriteLine("        * example: {0}", 
                    this.GetExampleText(pd.ExampleValues));
                
            }
            sw.WriteLine("        */");

            StringBuilder sb = new StringBuilder();
            if (xpd?.ValueSource == XmlValueSource.Attribute)
            {
                sb.AppendLine();
                sb.AppendFormat("        @XmlAttribute");
                
            }
            else if (xpd?.ValueSource == XmlValueSource.Text)
            {
                sb.AppendLine();
                sb.AppendFormat("        @XmlText");
               
            }
            else if(xpd?.ValueSource == XmlValueSource.SubElement)
            {
                sb.AppendLine();
                sb.AppendFormat("        @XmlElement(ElementName = \"{0}\", Namespace = \"{1}\")",
                    pd.Name, xpd?.XmlNameSpaceUri
                    );
            }

            string sType = Convert2CsharpType(pd.Type);

            sw.WriteLine(
@"        private {0}{1} _{2};
        {3}
        public {0}{1} get{2}() {{
             return this._{2};
        }}
        {3}
        public void set{2}({0}{1} val){{
             this._{2} = val;
        }}
", 
                pd.Type, pd.IsMulti?"[]":"", UpcaseFirstLatter(pd.Name), sb.ToString());
        }

        private string Convert2CsharpType(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
                return "object";

            return type;
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

        private string UpcaseFirstLatter(string sWord)
        {
            if (string.IsNullOrWhiteSpace(sWord))
            {
                return "";
            }

            var arrWord = sWord.Trim().ToCharArray();
            arrWord[0] = char.ToUpper(arrWord[0]);
            return new string(arrWord);
        }
    }
}
