using ModelGenerator.UI.Class;
using ModelGenerator.UI.Interface;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ModelGenerator.UI.Services
{
    public class XMLDatabaseSetting : IXMLService, IXMLDatabaseSetting
    {
        public string XMLPath { get; set; }
        private XmlDocument xmlDoc;

        public XMLDatabaseSetting()
        {
            GetValues();
        }

        public string GetValues(string condition = null)
        {
            LoadXML();

            if (File.Exists(XMLPath))
            {
                DataCommunication.ServerName = xmlDoc.DocumentElement.ChildNodes[0].InnerText;
                DataCommunication.PortNumber = xmlDoc.DocumentElement.ChildNodes[1].InnerText;
                DataCommunication.DatabaseName = xmlDoc.DocumentElement.ChildNodes[2].InnerText;
                DataCommunication.UserId = xmlDoc.DocumentElement.ChildNodes[3].InnerText;
                DataCommunication.Password = xmlDoc.DocumentElement.ChildNodes[4].InnerText;
                DataCommunication.DatabaseType = xmlDoc.DocumentElement.ChildNodes[5].InnerText;
            }
            else
                throw new FileNotFoundException("Database setting xml not found");

            return string.Empty;
        }

        public void Write(string elementName, string elementValue)
        {
            XDocument xdoc = XDocument.Load(XMLPath);
            XElement element = xdoc.Element("DatabaseSetting");
            element.SetElementValue(elementName, elementValue);

            xdoc.Save(XMLPath);
        }

        public void ChangeDatabaseSetting()
        {
            Write("ServerName", DataCommunication.ServerName);
            Write("PortNumber", DataCommunication.PortNumber);
            Write("DatabaseName", DataCommunication.DatabaseName);
            Write("UserId", DataCommunication.UserId);
            Write("Password", DataCommunication.Password);
            Write("DatabaseType", DataCommunication.DatabaseType);
        }

        public void Add(string elementName, string elementValue)
        {
            throw new NotImplementedException();
        }

        public void LoadXML()
        {
            this.xmlDoc = new XmlDocument();
            this.XMLPath = "DatabaseSetting.xml";

            xmlDoc.Load(this.XMLPath);
        }
    }
}
