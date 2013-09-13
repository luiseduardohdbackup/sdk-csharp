using GoKuai_EntSDK.UtilClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokuaiEntDemo.Model
{
    public class FileListData : BaseData
    {
        private const string LOG_TAG = "list";
        private const string KEY_LIST = "list";
        private const string KEY_COUNT = "count";


        /// <summary>
        /// 文件数量
        /// </summary>
        public int Count
        {
            get;
            set;
        }

        /// <summary>
        /// 文件
        /// </summary>
        public List<FileData> DataList
        {
            private set;
            get;
        }

        new public static FileListData Create(string jsonString) 
        {
            if (jsonString == null) return null;

            FileListData data = new FileListData();
            try
            {
                var json =  (IDictionary<string, object>)SimpleJson.DeserializeObject(jsonString);
                data.ErrorCode = SimpleJson.TryIntValue(json, KEY_ERROR_CODE);
                data.ErrorMessage = SimpleJson.TryStringValue(json, KEY_ERROR_MSG);
                if (data.ErrorCode == 0)
                {
                    data.Count = SimpleJson.TryIntValue(json,KEY_COUNT);
                    JsonArray jsonArray = SimpleJson.TryJsonArrayValue(json,KEY_LIST);
                    List<FileData> list=new List<FileData>();
                    foreach (JsonObject jsonobject in jsonArray)
                    {
                        list.Add(FileData.Create(jsonobject));
                    }
                    data.DataList = list;
                }
                return data;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(LOG_TAG + "==>" + ex.StackTrace);
                return new FileListData();

            }
        }
    }
}
