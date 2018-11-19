using System;
using System.Collections.Generic;
using System.Text;

namespace CoreServices.ServiceObjects.Common
{
    /// <summary>
    /// for some fields, like Reserved field, riskRateInfo, cardTransData, tokenPayData
    /// it needs to be in a format: 
    /// reserved = {variable name1 = value1 & variable name2 = value2}
    /// for some others, like customerinfo, 
    /// it needs to add a prefix: BASE64
    /// customerInfo = BASE64 {variable name1=value1&..}
    /// </summary>
    public abstract class DictionaryObject
    {
        protected readonly Dictionary<string, string> dicData = new Dictionary<string, string>();

        protected string Get(string key)
        {
            dicData.TryGetValue(key, out var result);

            return result;
        }
        protected void Set(string key, string value)
        {
            dicData[key] = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var keyValue in dicData)
            {
                sb.Append(keyValue.Key);
                sb.Append("=");
                sb.Append(keyValue.Value);
                sb.Append("&");
            }
            sb.Remove(sb.Length - 1, 1);

            return $"{{{sb.ToString()}}}";
        }
    }
}
