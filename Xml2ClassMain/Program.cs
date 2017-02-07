using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xml2Class;

namespace Xml2ClassMain
{
    class Program
    {
        static void Main(string[] args)
        {
            GenXmlClass(@"D:\MyDocuments\haoxb01\My Documents\Visual Studio 2015\Projects\Xml2Class\XmlTester\searchPerson.req.xml");
            GenXmlClass(@"D:\MyDocuments\haoxb01\My Documents\Visual Studio 2015\Projects\Xml2Class\XmlTester\searchPerson.resp.xml");
            GenXmlClass(@"D:\MyDocuments\haoxb01\My Documents\Visual Studio 2015\Projects\Xml2Class\XmlTester\getPartyWithContracts.req.xml");
            GenXmlClass(@"D:\MyDocuments\haoxb01\My Documents\Visual Studio 2015\Projects\Xml2Class\XmlTester\getPartyWithContracts.resp.xml");
            GenXmlClass(@"D:\MyDocuments\haoxb01\My Documents\Visual Studio 2015\Projects\Xml2Class\XmlTester\ecm.xml");
        }

        private static void GenXmlClass(string sFileName)
        {
           var sMainFileName = Path.GetFileNameWithoutExtension(sFileName);

            var xci = Xml2Class.XmlAnalyzor.AnalysistXmlFile(sFileName, Encoding.UTF8);

            var sBasePath = @"D:\MyDocuments\haoxb01\My Documents\Visual Studio 2015\Projects\Xml2Class\XmlTester";
            var sBaseNameSpace = sMainFileName;
            ClassFileGeneratorBase cg = new CSharpGenerator();
            cg.GenClasses(xci, sBaseNameSpace, sBasePath);
        }
    }
}
