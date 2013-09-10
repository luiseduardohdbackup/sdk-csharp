using GoKuai_EntSDK.UtilClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokuaiEntDemo.Model
{
    public class SearchResultData:BaseData
    {
        public string Code
        {
            get;
            private set;
        }

        new public static SearchResultData Create(string jsonString)
        {
            if (jsonString == null) return null;

            SearchResultData data = new SearchResultData();
            try
            {
                var json = (IDictionary<string, object>)SimpleJson.DeserializeObject(jsonString);
                data.ErrorCode = SimpleJson.TryIntValue(json, KEY_ERROR_CODE);
                data.ErrorMessage = SimpleJson.TryStringValue(json, KEY_ERROR_MSG);
                data.Code = SimpleJson.TryStringValue(json, "code");
                return data;

            }
            catch (Exception)
            {
                return null;

            }

        }
    }
}
