using GoKuai_EntSDK.UtilClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoKuai_EntSDK.Data
{
    public class Condition
    {

        public Condition() 
        {
            Limit = new int[] { 0, 1000 };
            OrderMethod = OrderMethod.DESC;
            OrderType = OrderType.LAST_DATELINE;
        }

        private enum ConditionType
        { 
            EQ ,
            GT ,
            IT,
            IN , 
            BETWEEN,
            TEXT,
            LIKE , 
            PREFIX 
        }

        /// <summary>
        /// 排序方法
        /// </summary>
        public OrderMethod OrderMethod
        {
            get;
            set;
        }

        /// <summary>
        /// 排序类型
        /// </summary>
        public OrderType OrderType
        {
            get;
            set;
        }

        /// <summary>
        /// 分页，长度为2的数组，例 [0，100]
        /// </summary>
        public int[] Limit
        {
            set;
            get;
        }

        /// <summary>
        /// 搜索条件
        /// </summary>
        public Include Include
        {
            set;
            get;
        }

        /// <summary>
        /// 过滤条件
        /// </summary>
        public Exclude Exclude
        {
            set;
            get;
        }

        /// <summary>
        /// 将condition对象转化为json对象
        /// </summary>
        /// <returns></returns>
        public string ToJsonString ()
        {
            string jsonString = "";
            if (Include != null) 
            {
                jsonString += "{\"include\":{";
                if (Include.Path != null) 
                {
                    jsonString += "\"path\":[" + Include.Path + "],";
                }

                if (Include.Keywords != null) 
                {
                    jsonString += "\"keywords\":[" + Include.Keywords + "],";
                }

                if (Include.Creator != null) 
                {
                    jsonString += "\"creator\":[" + Include.Creator + "],";
                }

                if (Include.Dateline != null) 
                {
                    jsonString += "\"dateline\":[" + Include.Dateline + "],";
                }

                if (Include.Filesize != null) 
                {
                    jsonString += "\"filesize\":[" + Include.Filesize + "]";
                }
                jsonString += "},";

            }
            if (Exclude != null) 
            {
                jsonString += "\"exclude\":{";
                if (Exclude.Creator != null)
                {
                    jsonString += "\"creator\":[" + Exclude.Creator + "],";
                }
                if (Exclude.Keywords != null)
                {
                    jsonString += "\"modifier\":[" + Exclude.Keywords + "],";
                }
                if (Exclude.Modifier != null)
                {
                    jsonString += "\"modifier\":[" + Exclude.Modifier + "],";
                }
                if (Exclude.Extension != null)
                {
                    jsonString += "\"extension\":[" + Exclude.Extension + "]";
                }
                jsonString += "},";
            }
            jsonString += "\"order\":{\"" + OrderType.ToString().ToLower() + "\":\"" + OrderMethod.ToString().ToLower() + "\"},";
            jsonString += "\"limit\":" + SimpleJson.SerializeObject(Limit);
            jsonString += "}";

            return jsonString;
       
        }

        /// <summary>
        /// 两者之间['between', [paramArr[0],paramArr[1]]]
        /// </summary>
        /// <param name="paramArr"></param>
        /// <returns></returns>
        public static string BetweenParam(long [] paramArr) 
        {
            return Convert(ConditionType.BETWEEN,paramArr);
        }

        /// <summary>
        /// 大于['eq', param]
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string EqParam(long param)
        {
            return Convert(ConditionType.EQ,param.ToString());
        }
        /// <summary>
        /// 模糊查询['like', param]
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string LikeParam(string param) 
        {
            return Convert(ConditionType.LIKE, param.ToString());
        }


        /// <summary>
        /// 大于['gt', param]
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string GtParam(long param)
        {
            return Convert(ConditionType.GT, param.ToString());
        }

        /// <summary>
        ///IN 查询 ['in', [paramArr[0]，paramArr[1]]] long arr
        /// </summary>
        /// <param name="paramArr"></param>
        /// <returns></returns>
        public static string InParam(long[] paramArr)
        {
            return Convert(ConditionType.IN,paramArr);
        }

        /// <summary>
        ///IN 查询 ['in', [paramArr[0]，paramArr[1]]] string arr
        /// </summary>
        /// <param name="paramArr"></param>
        /// <returns></returns>
        public static string InParam(string[] paramArr) 
        {
            return Convert(ConditionType.IN, paramArr);
        }

        /// <summary>
        /// 小于['it', param]
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string ItParam(long param) 
        {
            return Convert(ConditionType.IT, param.ToString());
        }


        /// <summary>
        /// 全文查询['text', param]
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string TextParam(string param) 
        {
            return Convert(ConditionType.TEXT, param.ToString());
        }


        /// <summary>
        ///从头匹配 ['prefix', param]
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string PrefixParam(string param) 
        {
            return Convert(ConditionType.PREFIX, param.ToString());
        }

        private static string Convert(ConditionType type, string param)
        {
            string convertedParam = "";
            switch (type)
            {
                case ConditionType.TEXT:
                case ConditionType.PREFIX:
                case ConditionType.LIKE:
                    
                    convertedParam = "\"" + type.ToString().ToLower() + "\",\"" + param.ToString() + "\"";
                    break;
                default:
                    convertedParam = "\"" + type.ToString().ToLower() + "\"," + param.ToString();
                    break;
            }
            return convertedParam;
        }

        private static string Convert(ConditionType type, long []arr) 
        {
            string convertedParam = "\"" + type.ToString().ToLower() + "\","+SimpleJson.SerializeObject(arr);
            return convertedParam;
        }

        private static string Convert(ConditionType type, string[] arr) 
        {
            string convertedParam = "\"" + type.ToString().ToLower() + "\"," + SimpleJson.SerializeObject(arr);
            return convertedParam;
        }
    }

    public class Include
    {
        public string Path { set; get; }
        public string Keywords { set; get; }
        public string Creator { set; get; }
        public string Dateline { set; get; }
        public string Filesize { set; get; }
    }

    public class Exclude
    {
        public string Creator { set; get; }
        public string Modifier { set; get; }
        public string Keywords { set; get; }
        public string Extension { set; get; }
    }

    

}
