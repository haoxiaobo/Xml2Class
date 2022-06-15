using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml2Class
{
    public abstract class ClassFileGeneratorBase
    {
        public abstract void GenClasses(ClassesInfo xci, string sBaseNameSpace, string sBasePath);
    }
}
