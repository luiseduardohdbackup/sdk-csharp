using GoKuai_EntSDK.Data;
using GoKuai_EntSDK.Net;
using GoKuai_EntSDK.UtilClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace GoKuai_EntSDK
{
    public class SearchResult : GokuaiEngine
    {
        private const string URL_API_SAVE_SEARCH = HOST + "/1/file/save_search";
        private const string URL_API_REMOVE_SEARCH = HOST + "/1/file/remove_search";

        //public HttpStatusCode StatusCode
        //{
        //    get;
        //    private set;
        //}


        public SearchResult(string username, string password, string clientId, string clientSecret) 
        {
            _username = username;
            _password = MD5Core.GetHashString(password);
            _clientId = clientId;
            _clientSecret = clientSecret;

        }

        /// <summary>
        /// 保存搜索结果
        /// </summary>
        /// <returns>code</returns>
        public string Save(string condition,string name,string desciption,MountType mount) 
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_SAVE_SEARCH;
            request.AppendParameter("token", _token);
            request.AppendParameter("condition", condition);
            request.AppendParameter("name", name);
            request.AppendParameter("desciption", desciption);
            request.AppendParameter("mount", mount.ToString().ToLower());
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

        /// <summary>
        /// 根据code返回搜索结果
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string Restore(string code)
        {
            return Search("",MountType.EMPTY,code);
        }

        /// <summary>
        /// 删除搜索结果
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string Earse(string code)
        {
            HttpRequestSyn request = new HttpRequestSyn();
            request.RequestUrl = URL_API_REMOVE_SEARCH;
            request.AppendParameter("token", _token);
            request.AppendParameter("code", code);
            request.AppendParameter("sign", GenerateSign(request.SortedParamter));
            request.RequestMethod = RequestType.GET;
            request.Request();
            this.StatusCode = request.Code;
            return request.Result;
        }

    }
}
