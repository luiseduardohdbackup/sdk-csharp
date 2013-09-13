using GoKuai_EntSDK.UtilClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokuaiEntDemo.Model
{
    public class UpdateItem
    {
        public static UpdateItem Create(JsonObject jsonObject)
        {
            if (jsonObject == null)
            {
                return null;
            }

            UpdateItem data = new UpdateItem();
            data.Act = SimpleJson.TryIntValue(jsonObject, "act");
            data.MemberId = SimpleJson.TryIntValue(jsonObject, "member_id");
            data.Dateline = SimpleJson.TryLongValue(jsonObject, "dateline");
            data.MemberName = SimpleJson.TryStringValue(jsonObject, "member_name");
            JsonArray arr = SimpleJson.TryJsonArrayValue(jsonObject, "files");

            //获取文件更新相关的文件
            List<FileData> list = new List<FileData>();
            foreach (JsonObject obj in arr) 
            {
                FileData item = new FileData();
                item.Hash = SimpleJson.TryStringValue(obj, "hash");
                item.FileSize = SimpleJson.TryLongValue(obj, "filesize");
                item.FileName = SimpleJson.TryStringValue(obj, "filename");
                item.OrgShare = SimpleJson.TryIntValue(obj, "org_share");
                item.FullPath = SimpleJson.TryStringValue(obj, "fullpath");
                item.UpFullPath = SimpleJson.TryStringValue(obj, "up_fullpath");

                list.Add(item);

            }
            data.Files = list;

            return data;
        }

        /// <summary>
        /// 用户id
        /// </summary>
        public int MemberId { get; private set; }

        /// <summary>
        /// 文件操作
        /// </summary>
        public int Act { get; private set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        public long Dateline { get; private set; }

        /// <summary>
        /// 执行操作 成员名字
        /// </summary>
        public string MemberName { get; private set; }

        /// <summary>
        /// 相关的文件
        /// </summary>
        public List<FileData> Files { get; private set; }

    }
}
