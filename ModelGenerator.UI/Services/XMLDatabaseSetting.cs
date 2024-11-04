using ModelGenerator.UI.Class;
using ModelGenerator.UI.Interface;
using System;
using System.IO;
using System.Xml;

namespace ModelGenerator.UI.Services
{
    public class XMLDatabaseSetting : IXMLService
    {
        public string XMLPath { get; private set; }
        private readonly XmlDocument xmlDoc;

        public XMLDatabaseSetting()
        {
            this.xmlDoc = new XmlDocument();
            this.XMLPath = "DatabaseSetting.xml";

            xmlDoc.Load(this.XMLPath);
            GetValues();
        }

        public string GetValues(string condition = null)
        {
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

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}
