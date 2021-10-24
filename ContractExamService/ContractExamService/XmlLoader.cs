using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContractExamService
{
    public class XmlLoader
    {
        public string Path { get; private set; }

        public XmlLoader()
        {
            this.Path = AppDomain.CurrentDomain.BaseDirectory + "example.xml";
        }
        public IEnumerable<XElement> SimpleStreamAxis(string elementName)
        {
            using (XmlReader reader = XmlReader.Create(Path))
            {
                reader.MoveToContent();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == elementName)
                        {
                            XElement el = XNode.ReadFrom(reader) as XElement;
                            if (el != null)
                            {
                                yield return el;
                            }
                        }
                    }
                }
            }
        }
    }
}
