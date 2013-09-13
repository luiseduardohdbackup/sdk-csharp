using GoKuai_EntSDK.UtilClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokuaiEntDemo.Model
{
    public class UpdateFileList : BaseData
    {
        private const string LOG_TAG = "UpdateFileList";

        public List<UpdateItem> Datalist { get; private set; }
        public static UpdateFileList Create(string jsonString)
        {
            if (jsonString == null) return null;

            UpdateFileList data = new UpdateFileList();
            try
            {

                JsonArray jsonArray = null;
                try
                {
                    jsonArray = SimpleJson.DeserializeObject<JsonArray>(jsonString);
                }
                catch
                {
                    jsonArray = null;
                }

                if (jsonArray != null)
                {
                    List<UpdateItem> list = new List<UpdateItem>();
                    foreach (JsonObject jsonobject in jsonArray)
                    {
                        UpdateItem item = UpdateItem.Create(jsonobject);
                        list.Add(item);
                    }
                    data.Datalist = list;

                }
                else
                {
                    //如果参数错误，就不是jsonArray，是一个jsonobject对象
                    var json = (IDictionary<string, object>)SimpleJson.DeserializeObject(jsonString);
                    data.ErrorCode = SimpleJson.TryIntValue(json, KEY_ERROR_CODE);
                    data.ErrorMessage = SimpleJson.TryStringValue(json, KEY_ERROR_MSG);

                }
                return data;


            }
            catch (Exception ex)
            {
                Debug.WriteLine(LOG_TAG + "==>" + ex.StackTrace);
                return null;

            }

        }
    }
}
