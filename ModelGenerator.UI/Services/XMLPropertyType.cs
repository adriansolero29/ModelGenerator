using ModelGenerator.UI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace ModelGenerator.UI.Services
{
    public class XMLPropertyType : IXMLPropertyTypesList
    {
        public string XMLPath { get; set; }
        private XDocument xmlDoc;

        public XMLPropertyType()
        {
            this.XMLPath = "PropertyModelTypes.xml";
            this.xmlDoc = new XDocument();
        }

        public IEnumerable<string> GetProperties()
        {
            xmlDoc = XDocument.Load(XMLPath);
            var output = new List<string>();
            foreach (var item in xmlDoc.Root.DescendantNodes().OfType<XElement>().Select(x => x.Name).Distinct())
            {
                output.Add(item.LocalName);
            }

            return output;
        }
    }
}
