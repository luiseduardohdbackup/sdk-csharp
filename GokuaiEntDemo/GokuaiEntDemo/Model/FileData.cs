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

        /// <summary>
        /// 文件hash
        /// </summary>
        public string FileHash
        {
            get;
            set;
        }

        /// <summary>
        /// 路径hash
        /// </summary>
        public string Hash
        {
            get;
            set;
        }

        /// <summary>
        /// 是否为文件夹 1是 0否
        /// </summary>
        public int Dir
        {
            get;
            set;
        }
        /// <summary>
        /// 服务端文件全路径
        /// </summary>
        public string FullPath
        {
            get;
            set;
        }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName 
        {
            get;
            set;
        }

        /// <summary>
        /// 最后修改人
        /// </summary>
        public string LastMemberName
        {
            get;
            set;
        }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public long LastDateline
        {
            get;
            set;
        }

        /// <summary>
        /// 文件大小
        /// </summary>
        public long FileSize
        {
            get;
            set;
        }

        /// <summary>
        /// 文件下载地址
        /// </summary>
        public string Uri
        {
            get;
            set;
        }

        /// <summary>
        /// 文件预览地址
        /// </summary>
        public string Preview
        {
            get;
            set;
        }

        /// <summary>
        /// 文件缩略图地址
        /// </summary>
        public string ThumbNail
        {
            get;
            set;
        }

        public string UpFullPath
        {
            set;
            get;
        }

        /// <summary>
        /// 是否为团队共享
        /// </summary>
        public int OrgShare
        {
            get;
            set;
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
