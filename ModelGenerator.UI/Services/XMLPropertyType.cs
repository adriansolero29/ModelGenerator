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
        private readonly XDocument xmlDoc;

        public XMLPropertyType()
        {
            this.xmlDoc = new XDocument();
            this.XMLPath = "PropertyModelTypes.xml";
            xmlDoc = XDocument.Load(XMLPath);
        }

        public IEnumerable<string> GetProperties()
        {
            var output = new List<string>();
            foreach (var item in xmlDoc.Root.DescendantNodes().OfType<XElement>().Select(x => x.Name).Distinct())
            {
                output.Add(item.LocalName);
            }

            return output;
        }
    }
}
