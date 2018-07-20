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
    public class XmlClassDef : ClassDef
    {
        public string FullName
        {
            get
            {
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
        /// 命名空间
        /// </summary>
        public string XmlNameSpaceUri { get; set; }

        public string XmlPreFix { get; set; }




    }

    public class XmlNameSpaceDef
    {
        public string XmlNameSpaceUri { get; set; }
        public string XmlPreFix { get; set; }
    }

    public class XmlClassesInfo : ClassesInfo
    {

        public XmlDocumentType DocType { get; internal set; }
        public Dictionary<string, XmlNameSpaceDef> dicNameSpaces { get; set; } = new Dictionary<string, XmlNameSpaceDef>();

        private Dictionary<string, XmlNameSpaceDef> dicFix2NameSpaces { get; set; } = new Dictionary<string, XmlNameSpaceDef>();

        public void AddNameSpace(string sNameSpaceUri, string sPrefix)
        {
            if (string.IsNullOrWhiteSpace(sNameSpaceUri))
                return;

            var ns = new XmlNameSpaceDef()
            {
                XmlNameSpaceUri = sNameSpaceUri,
                XmlPreFix = sPrefix
            };
            this.dicNameSpaces[sNameSpaceUri] = ns;
            this.dicFix2NameSpaces[sPrefix] = ns;
        }

        public string GetNameSpaceUriByPreFix(string sPrefix)
        {
            XmlNameSpaceDef nsd;
            if (this.dicFix2NameSpaces.TryGetValue(sPrefix, out nsd))
            {
                return nsd.XmlNameSpaceUri;
            }
            return null;
        }

        public string GetPreFixByNameSpaceUri(string sNameSpaceUri)
        {
            XmlNameSpaceDef nsd;
            if (this.dicNameSpaces.TryGetValue(sNameSpaceUri, out nsd))
            {
                return nsd.XmlPreFix;
            }
            return null;
        }
    }

    /// <summary>
    /// 属性定义
    /// </summary>
    public class XmlPropertyDef : PropertyDef
    {
        public string XmlNameSpaceUri { get; set; } = "";

        public string XmlPreFix { get; set; }

        /// <summary>
        /// 值从何来？子元素还是属性？
        /// </summary>
        public XmlValueSource ValueSource { get; set; }
    }




    /// <summary>
    /// 值从哪里来？子元素，或是属性？
    /// </summary>
    public enum XmlValueSource
    {
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
