using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Xml2Class
{
    public class JsonAnalyzor : DatagramAnalyzor
    {
        public override ClassesInfo AnalysistDatagram(string sDatagram)
        {
            var classes = new ClassesInfo();
            var jToken = Newtonsoft.Json.Linq.JToken.Parse(sDatagram);

            AnalysistJToken("RootClass", jToken, classes);

            classes.GetOrGenClass("RootClass").IsRoot = true;
             

            return classes;
        }

        private void AnalysistJToken(string sClassName, JToken jToken, ClassesInfo classes)
        {
            // 生成根对象的类。
            if (jToken is JArray)
            {
                JArray ja = jToken as JArray;
                AnalysistJArray(sClassName, ja, classes);
            }
            else if (jToken is JObject)
            {
                JObject jo = jToken as JObject;
                AnalysistJObject(sClassName, jo, classes);
            }
        }


        private void AnalysistJObject(string sClassName, JObject jo, ClassesInfo classes)
        {
            // 创建一个类。
            var cls = classes.GetOrGenClass(sClassName);
            // 本次处理中有值的属性
            Dictionary<string, JToken> dicPropertiesWithValue = new Dictionary<string, JToken>();
            // 循环属性
            foreach (var jt in jo)
            {
                // Console.WriteLine("property: {0} = {1}", jt.Key, jt.Value);
                var sPropertyName = jt.Key;
                var oPropertyValue = jt.Value;
                // 在当前对象中增加此属性。
                var p = cls.GetOrCreatePropertiy(jt.Key);

                if (oPropertyValue.Type != JTokenType.Null && oPropertyValue.Type != JTokenType.Undefined)
                {
                    dicPropertiesWithValue[sPropertyName] = oPropertyValue;
                }
                // 如是简单的值
                if (oPropertyValue is JValue)
                {
                    var jv = oPropertyValue as JValue; 
                    string sTypeName = ConvertJType2ClrType(jv.Type);
                    if (!string.IsNullOrWhiteSpace(sTypeName))
                    {
                        p.Type = sTypeName;
                    }
                    if (jv.Value != null)
                    {
                        p.AddExampleValue(jv.Value.ToString());
                    }
                    continue;
                }

                if (oPropertyValue is JArray)
                {
                    p.IsMulti = true;
                }

                p.Type = sPropertyName + "Class";
                // 非简单的值，那么递归处理。
                AnalysistJToken(p.Type, oPropertyValue, classes);
                
            }

            // 发现原来存在，这次不存在或是值为空的属性, 设置可null;
            foreach (var pk in cls.Properties.Keys)
            {
                if (!dicPropertiesWithValue.ContainsKey(pk))
                {
                    cls.Properties[pk].NotNull = false;
                }
            }
        }

        private string ConvertJType2ClrType(JTokenType type)
        {
            switch (type)
            {
                case JTokenType.Boolean:
                    return "bool";
                case JTokenType.Bytes:
                    return "byte[]";
                case JTokenType.Date:
                    return "DateTime";
                case JTokenType.Float:
                    return "double";
                case JTokenType.Guid:
                    return "Guid";
                case JTokenType.Integer:
                    return "int";
                case JTokenType.None:
                    return "";
                case JTokenType.Null:
                    return "";
                case JTokenType.Object:
                    return "object";
                case JTokenType.String:
                    return "string";
                case JTokenType.TimeSpan:
                    return "TimeSpan";
                case JTokenType.Undefined:
                    return "";
                case JTokenType.Uri:
                    return "Uri";
                default:
                    return "";
            }
        }

        private void AnalysistJArray(string sClassName, JArray ja, ClassesInfo classes)
        {
            // 每个元素的类应该是同一个类。
            foreach (var jt in ja)
            {
                AnalysistJToken(sClassName, jt, classes);
            }
        }
    }
}
