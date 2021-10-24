using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ContractExamService
{
    public class XmlLoader
    {
        public string Path { get; private set; }
        public void Load()
        {
            using (XmlReader reader = XmlReader.Create(Path))
            {
                    
            }
        }
    }
}
