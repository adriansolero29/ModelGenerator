using ModelGenerator.UI.Interface;
using static ModelGenerator.UI.Enums.Enums;

namespace ModelGenerator.UI.Helpers
{
    public class ServiceResolvers
    {
        public delegate IDataLoaderRepository ServiceResolver(DataLoaderService key);
        public delegate IXMLService ServiceResolverXML(XMLService key);
        public delegate IDataTypeConverter DataTypeConverterServiceResolver(DataLoaderService key);

    }
}
