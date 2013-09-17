
using GoKuai_EntSDK;
using GoKuai_EntSDK.Data;
using GoKuai_EntSDK.UtilClass;
using GokuaiEntDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GokuaiEntDemo
{
    public partial class MainForm : Form
    {
        private const string _username = "412635195@qq.com";
        private const string _password = "bozaihoho";
        private const string _clientId = "818f83a6e217eb7152b28ba14fd31377";
        private const string _clientSecret = "18d0df158975b9fa33366bcf69586fdb";

        //private const string _clientId = "c32b16dac6e7e49ba312f8b08cce74ad";
        //private const string _clientSecret = "664564a3579bbe56f52e69959d5b5bba";

        private GokuaiEngine _gokuaiEngine;
        private SearchResult _searchResult;

        public MountType RadioGroup_1_Value
        {
            get { return RB_Gokuai_1.Checked ? MountType.GOKUAI : MountType.TEAM; }
        }

        public MountType RadioGroup_2_Value
        {
            get { return RB_Gokuai_2.Checked ? MountType.GOKUAI : MountType.TEAM; }
        }

        public MountType RadioGroup_3_Value
        {
            get { return RB_Gokuai_3.Checked ? MountType.GOKUAI : MountType.TEAM; }
        }

        public MountType RadioGroup_4_Value
        {
            get { return RB_Gokuai_4.Checked ? MountType.GOKUAI : MountType.TEAM; }
        }

        public MountType RadioGroup_5_Value
        {
            get { return RB_Gokuai_5.Checked ? MountType.GOKUAI : MountType.TEAM; }
        }



        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //开启sdk debug日志
            GokuaiEngine.DebugLogPrint = true;
            //新实例化对象
            GokuaiEngine ge = new GokuaiEngine(_username,_password,_clientId,_clientSecret);
            string result=ge.GetToken();
            if (ge.StatusCode==HttpStatusCode.OK)
            {
                //获得token，也可以在result中自己解析
                TB_Token.Text = ge.Token;
            }
            else
            {
                OauthData data = OauthData.Create(result);
                if (data != null)
                {
                    MessageBox.Show(data.Error);
                }
                else 
                {
                    MessageBox.Show("无法解析内容");
                }
                
            }
            _gokuaiEngine = ge;
        }


        private void Btn_RefreshToken_Click(object sender, EventArgs e)
        {
            //刷token
           MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.RefreshToken(),_gokuaiEngine.StatusCode));
        }


        private void Btn_GetFileInfo_Click(object sender, EventArgs e)
        {
            //获取单文件信息
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Get(TB_FilePath.Text, RadioGroup_1_Value), _gokuaiEngine.StatusCode));
        }




        private void Btn_GetFileList_Click(object sender, EventArgs e)
        {
            //获取文件列表
            string result = _gokuaiEngine.List(TB_FilePath.Text, 0, RadioGroup_1_Value);

            FileListData data= FileListData.Create(result);
            if (data != null)
            {
                string message = "";
                if (_gokuaiEngine.StatusCode==HttpStatusCode.OK)
                {
                    foreach (FileData filedata in data.DataList)
                    {
                        message +=  filedata.FullPath +":"+Util.TimeFormat(filedata.LastDateline,Util.TIMEFORMAT_WITHOUT_SECONDS)+ "\n";
                    }
                }
                else
                {
                    message = data.ErrorCode + ":" + data.ErrorMessage;
                }
                MessageBox.Show(message);
            }
            else 
            {
                MessageBox.Show("无法解析内容");
            }


            
        }


        private void Btn_CreateFolder_Click(object sender, EventArgs e)
        {
            //创建文件夹
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Add(TB_FilePath.Text, RadioGroup_1_Value, ""), _gokuaiEngine.StatusCode));
        }

        private void Btn_FolderView_Click(object sender, EventArgs e)
        {
            FolderViewDialog.FileOk+=FolderViewDialog_FileOk;
            FolderViewDialog.ShowDialog();
        }


        private string _fileName;
        private void FolderViewDialog_FileOk(object sender, CancelEventArgs e)
        {
            FolderViewDialog.Multiselect = false;
            TB_LocalPath.Text = FolderViewDialog.FileName;
            TB_ServerPath.Text = "GokuaiDemoTest/" + FolderViewDialog.SafeFileName;
            _fileName=FolderViewDialog.SafeFileName;
        }

        private void Btn_UploadByPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Add(TB_ServerPath.Text, RadioGroup_1_Value, TB_LocalPath.Text), _gokuaiEngine.StatusCode));
        }

        private void Btn_UpLoadByStream_Click(object sender, EventArgs e)
        {

            //打开文件流
            try
            {
                using (FileStream FS = new FileStream(TB_LocalPath.Text, FileMode.Open))
                {
                    Stream stream = FS;
                    MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Add(TB_ServerPath.Text, RadioGroup_2_Value, stream, _fileName), _gokuaiEngine.StatusCode));
                }
            }
            catch 
            {

            }
            
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Del(TB_FilePath.Text, RadioGroup_1_Value), _gokuaiEngine.StatusCode));
        }

        private void Btn_Move_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Move(TB_TargetPath.Text, TB_OriginPath.Text, RadioGroup_3_Value, RadioGroup_4_Value), _gokuaiEngine.StatusCode));
        }

        private void Btn_Copy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Copy(TB_TargetPath.Text, TB_OriginPath.Text, RadioGroup_3_Value, RadioGroup_4_Value), _gokuaiEngine.StatusCode));
        }

        private void Btn_GetCollaboration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.GetShare(TB_FilePath.Text, RadioGroup_1_Value), _gokuaiEngine.StatusCode));
        }

        private void btn_ShareOperation_Click(object sender, EventArgs e)
        {
            CollaborationOperate form = new CollaborationOperate(this);
            form.ShowDialog();
        }

        public void AddShare(Collaboration col) 
        {

            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.AddShare(TB_FilePath.Text, RadioGroup_1_Value, col.ArrParam), _gokuaiEngine.StatusCode));
        }

        public void EditShare(Collaboration col) 
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.EditShare(TB_FilePath.Text, RadioGroup_1_Value, col.ArrParam), _gokuaiEngine.StatusCode));
        }

        public void DelShare(Collaboration col) 
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.DelShare(TB_FilePath.Text, RadioGroup_1_Value, col.ArrParam), _gokuaiEngine.StatusCode));
        }

        private void Btn_Download_Click(object sender, EventArgs e)
        {
            //先获取文件地址，再进行下载
            string jsonString = _gokuaiEngine.Get(TB_FilePath.Text, RadioGroup_1_Value);
            FileData data = FileData.Create(jsonString);
            if (_gokuaiEngine.StatusCode==HttpStatusCode.OK)
            {
               bool isNormalDownload= _gokuaiEngine.Get(data.Uri, data.FileName);
               if (isNormalDownload)
               {
                   MessageBox.Show("下载完毕");
               }
               else 
               {
                   MessageBox.Show("下载过程中发生异常");
               }
            }
            else 
            {
                MessageBox.Show(data.ErrorCode+":"+data.ErrorMessage);
            }
        }


        private void Btn_GetGroupAndMember_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.GetMember(), _gokuaiEngine.StatusCode));
        }

        private void Btn_GetGroupMemeber_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.GetGroupMember(TB_GroupId.Text.Equals(string.Empty) ? 0 : int.Parse(TB_GroupId.Text)), _gokuaiEngine.StatusCode));
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Condition condition = new Condition();
            condition.Include = new Include()
            {
                //Path = Condition.PrefixParam(""),
                //Creator = Condition.InParam(new long[] { 0, 10000 }),
                //Dateline = Condition.ItParam(Util.GetUnixDataline()),
                //Filesize = Condition.BetweenParam(new long[] { 0, 1024 }),
                Keywords = Condition.TextParam(TB_SearchContent.Text)
            };

            //condition.Exclude = new Exclude()
            //{
            //    Creator = Condition.InParam(new long[] { 0, 10000 }),
            //    Keywords = Condition.TextParam(TB_SearchContent.Text),
            //    Modifier = Condition.ItParam(10000),
            //    Extension = Condition.InParam(new string[] { "xsl", "ppt" })
            //};

            condition.Limit = new int[] { 0, 500 };
            condition.OrderMethod = OrderMethod.DESC;
            condition.OrderType = OrderType.LAST_DATELINE;

            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.Search(condition.ToJsonString(), RadioGroup_5_Value), _gokuaiEngine.StatusCode));
        }

        

        private void Btn_GetUpdateList_Click(object sender, EventArgs e)
        {

            
            string result = _gokuaiEngine.UpdateList(TB_UpdateFilePath.Text, 0, UpdateType.ALL, Util.GetUnixDataline() - 12 * 60 * 60 - 1, Util.GetUnixDataline() );


            UpdateFileList data = UpdateFileList.Create(result);
            if (_gokuaiEngine.StatusCode == HttpStatusCode.OK)
            {
                string str = "";
                //逐个获取单条更新信息
                 foreach(UpdateItem item in data.Datalist){
                     str += item.MemberName+":"+ActDesc.ConvertAct(item.Act)+":"+Util.TimeFormat(item.Dateline,Util.TIMEFORMAT_HS)+"\n";


                     string files="";
                     //获取一条更新信息里的县官文件
                     foreach(FileData filedata in item.Files){
                         files += " ==>"+filedata.FileName+"\n";
                     }
                     str += files;


                 }


                 Debug.Print(str); ;

            }
            else 
            {
                Debug.Print(data.ErrorCode + ":" + data.ErrorMessage);
            }

        }

        private void Btn_SaveSearch_Click(object sender, EventArgs e)
        {
            SearchResult sr = new SearchResult(_username,_password,_clientId,_clientSecret);
            string result = sr.GetToken();
            _searchResult = sr;

            Condition condition = new Condition();
            condition.Include = new Include()
            {
                //Path = Condition.PrefixParam(""),
                //Creator = Condition.InParam(new long[] { 0, 10000 }),
                //Dateline = Condition.ItParam(Util.GetUnixDataline()),
                //Filesize = Condition.BetweenParam(new long[] { 0, 1024 }),
                Keywords = Condition.TextParam(TB_SearchContent.Text)
            };

            //condition.Exclude = new Exclude()
            //{
            //    Creator = Condition.InParam(new long[] { 0, 10000 }),
            //    Keywords = Condition.TextParam(TB_SearchContent.Text),
            //    Modifier = Condition.ItParam(10000),
            //    Extension = Condition.InParam(new string[] { "xsl", "ppt" })
            //};

            condition.Limit = new int[] { 0, 500 };
            condition.OrderMethod = OrderMethod.DESC;
            condition.OrderType = OrderType.LAST_DATELINE;

            string searchResult = sr.Save(condition.ToJsonString(), "Search", "For test", MountType.GOKUAI);
            SearchResultData data = SearchResultData.Create(searchResult);
            TB_Code.Text = data.Code;
            MessageBox.Show(DeserializeErrorMsg(searchResult,_searchResult.StatusCode));
               

        }

        private void Btn_ReSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_searchResult.Restore(TB_Code.Text), _searchResult.StatusCode));
        }

        private void Btn_RemoveSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_searchResult.Earse(TB_Code.Text), _searchResult.StatusCode));
        }

        /// <summary>
        /// 分析错误信息
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        private string DeserializeErrorMsg(string result,HttpStatusCode code)
        {
            //复制到剪贴板
            Clipboard.SetDataObject(result);
            if (code == HttpStatusCode.OK)
            {
                //成功则返回结果
                Debug.WriteLine("Demo=>" + "result:" + result);
                if (result.Equals(string.Empty)) 
                {
                    return "返回成功";
                }
                return result;
            }
            else
            {
                //返回错误信息
                BaseData data = BaseData.Create(result);
                if (data != null)
                {
                    return data.ErrorCode + ":" + data.ErrorMessage;
                }
                return result;
            }
            
        }

        private void Btn_GetAccountInfo_Click(object sender, EventArgs e)
        {
             MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.GetMemberiInfo(""),_gokuaiEngine.StatusCode));
        }

        private void Btn_GetMemberInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeserializeErrorMsg(_gokuaiEngine.GetAccountInfo(59),_gokuaiEngine.StatusCode));
        }

        

    }
}
