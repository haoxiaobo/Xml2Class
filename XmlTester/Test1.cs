using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XmlTester
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void LoadAllXml()
        {
            TestXmlLoadAndWrite(@"d:\mydocuments\haoxb01\my documents\visual studio 2015\Projects\Xml2Class\XmlTester\getPartyWithContracts.req.xml", typeof(getPartyWithContracts.req.TCRMServiceClass));

            TestXmlLoadAndWrite(@"d:\mydocuments\haoxb01\my documents\visual studio 2015\Projects\Xml2Class\XmlTester\getPartyWithContracts.resp.xml", typeof(getPartyWithContracts.resp.TCRMServiceClass));

            TestXmlLoadAndWrite(@"d:\mydocuments\haoxb01\my documents\visual studio 2015\Projects\Xml2Class\XmlTester\searchPerson.req.xml", typeof(searchPerson.req.TCRMServiceClass));

            TestXmlLoadAndWrite(@"d:\mydocuments\haoxb01\my documents\visual studio 2015\Projects\Xml2Class\XmlTester\searchPerson.resp.xml", typeof(searchPerson.resp.TCRMServiceClass));
        }

        private void TestXmlLoadAndWrite(string sInXmlFileName, Type type)
        {
            using (var sr = new StreamReader(sInXmlFileName, Encoding.UTF8))
            {
                var ser = new XmlSerializer(type);

                object obj = ser.Deserialize(sr);

                Assert.IsNotNull(obj);
                Assert.IsInstanceOfType(obj, type);

                string sOutFile2 = Path.GetFileNameWithoutExtension(sInXmlFileName) + "2.xml";

                using (var sw = new StreamWriter(sOutFile2, false, Encoding.UTF8))
                {
                    ser.Serialize(sw, obj);
                }
            }
        }

        [TestMethod]
        public void TestDic()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("a", "aaa");
            // dic.Add("a", "22a"); // exception

            dic["b"] = "bbb";
            dic["b"] = "bb2";

            // var c = dic["c"]; // exception
            string c;
            var b = dic.TryGetValue("c", out c);
            Assert.IsFalse(b);
            Assert.IsNull(c);
            
        }
    }
}
