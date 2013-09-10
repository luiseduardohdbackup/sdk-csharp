using GoKuai_EntSDK.Net;
using GoKuai_EntSDK.UtilClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokuaiEntDemo.Model
{
    public class FileData:BaseData
    {
        private const string LOG_TAG = "FileData";

        private const string KEY_HASH = "hash";
        private const string KEY_DIR = "dir";
        private const string KEY_FULLPATH = "fullpath";
        private const string KEY_FILENAME = "filename";
        private const string KEY_LAST_MEMBER_NAME = "last_member_name";
        private const string KEY_LAST_DATELINE = "last_dateline";
        private const string KEY_FILEHASH = "filehash";
        private const string KEY_FILESIZE = "filesize";
        private const string KEY_URI = "uri";
        private const string KEY_PREVIEW = "preview";
        private const string KEY_THUMBNAIL = "thumbnail";

        public string FileHash
        {
            get;
            private set;
        }

        public string Hash
        {
            get;
            private set;
        }

        public int Dir
        {
            get;
            private set;
        }
        public string FullPath
        {
            get;
            private set;
        }

        public string FileName 
        {
            get;
            private set;
        }

        public string LastMemberName
        {
            get;
            private set;
        }

        public long LastDateline
        {
            get;
            private set;
        }

        public long FileSize
        {
            get;
            private set;
        }

        public string Uri
        {
            get;
            private set;
        }

        public string Preview
        {
            get;
            private set;
        }

        public string ThumbNail
        {
            get;
            private set;
        }

        /// <summary>
        /// 单文件信息
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        new public static FileData Create(string jsonString)
        {
            if (jsonString == null) return null;

            FileData data = new FileData();
            try
            {
                var json = (IDictionary<string, object>)SimpleJson.DeserializeObject(jsonString);
                data.ErrorCode = SimpleJson.TryIntValue(json, KEY_ERROR_CODE);
                data.ErrorMessage = SimpleJson.TryStringValue(json, KEY_ERROR_MSG);
                if (data.ErrorCode == 0) 
                {
                    data.Dir = SimpleJson.TryIntValue(json, KEY_DIR);
                    data.FileHash = SimpleJson.TryStringValue(json, KEY_FILEHASH);
                    data.FileName = SimpleJson.TryStringValue(json, KEY_FILENAME);
                    data.FileSize = SimpleJson.TryLongValue(json, KEY_FILESIZE);
                    data.FullPath = SimpleJson.TryStringValue(json, KEY_FULLPATH);
                    data.LastDateline = SimpleJson.TryLongValue(json, KEY_LAST_DATELINE);
                    data.Hash = SimpleJson.TryStringValue(json, KEY_HASH);
                    data.LastMemberName = SimpleJson.TryStringValue(json, KEY_LAST_MEMBER_NAME);
                    data.Preview = SimpleJson.TryStringValue(json, KEY_PREVIEW);
                    data.ThumbNail = SimpleJson.TryStringValue(json, KEY_THUMBNAIL);
                    data.Uri = SimpleJson.TryStringValue(json, KEY_URI);
                
                }
                return data;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(LOG_TAG + "==>" + ex.StackTrace);
                return null;

            }

        }

        /// <summary>
        /// 文件列表中单文件
        /// </summary>
        /// <param name="jsonObject"></param>
        /// <returns></returns>
        public static FileData Create(JsonObject jsonObject)
        {

            if (jsonObject == null)
            {
                return null;
            }

            FileData data = new FileData();
            data.Dir = SimpleJson.TryIntValue(jsonObject, KEY_DIR);
            data.FileHash = SimpleJson.TryStringValue(jsonObject, KEY_FILEHASH);
            data.FileName = SimpleJson.TryStringValue(jsonObject, KEY_FILENAME);
            data.FileSize = SimpleJson.TryLongValue(jsonObject, KEY_FILESIZE);
            data.FullPath = SimpleJson.TryStringValue(jsonObject, KEY_FULLPATH);
            data.LastDateline = SimpleJson.TryLongValue(jsonObject, KEY_LAST_DATELINE);
            data.Hash = SimpleJson.TryStringValue(jsonObject, KEY_HASH);
            data.LastMemberName = SimpleJson.TryStringValue(jsonObject, KEY_LAST_MEMBER_NAME);
            data.Preview = SimpleJson.TryStringValue(jsonObject, KEY_PREVIEW);
            data.ThumbNail = SimpleJson.TryStringValue(jsonObject, KEY_THUMBNAIL);
            data.Uri = SimpleJson.TryStringValue(jsonObject, KEY_URI);
            return data;
        }



    }
}
