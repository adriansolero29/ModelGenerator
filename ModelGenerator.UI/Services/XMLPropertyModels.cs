using ModelGenerator.UI.Interface;
using System;
using System.Xml;
using System.Xml.Linq;

namespace ModelGenerator.UI.Services
{
    public class XMLPropertyModels : IXMLService, IXMLDataProcessor
    {
        public string XMLPath { get; set; }
        private XmlDocument xmlDoc;

        public XMLPropertyModels()
        {
            GetValues();
        }

        public string GetValues(string condition = null)
        {
            LoadXML();
            if (condition == null)
            {
                return string.Empty;
            }
            else
            {
                var xml = xmlDoc.DocumentElement;
                var modelType = xml.GetElementsByTagName(condition);
                return modelType.Item(0).InnerText;
            }
        }

        public void Write(string elementName, string elementValue)
        {
            XDocument xdoc = XDocument.Load(XMLPath);
            XElement element = xdoc.Element("propertyTypes");
            element.SetElementValue(elementName, elementValue);

            xdoc.Save(XMLPath);
        }

        public void Add(string elementName, string elementValue)
        {
            XDocument xdoc = XDocument.Load(XMLPath);
            XElement element = xdoc.Element("propertyTypes");
            element.SetElementValue(elementName, elementValue);

            xdoc.Save(XMLPath);
        }

        public void LoadXML()
        {
            this.xmlDoc = new XmlDocument();
            this.XMLPath = "PropertyModelTypes.xml";
            xmlDoc.Load(this.XMLPath);
        }

        public void Delete(string elementName)
        {
            LoadXML();
            var parent = xmlDoc.SelectSingleNode("propertyTypes");
            var toDelete = parent.SelectSingleNode(elementName);
            parent.RemoveChild(toDelete);

            xmlDoc.Save(XMLPath);
        }
    }
}
