using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace ContractExamService
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch b;
            BatchContractContractData batchContractContractData = new BatchContractContractData();
            BatchContract batchContract;
            
            string ns = "{http://creditinfo.com/schemas/Sample/Data}";
            XmlLoader xmlLoader = new XmlLoader();
            IEnumerable<XElement> elements = xmlLoader.SimpleStreamAxis("Contract");
            foreach (XElement xElement in elements)
            {
                Console.WriteLine(xElement.Name);
                Console.WriteLine(xElement.Element(ns + "Individual").Element(ns + "Gender").Value);
            }
            Console.Read();
        }
    }
}
