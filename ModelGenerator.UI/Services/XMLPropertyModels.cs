using ModelGenerator.UI.Interface;
using System;
using System.Xml;

namespace ModelGenerator.UI.Services
{
    public class XMLPropertyModels : IXMLService
    {
        public string XMLPath { get; private set; }
        private readonly XmlDocument xmlDoc;

        public XMLPropertyModels()
        {
            this.xmlDoc = new XmlDocument();
            this.XMLPath = "PropertyModelTypes.xml";

            xmlDoc.Load(this.XMLPath);
            GetValues();
        }

        public string GetValues(string condition = null)
        {
            if (condition == null)
            {
                return string.Empty;
            }
            else
            {
                var xml = xmlDoc.DocumentElement;
                var modelType = xml.GetElementsByTagName(condition);
                return modelType.Item(0).InnerText.Trim();
            }
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
