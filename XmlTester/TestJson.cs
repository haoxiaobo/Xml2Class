using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlTester
{
    [TestClass]
    public class TestJson
    {
        [TestMethod]
        public void TestJson1()
        {
            var ja = new Xml2Class.JsonAnalyzor();
            var classes = ja.AnalysistDataFile("jsons\\test1.json", Encoding.UTF8);
            Assert.IsTrue(classes.dicClasses.Count > 0);
            Console.WriteLine(classes.ToJsonString());

            Xml2Class.CSharpGenerator csgen = new Xml2Class.CSharpGenerator();
            csgen.GenClasses(classes, "TestJsonGen", "..\\..\\GenCodes");

            Xml2Class.JavaGenerator jGen = new Xml2Class.JavaGenerator();
            jGen.GenClasses(classes, "TestJsonGen", "..\\..\\GenCodes");

        }
    }
}
