using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoKuai_EntSDK.Net;
using GoKuai_EntSDK.UtilClass;
using System.Net;
using System.IO;
using System.Web;
using System.Collections.Specialized;
using GoKuai_EntSDK.Data;


namespace GoKuai_EntSDK
{
    public class GokuaiEngine
    {
        private const string DEFAULT_PATH = "GokuaiExtApi\\Team\\";
        protected const string HOST = "http://api.gokuai.com";
        private const string URL_API_TOKEN = HOST + "/oauth2/token";
        private const string URL_API_GET_FILE_INFO = HOST + "/1/file/info";
        private const string URL_API_GET_FILE_LIST = HOST + "/1/file/ls";
        private const string URL_API_GET_UPLOAD_SERVER = HOST + "/1/file/upload_server";
        private const string URL_API_UPLOAD =  "{0}/1/file/upload";

        private const string URL_API_FILE_ADD = HOST + "/1/file/add";
        private const string URL_API_FILE_DEL = HOST + "/1/file/del";
        private const string URL_API_FILE_MOVE = HOST + "/1/file/move";
        private const string URL_API_FILE_COPY = HOST + "/1/file/copy";
        private const string URL_API_GET_FILE_COLLABORATION = HOST + "/1/file/collaboration";
        private const string URL_API_ADD_COLLABORATION = HOST + "/1/file/add_collaboration";
        private const string URL_API_EDIT_COLLABORATION = HOST + "/1/file/edit_collaboration";
        private const string URL_API_DEL_COLLABORATION = HOST + "/1/file/remove_collaboration";
        private const string URL_API_SEARCH = HOST + "/1/file/search";
        
        private const string URL_API_GET_MEMBER_AND_GROUP = HOST + "/1/team/member_and_group";
        private const string URL_API_GET_GOURP_MEMBERS = HOST + "/1/team/group_member";
        private const string URL_API_GET_UPDATE_FILE_LIST = HOST + "/1/updates/timeline";

        //public const int API_ID_TOKEN = 1;
        //public const int API_ID_REFRESH_TOKEN = 2;
        //public const int API_ID_GET_FILE_INFO = 3;
        //public const int API_ID_GET_FILE_LIST = 4;
        //public const int API_ID_FILE_ADD = 5;
        //public const int API_ID_FILE_DEL = 6;
        //public const int API_ID_FILE_MOVE = 7;
        //public const int API_ID_FILE_COPY = 8;
        //public const int API_ID_GET_FILE_COLLABORATION = 9;
        //public const int API_ID_ADD_COLLABORATION = 10;
        //public const int API_ID_EDIT_COLLABORATION = 11;
        //public const int API_ID_DEL_COLLABORATION = 12;
        //public const int API_ID_SEARCH = 13;
        //public const int API_ID_SAVE_SEARCH = 14;
        //public const int API_ID_GET_UPDATE_FILE_LIST = 15;
        //public const int API_ID_GET_MEMBER_AND_GROUP = 16;
        //public const int API_ID_GET_GOURP_MEMBERS = 17;

        /// <summary>
        /// 共享操作enum
        /// </summary>
        private enum Operation { Add, Edit, Del }

        protected string _clientId;
        protected string _clientSecret;
        protected string _username;
        protected string _password;

        private static bool _debugLogPrint;
        public static bool DebugLogPrint
        {
            get { return _debugLogPrint;}
            set { _debugLogPrint = value; }
        }

        protected string _token;
        /// <summary>
        /// 获取到的身份验证token
        /// </summary>
        public string Token
        {
            get { return _token; }
        }

        /// <summary>
        /// 获得一个全新的对象,可以跳过token步骤
        /// 注:多线程访问建议使用clone出的新对象,并发执行
        /// 
        /// </summary>
        /// <returns></returns>
        public GokuaiEngine Clone() 
        {
            GokuaiEngine ge=new GokuaiEngine();
            ge._clientId = this._clientId;
            ge._clientSecret = this._clientSecret;
            ge._refreshToken = this._password;
            ge._teamFolderPath = this._teamFolderPath;
            ge._token = this._token;
            ge._refreshToken = this._refreshToken;
            return ge;
        }

        protected string _refreshToken;

