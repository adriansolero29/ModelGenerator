using ModelGenerator.UI.Interface;

namespace ModelGenerator.UI.Helpers
{
    public class XMLServiceResolver
    {
        public delegate IXMLService ServiceResolverXML(XMLService key);
    }

    public enum XMLService
    {
        XMLDatabaseSetting,
        PropertyModels
    }
}
