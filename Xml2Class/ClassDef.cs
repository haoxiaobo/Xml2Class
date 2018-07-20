using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml2Class
{
    public class ClassDef
    {
        /// <summary>
        /// 类名，字典值
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否根对象
        /// </summary>
        public bool IsRoot { get; set; }

        /// <summary>
        /// 属性清单，以属性名为索引。
        /// </summary>
        public Dictionary<string, PropertyDef> Properties { get; set; } = new Dictionary<string, PropertyDef>();

        public PropertyDef GetOrCreatePropertiy(string sPropertyName)
        {
            PropertyDef p = null;
            this.Properties.TryGetValue(sPropertyName, out p);
            if (p == null)
            {
                p = new PropertyDef()
                {
                    Name = sPropertyName,
                    ExampleValues = new Dictionary<string, string>(),
                    IsMulti = false,
                    NotNull = true,
                };
                this.Properties[sPropertyName] = p;
            }
            return p;
        }
    }

    public class PropertyDef
    {
        /// <summary>
        /// 属性名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否是多对象？
        /// </summary>
        public bool IsMulti { get; set; } = false;


        /// <summary>
        /// 属性类型定义
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 示例值。
        /// </summary>
        public Dictionary<string, string> ExampleValues { get; internal set; }

        /// <summary>
        /// 是否非空？
        /// </summary>
        public bool NotNull { get; set; } = false;

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

    public class ClassesInfo
    {
        public Dictionary<string, ClassDef> dicClasses { get; set; } = new Dictionary<string, ClassDef>();

        public bool HasClass(string sClassName)
        {
            return dicClasses.ContainsKey(sClassName);
        }

        public ClassDef GetOrGenClass(string sClassName)
        {
            var cls = this[sClassName];
            if (cls == null)
            {
                cls = new ClassDef() { Name = sClassName };
                this[sClassName] = cls;
            }
            return cls;
        }

        public ClassDef this[string sClassName]
        {
            get
            {
                ClassDef cls = null;
                dicClasses.TryGetValue(sClassName, out cls);
                return cls;
            }

            set {
                dicClasses[sClassName]= value;
            }
        }

        public string ToJsonString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                this.dicClasses.Values.ToArray(), 
                Newtonsoft.Json.Formatting.Indented);
        }
    }
}
