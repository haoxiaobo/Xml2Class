using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Xml2Class
{
    /// <summary>
    /// 类定义
    /// </summary>
    [XmlInclude(typeof(XmlClassDef))]
    public class XmlClassDef
    {
        public string FullName {
            get {
                if (string.IsNullOrWhiteSpace(this.XmlPreFix))
                {
                    return Name;
                }
                else
                {
                    return this.XmlPreFix + "." + this.Name;
                }
            }
        }

        /// <summary>
        /// 类名，字典值
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string XmlNameSpaceUri { get; set; }

        public string XmlPreFix { get; set; }

        /// <summary>
        /// 是否根对象
        /// </summary>
        public bool IsRoot { get; set; }

        /// <summary>
        /// 属性清单，以属性名为索引。
        /// </summary>
        public Dictionary<string, XmlPropertyDef> Properties { get; set; }
    }

    public class NameSpaceDef
    {
        public string NameSpaceUri { get; set; }
        public string PreFix { get; set; }
    }

    public class XmlClassesInfo
    {
        public Dictionary<string, XmlClassDef> dicClasses { get; set; } = new Dictionary<string, XmlClassDef>();
        public XmlDocumentType DocType { get; internal set; }
        public Dictionary<string, NameSpaceDef> dicNameSpaces { get; set; } = new Dictionary<string, NameSpaceDef>();

        private Dictionary<string, NameSpaceDef> dicFix2NameSpaces { get; set; } = new Dictionary<string, NameSpaceDef>();

        public void AddNameSpace(string sNameSpaceUri, string sPrefix)
        {
            if (string.IsNullOrWhiteSpace(sNameSpaceUri))
                return;

            var ns = new NameSpaceDef()
            {
                NameSpaceUri = sNameSpaceUri,
                PreFix = sPrefix
            };
            this.dicNameSpaces[sNameSpaceUri] = ns;
            this.dicFix2NameSpaces[sPrefix] = ns;
        }

        public string GetNameSpaceUriByPreFix(string sPrefix)
        {
            NameSpaceDef nsd;
            if (this.dicFix2NameSpaces.TryGetValue(sPrefix, out nsd))
            {
                return nsd.NameSpaceUri;
            }
            return null;
        }

        public string GetPreFixByNameSpaceUri(string sNameSpaceUri)
        {
            NameSpaceDef nsd;
            if (this.dicNameSpaces.TryGetValue(sNameSpaceUri, out nsd))
            {
                return nsd.PreFix;
            }
            return null;
        }
    }

    /// <summary>
    /// 属性定义
    /// </summary>
    public class XmlPropertyDef
    {
        /// <summary>
        /// 属性名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否是多对象？
        /// </summary>
        public bool IsMulti { get; set; } = false;

        public string XmlNameSpaceUri { get; set; } = "";


        public string XmlPreFix { get; set; }


        /// <summary>
        /// 属性类型定义
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 值从何来？子元素还是属性？
        /// </summary>
        public XmlValueSource ValueSource {get; set;}

        /// <summary>
        /// 是否非空？
        /// </summary>
        public bool NotNull { get; set; } = false;

        /// <summary>
        /// 示例值。
        /// </summary>
        public Dictionary<string, string> ExampleValues { get; internal set; }

        internal void AddExampleValue(string s)
        {
            if (this.ExampleValues == null)
            {
                this.ExampleValues = new Dictionary<string, string>();
            }
            var sLeft = this.GetLeft(s, 50, true);
            this.ExampleValues[sLeft] = sLeft;
        }

       private string GetLeft(string s, int len, bool bAddDot)
        {
            if (s == null)
                return "";

            if (bAddDot)
            {
                len = len - 3;
                if (len < 0)
                    len = 0;
            }
            if (s.Length > len)
            {
                return s.Substring(0, len) + (bAddDot ? "..." : "");
            }
            else
                return s;
        }
    }


    

    /// <summary>
    /// 值从哪里来？子元素，或是属性？
    /// </summary>
    public enum XmlValueSource {
        /// <summary>
        /// 从子元素来
        /// </summary>
        SubElement,

        /// <summary>
        /// 从属性来
        /// </summary>
        Attribute,

        /// <summary>
        /// 从Text来。
        /// </summary>
        Text,

    };
}
