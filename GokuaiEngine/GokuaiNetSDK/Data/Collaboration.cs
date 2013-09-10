using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoKuai_EntSDK.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class Collaboration
    {

        public enum ShareTargetType 
        { 
            /// <summary>
            /// 成员
            /// </summary>
            MEMBER,
            /// <summary>
            /// 分组
            /// </summary>
            GROUP 
        }

        /// <summary>
        /// 权限
        /// </summary>
        public enum Right
        {
            /// <summary>
            /// 拥有着
            /// </summary>
            OWNER,
            /// <summary>
            /// 编辑者
            /// </summary>
            EDITOR,
            /// <summary>
            /// 查看着
            /// </summary>
            VIEWER,
            /// <summary>
            /// 规定者
            /// </summary>
            ARCHIVER 
        }

        private List<string> _list;

        public Collaboration() 
        {
            _list=new List<string>();
        }

        /// <summary>
        /// 添加参数字符串 格式为：type + "|" + id + "|" + right
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="right"></param>
        public void Add(ShareTargetType type,int id,Right right) 
        {
            _list.Add(type.ToString().ToLower() + "|" + id + "|" + right.ToString().ToLower());
        }

        /// <summary>
        /// 添加参数字符串 格式为：type + "|" + id 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        public void Add(ShareTargetType type, int id) 
        {
            _list.Add(type.ToString().ToLower() + "|" + id);
        }

        public string[] ArrParam 
        {
            get
            {
                return _list.ToArray();
            }
        }
    }
}