        private string _teamFolderPath;
        /// <summary>
        /// 默认为D:\GokuaiExtApi\Team\
        /// </summary>
        public string TeamFolderPath
        {
            get
            {
                if (string.IsNullOrEmpty(_teamFolderPath))
                {
                    if (!Directory.Exists(@"D:\"))
                    {
                        _teamFolderPath = "C:\\" + DEFAULT_PATH;
                    }
                    else 
                    {
                        _teamFolderPath = "D:\\" + DEFAULT_PATH;
                    }

                }
                return _teamFolderPath;
            }
            set 
            {
                _teamFolderPath = value;
            }
        }

        /// <summary>
        /// 缺陷：如果是多线程操作，可能会让此参数失效
        /// </summary>
        /// 
        //改进想法：在返回的结果里，直接附上自己租一个json对象，result里放结果，code放结果
        public HttpStatusCode StatusCode
        {
            get;
            protected set;
        }

        public GokuaiEngine()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="account">帐号</param>
        /// <param name="password">密码</param>
        /// <param name="key">序列号</param>
        /// <param name="secrectkey">密钥</param>
        public GokuaiEngine(string username, string password, string clientId, string clientSecret) 
        {
            _username = username;
            _password = MD5Core.GetHashString(password);
            _clientId = clientId;
            _clientSecret = clientSecret;

        }

        /// <summary>
        /// 获取token
        /// </summary>
        /// <returns></returns>
        public string GetToken() 
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_TOKEN;
            request.AppendParameter("username", _username);
            request.AppendParameter("password", _password);
            request.AppendParameter("client_id", _clientId);
            request.AppendParameter("client_secret", _clientSecret);
            request.AppendParameter("grant_type", "password");
            request.RequestMethod = RequestType.POST;
            request.Request();
            this.StatusCode = request.Code;
            string result = request.Result;

            OauthData data = OauthData.Create(result);
            if (request.Code == HttpStatusCode.OK)
            {
                _refreshToken = data.RefreshToken;
                _token = data.Token;
            }
            return result;
            
        }

        /// <summary>
        /// 重新获取token
        /// </summary>
        /// <returns></returns>
        public string RefreshToken()
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_TOKEN;
            request.AppendParameter("client_id", _clientId);
            request.AppendParameter("client_secret", _clientSecret);
            request.AppendParameter("grant_type", "refresh_token");
            request.AppendParameter("refresh_token", _refreshToken);
            request.RequestMethod = RequestType.POST;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }


        /// <summary>
        /// 添加文件夹或文件
        /// </summary>
        /// <param name="fullPath">文件夹末尾加斜杆</param>
        /// <param name="mount"></param>
        /// <param name="localPath">需要上传传文件的绝对路径，如果此参数传空默认文件夹</param>
        /// 
        
        public string Add(string fullPath, MountType mount, string localPath) 
        {
            bool isFile = !string.IsNullOrEmpty(localPath);
            if (isFile)
            {
                using (FileStream FS = new FileStream(localPath, FileMode.Open))
                {
                    Stream stream = FS;
                    
                    return Add(fullPath, mount , stream, Util.GetFileNameFromPath(localPath));
                }
                
            }
            else 
            {
                HttpRequestSyn request = new HttpRequestSyn();
                request.RequestUrl = URL_API_FILE_ADD;
                request.AppendParameter("token", _token);
                request.AppendParameter("fullpath", fullPath);
                request.AppendParameter("filefield", isFile ? "file" : "");
                request.AppendParameter("mount", mount.ToString().ToLower());
                request.AppendParameter("sign", GenerateSign(request.SortedParamter));
                request.RequestMethod = RequestType.POST;
                request.Request();
                this.StatusCode = request.Code;
                return request.Result;
            }
            
        }

        /// <summary>
        /// 通过流上传文件
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        /// <param name="stream"></param>
        /// <param name="fileName"></param>
        
        public string Add(string fullPath , MountType mount, Stream stream, string fileName) 
        {
            string serverpath = GetUploadAddress(fullPath, mount);
            if (string.IsNullOrEmpty(serverpath)) return "上传地址获取错误";

            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = string.Format(URL_API_UPLOAD, serverpath);
            string[] arr = new string[] { fullPath, mount.ToString().ToLower(), _token };
            MsMultiPartFormData data = new MsMultiPartFormData();
            request.ContentType = "multipart/form-data;boundary=" + data.Boundary;
            data.AddStreamFile("file", fileName, Util.ReadToEnd(stream));
            data.AddParams("token",_token);
            data.AddParams("fullpath", fullPath);
            data.AddParams("filefield", "file");
            data.AddParams("mount", mount.ToString().ToLower());
            data.AddParams("sign", GenerateSign(arr));
            data.PrepareFormData();
            request.PostDataByte = data.GetFormData();
            request.RequestMethod = RequestType.POST;
            LogPrint.Print("------------->Begin to Upload<------------------");
            request.Request();
            LogPrint.Print("--------------------->Upload Request Compeleted<--------------");
            this.StatusCode = request.Code;
            return request.Result;

        }

