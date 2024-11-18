using ModelGenerator.UI.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelGenerator.UI.Helpers
{
    public static class ModelOutputGenerator
    {
        public static string ModelSchema { get; set; }
        public static string ModelName { get; set; }


        public static string Output(string propertyTypeTag, List<(string, string)> propName_DataType, bool IsObjectLoader, string dataTypeSuffix, IXMLService xmlPropertyService, IDataTypeConverter dataTypeConverter)
        {
            string output = "";

            StringBuilder stringBuilder = new StringBuilder(string.Empty);
            var propFormat = xmlPropertyService.GetValues(propertyTypeTag);

            foreach (var item in propName_DataType)
            {
                string tempFormat = propFormat;
                string propOutput = tempFormat.Replace("PropertyNameValue", item.Item1);
                var res = propOutput.Replace("DataTypeValue", dataTypeConverter.Convert(item.Item2));
                var finalResult = res.Replace("_propertyNameValue", "_" + item.Item1.Substring(0, 1).ToLower() + item.Item1.Substring(1));

                if (IsObjectLoader)
                {
                    if (item.Item1.Length > 2 && item.Item1.Substring(item.Item1.Length - 2) == "Id")
                    {
                        var dataType = item.Item1.Substring(0, item.Item1.Length - 2);
                        finalResult = tempFormat.Replace("DataTypeValue", dataType + dataTypeSuffix).Replace("PropertyNameValue", item.Item1).Replace("_propertyNameValue", "_" + item.Item1.Substring(0, 1).ToLower() + item.Item1.Substring(1));
                    }
                }

                stringBuilder.Append($"{finalResult}");
            }

            output = @$"using System;
using System.Text;

namespace {ModelSchema}
{{
    public class {ModelName}
    {{
        {stringBuilder.ToString()}

    }}
}}";

            return output;
        }
    }
}
