using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Xml2Class;

namespace XmlTester
{
    [TestClass]
    public class TestXml
    {
        [TestMethod]
        public void LoadAllXml()
        {
            GenXmlClass(@"Xmls\searchPerson.req.xml");
            GenXmlClass(@"Xmls\searchPerson.resp.xml");
            GenXmlClass(@"Xmls\getPartyWithContracts.req.xml");
            GenXmlClass(@"Xmls\getPartyWithContracts.resp.xml");
            GenXmlClass(@"Xmls\GetBriefContractsByParty.xml");
            GenXmlClass(@"Xmls\getBriefContractsByParty_Response.xml");

            //TestXmlLoadAndWrite(@"Xmls\getPartyWithContracts.req.xml", typeof(getPartyWithContracts.req.TCRMServiceClass));
            //TestXmlLoadAndWrite(@"Xmls\getPartyWithContracts.resp.xml", typeof(getPartyWithContracts.resp.TCRMServiceClass));
            //TestXmlLoadAndWrite(@"Xmls\searchPerson.req.xml", typeof(searchPerson.req.TCRMServiceClass));
            //TestXmlLoadAndWrite(@"Xmls\searchPerson.resp.xml", typeof(searchPerson.resp.TCRMServiceClass));
        }

        private static void GenXmlClass(string sFileName)
        {
            var sMainFileName = Path.GetFileNameWithoutExtension(sFileName);
            DatagramAnalyzor analyzor = new XmlAnalyzor();
            var xci = analyzor.AnalysistDataFile(sFileName, Encoding.UTF8);

            var sBasePath = @"Xmls";
            var sBaseNameSpace = sMainFileName;
            ClassFileGeneratorBase cg = new CSharpGenerator();
            cg.GenClasses(xci, sBaseNameSpace, sBasePath);

            ClassFileGeneratorBase jg = new JavaGenerator();
            jg.GenClasses(xci, sBaseNameSpace, sBasePath);
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
    }
}
