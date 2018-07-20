using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml2Class
{
    public abstract class DatagramAnalyzor
    {
        public abstract ClassesInfo AnalysistDatagram(string sDatagram);

        public ClassesInfo AnalysistDataFile(string sFileName, Encoding en)
        {
            using (var sr = new StreamReader(sFileName, en, true))
            {
                string sXml = sr.ReadToEnd();
                sr.Close();
                return AnalysistDatagram(sXml);
            }
        }
    }
}