        private string GetUploadAddress(string fullPath, MountType mount) 
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_GET_UPLOAD_SERVER;
            request.AppendParameter("token", _token);
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.POST;
            request.Request();
            try
            {
                var json = (IDictionary<string, object>)SimpleJson.DeserializeObject(request.Result);
                string server = SimpleJson.TryStringValue(json, "server");
                return server;

            }
            catch 
            {
                return "";
            }

        }

        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        
        public string Del(string fullPath, MountType mount) 
        {
            
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_FILE_DEL;
            request.AppendParameter("token", _token);
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.POST;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        
        public string List(string fullPath,int start, MountType mount)
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_GET_FILE_LIST;
            request.AppendParameter("token", _token);
            request.AppendParameter("start", start.ToString());
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="fromFullPath"></param>
        /// <param name="mount"></param>
        /// <param name="toMount"></param>
        
        public string Move(string fullPath, string fromFullPath, MountType mount, MountType toMount) 
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_FILE_MOVE;
            request.AppendParameter("token", _token);
            request.AppendParameter("from_fullpath", fromFullPath);
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("to_mount", toMount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.POST;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;

        }

        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="fromFullPath"></param>
        /// <param name="mount"></param>
        /// <param name="toMount"></param>
        
        public string Copy(string fullPath, string fromFullPath, MountType mount, MountType toMount) 
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_FILE_COPY;
            request.AppendParameter("token", _token);
            request.AppendParameter("from_fullpath", fromFullPath);
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("to_mount", toMount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.POST;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;

        }

        /// <summary>
        /// 获取单个文件信息
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        
        public string Get(string fullPath, MountType mount)
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_GET_FILE_INFO;
            request.AppendParameter("token", _token);
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="downloadUrl"></param>
        /// <param name="fileName"></param>
        /// <returns>true为下载成功</returns>
       
        public bool Get(string downloadUrl,string fileName) 
        {
            WebClient webClient = new WebClient();
            
            if (!Directory.Exists(TeamFolderPath))
            {
                Directory.CreateDirectory(TeamFolderPath);
            }
            try
            {
                LogPrint.Print("-------------------->Begin to Download");
                webClient.DownloadFile(downloadUrl, TeamFolderPath + fileName);
                LogPrint.Print("-------------------->Download Compeleted");
            }
            catch (WebException e)
            {
                LogPrint.Print("WebException:"+e.StackTrace);
                return false;

            }
            catch (NotSupportedException e)
            {
                LogPrint.Print("WebException:" + e.StackTrace);
                return false;

            }
            catch (ArgumentNullException e) 
            {
                LogPrint.Print("WebException:" + e.StackTrace);
                return false;
            }
            return true;          
        }

        /// <summary>
        /// 存放在够快api ext 根目录
        /// </summary>
        /// <param name="stream"></param>
        public bool Get(Stream stream,string fileName) 
        {
            
            //获得字节数组
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                byte[] data = Util.ReadToEnd(stream);
                //开始写入
                fs.Write(data, 0, data.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
            }
            catch 
            {
                return false;
            }
            

            return true;
        }

        /// <summary>
        /// 获取团队成员和分组
        /// </summary>
        public string GetMember( )
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_GET_MEMBER_AND_GROUP;
            request.AppendParameter("token", _token);
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 获取分组中的成员列表
        /// </summary>
        /// <param name="groupId">要获取的分组的ID</param>
        
        public string GetGroupMember(int groupId) 
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_GET_GOURP_MEMBERS;
            request.AppendParameter("token", _token);
            request.AppendParameter("group_id", groupId.ToString());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 获取共享参与人
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        
        public string GetShare(string fullPath, MountType mount)
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_GET_FILE_COLLABORATION;
            request.AppendParameter("token", _token);
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 添加共享参与人
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        /// <param name="collaboration"></param>
        /// <returns></returns>
        public string AddShare(string fullPath, MountType mount, string[] collaboration)
        {
            return ShareOperation(Operation.Add, fullPath, mount, collaboration);
        }

        /// <summary>
        /// 编辑共享人权限
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        /// <param name="collaboration"></param>
        
        public string EditShare(string fullPath, MountType mount, string[] collaboration)
        {
            return ShareOperation(Operation.Edit, fullPath, mount, collaboration);
        }

        /// <summary>
        /// 删除共享参与人
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="mount"></param>
        /// <param name="collaboration"></param>
        
        public string DelShare(string fullPath, MountType mount, string[] collaboration)
        {
            return ShareOperation(Operation.Del, fullPath, mount, collaboration);
        }

        private string ShareOperation(Operation operation,string fullPath, MountType mount, string[] collaboration)
        {
            HttpRequestSyn request = new HttpRequestSyn();
            switch (operation) 
            {
                case Operation.Del:
                    request.RequestUrl = URL_API_DEL_COLLABORATION;
                    break;
                case Operation.Add:
                    request.RequestUrl = URL_API_ADD_COLLABORATION;
                    break;
                case Operation.Edit:
                    request.RequestUrl = URL_API_EDIT_COLLABORATION;
                    break;
            }
            request.AppendParameter("token", _token);
            request.AppendParameter("fullpath", fullPath);
            string cols = "";
            for (int i = 0; i < collaboration.Length; i++)
            {
                cols += collaboration[i] + ((i == collaboration.Length) ? "," : "");
            }
            request.AppendParameter("collaboration", cols);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.POST;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="mountType"></param>
        /// <param name="code"></param>
        public string Search(string condition, MountType mount)
        {
            return Search(condition, mount,"");
        }

        

        protected string Search(string condition, MountType mount, string code)
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_SEARCH;
            request.AppendParameter("token", _token);
            request.AppendParameter("condition", condition);
            request.AppendParameter("code", code);
            request.AppendParameter("mount", mount==MountType.EMPTY?"":mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 获取更新列表
        /// </summary>
        /// <param name="fullPath"></param>
        /// <param name="memberId"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        
        public string UpdateList(string fullPath, int memberId,UpdateType type,long startTime,long endTime) 
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_GET_UPDATE_FILE_LIST;
            request.AppendParameter("token", _token);
            request.AppendParameter("fullpath", fullPath);
            request.AppendParameter("act_member_id", memberId.ToString());
            request.AppendParameter("type", ((int)type).ToString());
            request.AppendParameter("start_time", startTime.ToString());
            request.AppendParameter("end_time", endTime.ToString());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;

        }


        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        protected string GenerateSign(string[] array)
        {
            string string_sign = "";
            for (int i = 0; i < array.Length; i++)
            {
                string_sign += array[i] + (i == array.Length - 1 ? string.Empty : "\n");
            }

            return Uri.EscapeDataString(Util.EncodeToHMACSHA1(string_sign, _clientSecret));
        }



        
        
    }

    /// <summary>
    /// 存储空间类型
    /// </summary>
    public enum MountType
    {
        /// <summary>
        /// 不传参数
        /// </summary>
        EMPTY,
        /// <summary>
        /// 个人空间(普通用户的界面，里面含有团队文件和个人文件)
        /// </summary>
        GOKUAI,
        /// <summary>
        /// 团队空间(管理员控制界面，在管理界面显示的文件)
        /// </summary>
        TEAM
    }

    /// <summary>
    /// 更新操作
    /// </summary>
    public enum UpdateType
    {
        ALL,
        /// <summary>
        /// 文件操作
        /// </summary>
        FILE, 
        /// <summary>
        /// 讨论和注释
        /// </summary>
        COMMENT,
        /// <summary>
        /// 事件
        /// </summary>
        EVENT,
    }

    /// <summary>
    /// 排序方法
    /// </summary>
    public enum OrderMethod 
    {
        /// <summary>
        /// 升序
        /// </summary>
        ASC,
        /// <summary>
        /// 降序
        /// </summary>
        DESC
    }

    /// <summary>
    /// 排序类型
    /// </summary>
    public enum OrderType 
    {
        /// <summary>
        /// 更新时间
        /// </summary>
        LAST_DATELINE,
        /// <summary>
        /// 文件大小
        /// </summary>
        FILESIZE,
        /// <summary>
        /// 文件名
        /// </summary>
        FILENAME
    }

}
