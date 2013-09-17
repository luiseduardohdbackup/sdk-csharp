namespace GokuaiEntDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_RefreshToken = new System.Windows.Forms.Button();
            this.Btn_GetFileInfo = new System.Windows.Forms.Button();
            this.TB_FilePath = new System.Windows.Forms.TextBox();
            this.RB_Gokuai_1 = new System.Windows.Forms.RadioButton();
            this.RB_Team_1 = new System.Windows.Forms.RadioButton();
            this.Gb = new System.Windows.Forms.GroupBox();
            this.Btn_GetFileList = new System.Windows.Forms.Button();
            this.Btn_CreateFolder = new System.Windows.Forms.Button();
            this.TB_Token = new System.Windows.Forms.TextBox();
            this.Btn_UploadByPath = new System.Windows.Forms.Button();
            this.TB_LocalPath = new System.Windows.Forms.TextBox();
            this.Btn_FolderView = new System.Windows.Forms.Button();
            this.Btn_UploadByStream = new System.Windows.Forms.Button();
            this.FolderViewDialog = new System.Windows.Forms.OpenFileDialog();
            this.TB_ServerPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Team_2 = new System.Windows.Forms.RadioButton();
            this.RB_Gokuai_2 = new System.Windows.Forms.RadioButton();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.TB_OriginPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_TargetPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_Team_3 = new System.Windows.Forms.RadioButton();
            this.RB_Gokuai_3 = new System.Windows.Forms.RadioButton();
            this.Btn_Move = new System.Windows.Forms.Button();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_Team_4 = new System.Windows.Forms.RadioButton();
            this.RB_Gokuai_4 = new System.Windows.Forms.RadioButton();
            this.Btn_GetCollaboration = new System.Windows.Forms.Button();
            this.btn_ShareOperation = new System.Windows.Forms.Button();
            this.Btn_Download = new System.Windows.Forms.Button();
            this.Btn_GetGroupAndMember = new System.Windows.Forms.Button();
            this.TB_GroupId = new System.Windows.Forms.TextBox();
            this.Btn_GetGroupMemeber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_SearchContent = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_SaveSearch = new System.Windows.Forms.Button();
            this.TB_Code = new System.Windows.Forms.TextBox();
            this.Btn_GetUpdateList = new System.Windows.Forms.Button();
            this.TB_UpdateFilePath = new System.Windows.Forms.TextBox();
            this.Btn_RemoveSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RB_Team_5 = new System.Windows.Forms.RadioButton();
            this.RB_Gokuai_5 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RB_Team_6 = new System.Windows.Forms.RadioButton();
            this.RB_Gokuai_6 = new System.Windows.Forms.RadioButton();
            this.Btn_ReSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_GetMemberInfo = new System.Windows.Forms.Button();
            this.TB_MemberID = new System.Windows.Forms.TextBox();
            this.TB_AccountID = new System.Windows.Forms.TextBox();
            this.Btn_GetAccountInfo = new System.Windows.Forms.Button();
            this.Gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_RefreshToken
            // 
            this.Btn_RefreshToken.Location = new System.Drawing.Point(12, 18);
            this.Btn_RefreshToken.Name = "Btn_RefreshToken";
            this.Btn_RefreshToken.Size = new System.Drawing.Size(90, 23);
            this.Btn_RefreshToken.TabIndex = 0;
            this.Btn_RefreshToken.Text = "刷新token";
            this.Btn_RefreshToken.UseVisualStyleBackColor = true;
            this.Btn_RefreshToken.Click += new System.EventHandler(this.Btn_RefreshToken_Click);
            // 
            // Btn_GetFileInfo
            // 
            this.Btn_GetFileInfo.Location = new System.Drawing.Point(12, 76);
            this.Btn_GetFileInfo.Name = "Btn_GetFileInfo";
            this.Btn_GetFileInfo.Size = new System.Drawing.Size(101, 23);
            this.Btn_GetFileInfo.TabIndex = 1;
            this.Btn_GetFileInfo.Text = "获取单文件信息";
            this.Btn_GetFileInfo.UseVisualStyleBackColor = true;
            this.Btn_GetFileInfo.Click += new System.EventHandler(this.Btn_GetFileInfo_Click);
            // 
            // TB_FilePath
            // 
            this.TB_FilePath.Location = new System.Drawing.Point(12, 49);
            this.TB_FilePath.Name = "TB_FilePath";
            this.TB_FilePath.Size = new System.Drawing.Size(424, 21);
            this.TB_FilePath.TabIndex = 2;
            this.TB_FilePath.Text = "share/";
            // 
            // RB_Gokuai_1
            // 
            this.RB_Gokuai_1.AutoSize = true;
            this.RB_Gokuai_1.Checked = true;
            this.RB_Gokuai_1.Location = new System.Drawing.Point(11, 10);
            this.RB_Gokuai_1.Name = "RB_Gokuai_1";
            this.RB_Gokuai_1.Size = new System.Drawing.Size(47, 16);
            this.RB_Gokuai_1.TabIndex = 3;
            this.RB_Gokuai_1.TabStop = true;
            this.RB_Gokuai_1.Tag = "0";
            this.RB_Gokuai_1.Text = "个人";
            this.RB_Gokuai_1.UseVisualStyleBackColor = true;
            // 
            // RB_Team_1
            // 
            this.RB_Team_1.AutoSize = true;
            this.RB_Team_1.Location = new System.Drawing.Point(64, 11);
            this.RB_Team_1.Name = "RB_Team_1";
            this.RB_Team_1.Size = new System.Drawing.Size(47, 16);
            this.RB_Team_1.TabIndex = 4;
            this.RB_Team_1.Tag = "1";
            this.RB_Team_1.Text = "团队";
            this.RB_Team_1.UseVisualStyleBackColor = true;
            // 
            // Gb
            // 
            this.Gb.Controls.Add(this.RB_Team_1);
            this.Gb.Controls.Add(this.RB_Gokuai_1);
            this.Gb.Location = new System.Drawing.Point(442, 38);
            this.Gb.Name = "Gb";
            this.Gb.Size = new System.Drawing.Size(200, 32);
            this.Gb.TabIndex = 5;
            this.Gb.TabStop = false;
            // 
            // Btn_GetFileList
            // 
            this.Btn_GetFileList.Location = new System.Drawing.Point(119, 76);
            this.Btn_GetFileList.Name = "Btn_GetFileList";
            this.Btn_GetFileList.Size = new System.Drawing.Size(101, 23);
            this.Btn_GetFileList.TabIndex = 6;
            this.Btn_GetFileList.Text = "获取文件列表";
            this.Btn_GetFileList.UseVisualStyleBackColor = true;
            this.Btn_GetFileList.Click += new System.EventHandler(this.Btn_GetFileList_Click);
            // 
            // Btn_CreateFolder
            // 
            this.Btn_CreateFolder.Location = new System.Drawing.Point(226, 76);
            this.Btn_CreateFolder.Name = "Btn_CreateFolder";
            this.Btn_CreateFolder.Size = new System.Drawing.Size(102, 23);
            this.Btn_CreateFolder.TabIndex = 7;
            this.Btn_CreateFolder.Text = "创建文件夹";
            this.Btn_CreateFolder.UseVisualStyleBackColor = true;
            this.Btn_CreateFolder.Click += new System.EventHandler(this.Btn_CreateFolder_Click);
            // 
            // TB_Token
            // 
            this.TB_Token.Location = new System.Drawing.Point(119, 19);
            this.TB_Token.Name = "TB_Token";
            this.TB_Token.ReadOnly = true;
            this.TB_Token.Size = new System.Drawing.Size(317, 21);
            this.TB_Token.TabIndex = 8;
            // 
            // Btn_UploadByPath
            // 
            this.Btn_UploadByPath.Location = new System.Drawing.Point(12, 259);
            this.Btn_UploadByPath.Name = "Btn_UploadByPath";
            this.Btn_UploadByPath.Size = new System.Drawing.Size(119, 23);
            this.Btn_UploadByPath.TabIndex = 9;
            this.Btn_UploadByPath.Text = "通过路径上传";
            this.Btn_UploadByPath.UseVisualStyleBackColor = true;
            this.Btn_UploadByPath.Click += new System.EventHandler(this.Btn_UploadByPath_Click);
            // 
            // TB_LocalPath
            // 
            this.TB_LocalPath.Location = new System.Drawing.Point(76, 162);
            this.TB_LocalPath.Name = "TB_LocalPath";
            this.TB_LocalPath.Size = new System.Drawing.Size(354, 21);
            this.TB_LocalPath.TabIndex = 13;
            // 
            // Btn_FolderView
            // 
            this.Btn_FolderView.Location = new System.Drawing.Point(442, 162);
            this.Btn_FolderView.Name = "Btn_FolderView";
            this.Btn_FolderView.Size = new System.Drawing.Size(75, 23);
            this.Btn_FolderView.TabIndex = 11;
            this.Btn_FolderView.Text = "浏览";
            this.Btn_FolderView.UseVisualStyleBackColor = true;
            this.Btn_FolderView.Click += new System.EventHandler(this.Btn_FolderView_Click);
            // 
            // Btn_UploadByStream
            // 
            this.Btn_UploadByStream.Location = new System.Drawing.Point(137, 259);
            this.Btn_UploadByStream.Name = "Btn_UploadByStream";
            this.Btn_UploadByStream.Size = new System.Drawing.Size(146, 23);
            this.Btn_UploadByStream.TabIndex = 12;
            this.Btn_UploadByStream.Text = "通过流上传";
            this.Btn_UploadByStream.UseVisualStyleBackColor = true;
            this.Btn_UploadByStream.Click += new System.EventHandler(this.Btn_UpLoadByStream_Click);
            // 
            // FolderViewDialog
            // 
            this.FolderViewDialog.FileName = "openFileDialog1";
            // 
            // TB_ServerPath
            // 
            this.TB_ServerPath.Location = new System.Drawing.Point(76, 189);
            this.TB_ServerPath.Name = "TB_ServerPath";
            this.TB_ServerPath.Size = new System.Drawing.Size(223, 21);
            this.TB_ServerPath.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "服务端路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "本地路径";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Team_2);
            this.groupBox1.Controls.Add(this.RB_Gokuai_2);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 32);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // RB_Team_2
            // 
            this.RB_Team_2.AutoSize = true;
            this.RB_Team_2.Location = new System.Drawing.Point(64, 10);
            this.RB_Team_2.Name = "RB_Team_2";
            this.RB_Team_2.Size = new System.Drawing.Size(47, 16);
            this.RB_Team_2.TabIndex = 4;
            this.RB_Team_2.Tag = "1";
            this.RB_Team_2.Text = "团队";
            this.RB_Team_2.UseVisualStyleBackColor = true;
            // 
            // RB_Gokuai_2
            // 
            this.RB_Gokuai_2.AutoSize = true;
            this.RB_Gokuai_2.Checked = true;
            this.RB_Gokuai_2.Location = new System.Drawing.Point(11, 10);
            this.RB_Gokuai_2.Name = "RB_Gokuai_2";
            this.RB_Gokuai_2.Size = new System.Drawing.Size(47, 16);
            this.RB_Gokuai_2.TabIndex = 3;
            this.RB_Gokuai_2.TabStop = true;
            this.RB_Gokuai_2.Tag = "0";
            this.RB_Gokuai_2.Text = "个人";
            this.RB_Gokuai_2.UseVisualStyleBackColor = true;
            // 
            // Btn_Del
            // 
            this.Btn_Del.Location = new System.Drawing.Point(334, 76);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(75, 23);
            this.Btn_Del.TabIndex = 21;
            this.Btn_Del.Text = "删除";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // TB_OriginPath
            // 
            this.TB_OriginPath.Location = new System.Drawing.Point(78, 331);
            this.TB_OriginPath.Name = "TB_OriginPath";
            this.TB_OriginPath.Size = new System.Drawing.Size(352, 21);
            this.TB_OriginPath.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "源文件路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "目标路径";
            // 
            // TB_TargetPath
            // 
            this.TB_TargetPath.Location = new System.Drawing.Point(78, 358);
            this.TB_TargetPath.Name = "TB_TargetPath";
            this.TB_TargetPath.Size = new System.Drawing.Size(352, 21);
            this.TB_TargetPath.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_Team_3);
            this.groupBox2.Controls.Add(this.RB_Gokuai_3);
            this.groupBox2.Location = new System.Drawing.Point(442, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 32);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // RB_Team_3
            // 
            this.RB_Team_3.AutoSize = true;
            this.RB_Team_3.Location = new System.Drawing.Point(64, 10);
            this.RB_Team_3.Name = "RB_Team_3";
            this.RB_Team_3.Size = new System.Drawing.Size(47, 16);
            this.RB_Team_3.TabIndex = 4;
            this.RB_Team_3.Tag = "1";
            this.RB_Team_3.Text = "团队";
            this.RB_Team_3.UseVisualStyleBackColor = true;
            // 
            // RB_Gokuai_3
            // 
            this.RB_Gokuai_3.AutoSize = true;
            this.RB_Gokuai_3.Checked = true;
            this.RB_Gokuai_3.Location = new System.Drawing.Point(11, 10);
            this.RB_Gokuai_3.Name = "RB_Gokuai_3";
            this.RB_Gokuai_3.Size = new System.Drawing.Size(47, 16);
            this.RB_Gokuai_3.TabIndex = 3;
            this.RB_Gokuai_3.TabStop = true;
            this.RB_Gokuai_3.Tag = "0";
            this.RB_Gokuai_3.Text = "个人";
            this.RB_Gokuai_3.UseVisualStyleBackColor = true;
            // 
            // Btn_Move
            // 
            this.Btn_Move.Location = new System.Drawing.Point(13, 393);
            this.Btn_Move.Name = "Btn_Move";
            this.Btn_Move.Size = new System.Drawing.Size(75, 23);
            this.Btn_Move.TabIndex = 27;
            this.Btn_Move.Text = "移动";
            this.Btn_Move.UseVisualStyleBackColor = true;
            this.Btn_Move.Click += new System.EventHandler(this.Btn_Move_Click);
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Location = new System.Drawing.Point(94, 393);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.Btn_Copy.TabIndex = 28;
            this.Btn_Copy.Text = "复制";
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RB_Team_4);
            this.groupBox3.Controls.Add(this.RB_Gokuai_4);
            this.groupBox3.Location = new System.Drawing.Point(442, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 32);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // RB_Team_4
            // 
            this.RB_Team_4.AutoSize = true;
            this.RB_Team_4.Location = new System.Drawing.Point(64, 10);
            this.RB_Team_4.Name = "RB_Team_4";
            this.RB_Team_4.Size = new System.Drawing.Size(47, 16);
            this.RB_Team_4.TabIndex = 4;
            this.RB_Team_4.Tag = "1";
            this.RB_Team_4.Text = "团队";
            this.RB_Team_4.UseVisualStyleBackColor = true;
            // 
            // RB_Gokuai_4
            // 
            this.RB_Gokuai_4.AutoSize = true;
            this.RB_Gokuai_4.Checked = true;
            this.RB_Gokuai_4.Location = new System.Drawing.Point(11, 10);
            this.RB_Gokuai_4.Name = "RB_Gokuai_4";
            this.RB_Gokuai_4.Size = new System.Drawing.Size(47, 16);
            this.RB_Gokuai_4.TabIndex = 3;
            this.RB_Gokuai_4.TabStop = true;
            this.RB_Gokuai_4.Tag = "0";
            this.RB_Gokuai_4.Text = "个人";
            this.RB_Gokuai_4.UseVisualStyleBackColor = true;
            // 
            // Btn_GetCollaboration
            // 
            this.Btn_GetCollaboration.Location = new System.Drawing.Point(13, 105);
            this.Btn_GetCollaboration.Name = "Btn_GetCollaboration";
            this.Btn_GetCollaboration.Size = new System.Drawing.Size(100, 23);
            this.Btn_GetCollaboration.TabIndex = 30;
            this.Btn_GetCollaboration.Text = "获取共享参与人";
            this.Btn_GetCollaboration.UseVisualStyleBackColor = true;
            this.Btn_GetCollaboration.Click += new System.EventHandler(this.Btn_GetCollaboration_Click);
            // 
            // btn_ShareOperation
            // 
            this.btn_ShareOperation.Location = new System.Drawing.Point(120, 104);
            this.btn_ShareOperation.Name = "btn_ShareOperation";
            this.btn_ShareOperation.Size = new System.Drawing.Size(137, 23);
            this.btn_ShareOperation.TabIndex = 31;
            this.btn_ShareOperation.Text = "添加/编辑/删除共享人";
            this.btn_ShareOperation.UseVisualStyleBackColor = true;
            this.btn_ShareOperation.Click += new System.EventHandler(this.btn_ShareOperation_Click);
            // 
            // Btn_Download
            // 
            this.Btn_Download.Location = new System.Drawing.Point(415, 76);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(75, 23);
            this.Btn_Download.TabIndex = 32;
            this.Btn_Download.Text = "下载";
            this.Btn_Download.UseVisualStyleBackColor = true;
            this.Btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
            // 
            // Btn_GetGroupAndMember
            // 
            this.Btn_GetGroupAndMember.Location = new System.Drawing.Point(13, 452);
            this.Btn_GetGroupAndMember.Name = "Btn_GetGroupAndMember";
            this.Btn_GetGroupAndMember.Size = new System.Drawing.Size(110, 23);
            this.Btn_GetGroupAndMember.TabIndex = 33;
            this.Btn_GetGroupAndMember.Text = "获取组和团队成员";
            this.Btn_GetGroupAndMember.UseVisualStyleBackColor = true;
            this.Btn_GetGroupAndMember.Click += new System.EventHandler(this.Btn_GetGroupAndMember_Click);
            // 
            // TB_GroupId
            // 
            this.TB_GroupId.Location = new System.Drawing.Point(58, 481);
            this.TB_GroupId.Name = "TB_GroupId";
            this.TB_GroupId.Size = new System.Drawing.Size(53, 21);
            this.TB_GroupId.TabIndex = 34;
            // 
            // Btn_GetGroupMemeber
            // 
            this.Btn_GetGroupMemeber.Location = new System.Drawing.Point(121, 479);
            this.Btn_GetGroupMemeber.Name = "Btn_GetGroupMemeber";
            this.Btn_GetGroupMemeber.Size = new System.Drawing.Size(109, 23);
            this.Btn_GetGroupMemeber.TabIndex = 35;
            this.Btn_GetGroupMemeber.Text = "获取组内成员";
            this.Btn_GetGroupMemeber.UseVisualStyleBackColor = true;
            this.Btn_GetGroupMemeber.Click += new System.EventHandler(this.Btn_GetGroupMemeber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "组号";
            // 
            // TB_SearchContent
            // 
            this.TB_SearchContent.Location = new System.Drawing.Point(58, 529);
            this.TB_SearchContent.Name = "TB_SearchContent";
            this.TB_SearchContent.Size = new System.Drawing.Size(128, 21);
            this.TB_SearchContent.TabIndex = 37;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(328, 526);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 38;
            this.Btn_Search.Text = "搜索";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_SaveSearch
            // 
            this.Btn_SaveSearch.Location = new System.Drawing.Point(203, 556);
            this.Btn_SaveSearch.Name = "Btn_SaveSearch";
            this.Btn_SaveSearch.Size = new System.Drawing.Size(75, 23);
            this.Btn_SaveSearch.TabIndex = 41;
            this.Btn_SaveSearch.Text = "保存搜索";
            this.Btn_SaveSearch.UseVisualStyleBackColor = true;
            this.Btn_SaveSearch.Click += new System.EventHandler(this.Btn_SaveSearch_Click);
            // 
            // TB_Code
            // 
            this.TB_Code.Location = new System.Drawing.Point(58, 557);
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(128, 21);
            this.TB_Code.TabIndex = 42;
            // 
            // Btn_GetUpdateList
            // 
            this.Btn_GetUpdateList.Location = new System.Drawing.Point(439, 615);
            this.Btn_GetUpdateList.Name = "Btn_GetUpdateList";
            this.Btn_GetUpdateList.Size = new System.Drawing.Size(114, 23);
            this.Btn_GetUpdateList.TabIndex = 43;
            this.Btn_GetUpdateList.Text = "获取更新列表";
            this.Btn_GetUpdateList.UseVisualStyleBackColor = true;
            this.Btn_GetUpdateList.Click += new System.EventHandler(this.Btn_GetUpdateList_Click);
            // 
            // TB_UpdateFilePath
            // 
            this.TB_UpdateFilePath.Location = new System.Drawing.Point(58, 615);
            this.TB_UpdateFilePath.Name = "TB_UpdateFilePath";
            this.TB_UpdateFilePath.Size = new System.Drawing.Size(252, 21);
            this.TB_UpdateFilePath.TabIndex = 44;
            // 
            // Btn_RemoveSearch
            // 
            this.Btn_RemoveSearch.Location = new System.Drawing.Point(291, 555);
            this.Btn_RemoveSearch.Name = "Btn_RemoveSearch";
            this.Btn_RemoveSearch.Size = new System.Drawing.Size(75, 23);
            this.Btn_RemoveSearch.TabIndex = 45;
            this.Btn_RemoveSearch.Text = "删除搜索";
            this.Btn_RemoveSearch.UseVisualStyleBackColor = true;
            this.Btn_RemoveSearch.Click += new System.EventHandler(this.Btn_RemoveSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "code";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RB_Team_5);
            this.groupBox4.Controls.Add(this.RB_Gokuai_5);
            this.groupBox4.Location = new System.Drawing.Point(203, 518);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 32);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            // 
            // RB_Team_5
            // 
            this.RB_Team_5.AutoSize = true;
            this.RB_Team_5.Location = new System.Drawing.Point(64, 10);
            this.RB_Team_5.Name = "RB_Team_5";
            this.RB_Team_5.Size = new System.Drawing.Size(47, 16);
            this.RB_Team_5.TabIndex = 4;
            this.RB_Team_5.Tag = "1";
            this.RB_Team_5.Text = "团队";
            this.RB_Team_5.UseVisualStyleBackColor = true;
            // 
            // RB_Gokuai_5
            // 
            this.RB_Gokuai_5.AutoSize = true;
            this.RB_Gokuai_5.Checked = true;
            this.RB_Gokuai_5.Location = new System.Drawing.Point(11, 10);
            this.RB_Gokuai_5.Name = "RB_Gokuai_5";
            this.RB_Gokuai_5.Size = new System.Drawing.Size(47, 16);
            this.RB_Gokuai_5.TabIndex = 3;
            this.RB_Gokuai_5.TabStop = true;
            this.RB_Gokuai_5.Tag = "0";
            this.RB_Gokuai_5.Text = "个人";
            this.RB_Gokuai_5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RB_Team_6);
            this.groupBox5.Controls.Add(this.RB_Gokuai_6);
            this.groupBox5.Location = new System.Drawing.Point(317, 606);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 32);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            // 
            // RB_Team_6
            // 
            this.RB_Team_6.AutoSize = true;
            this.RB_Team_6.Location = new System.Drawing.Point(64, 10);
            this.RB_Team_6.Name = "RB_Team_6";
            this.RB_Team_6.Size = new System.Drawing.Size(47, 16);
            this.RB_Team_6.TabIndex = 4;
            this.RB_Team_6.Tag = "1";
            this.RB_Team_6.Text = "团队";
            this.RB_Team_6.UseVisualStyleBackColor = true;
            // 
            // RB_Gokuai_6
            // 
            this.RB_Gokuai_6.AutoSize = true;
            this.RB_Gokuai_6.Checked = true;
            this.RB_Gokuai_6.Location = new System.Drawing.Point(11, 10);
            this.RB_Gokuai_6.Name = "RB_Gokuai_6";
            this.RB_Gokuai_6.Size = new System.Drawing.Size(47, 16);
            this.RB_Gokuai_6.TabIndex = 3;
            this.RB_Gokuai_6.TabStop = true;
            this.RB_Gokuai_6.Tag = "0";
            this.RB_Gokuai_6.Text = "个人";
            this.RB_Gokuai_6.UseVisualStyleBackColor = true;
            // 
            // Btn_ReSearch
            // 
            this.Btn_ReSearch.Location = new System.Drawing.Point(372, 556);
            this.Btn_ReSearch.Name = "Btn_ReSearch";
            this.Btn_ReSearch.Size = new System.Drawing.Size(99, 23);
            this.Btn_ReSearch.TabIndex = 49;
            this.Btn_ReSearch.Text = "重取搜索结果";
            this.Btn_ReSearch.UseVisualStyleBackColor = true;
            this.Btn_ReSearch.Click += new System.EventHandler(this.Btn_ReSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "路径";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 51;
            this.label8.Text = "路径";
            // 
            // Btn_GetMemberInfo
            // 
            this.Btn_GetMemberInfo.Location = new System.Drawing.Point(334, 656);
            this.Btn_GetMemberInfo.Name = "Btn_GetMemberInfo";
            this.Btn_GetMemberInfo.Size = new System.Drawing.Size(115, 23);
            this.Btn_GetMemberInfo.TabIndex = 52;
            this.Btn_GetMemberInfo.Text = "获取meberId";
            this.Btn_GetMemberInfo.UseVisualStyleBackColor = true;
            this.Btn_GetMemberInfo.Click += new System.EventHandler(this.Btn_GetMemberInfo_Click);
            // 
            // TB_MemberID
            // 
            this.TB_MemberID.Location = new System.Drawing.Point(18, 658);
            this.TB_MemberID.Name = "TB_MemberID";
            this.TB_MemberID.Size = new System.Drawing.Size(100, 21);
            this.TB_MemberID.TabIndex = 53;
            // 
            // TB_AccountID
            // 
            this.TB_AccountID.Location = new System.Drawing.Point(228, 658);
            this.TB_AccountID.Name = "TB_AccountID";
            this.TB_AccountID.Size = new System.Drawing.Size(100, 21);
            this.TB_AccountID.TabIndex = 54;
            // 
            // Btn_GetAccountInfo
            // 
            this.Btn_GetAccountInfo.Location = new System.Drawing.Point(124, 656);
            this.Btn_GetAccountInfo.Name = "Btn_GetAccountInfo";
            this.Btn_GetAccountInfo.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetAccountInfo.TabIndex = 55;
            this.Btn_GetAccountInfo.Text = "获取帐号";
            this.Btn_GetAccountInfo.UseVisualStyleBackColor = true;
            this.Btn_GetAccountInfo.Click += new System.EventHandler(this.Btn_GetAccountInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 704);
            this.Controls.Add(this.Btn_GetAccountInfo);
            this.Controls.Add(this.TB_AccountID);
            this.Controls.Add(this.TB_MemberID);
            this.Controls.Add(this.Btn_GetMemberInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_ReSearch);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_RemoveSearch);
            this.Controls.Add(this.TB_UpdateFilePath);
            this.Controls.Add(this.Btn_GetUpdateList);
            this.Controls.Add(this.TB_Code);
            this.Controls.Add(this.Btn_SaveSearch);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.TB_SearchContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_GetGroupMemeber);
            this.Controls.Add(this.TB_GroupId);
            this.Controls.Add(this.Btn_GetGroupAndMember);
            this.Controls.Add(this.Btn_Download);
            this.Controls.Add(this.btn_ShareOperation);
            this.Controls.Add(this.Btn_GetCollaboration);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Copy);
            this.Controls.Add(this.Btn_Move);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TB_TargetPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_OriginPath);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ServerPath);
            this.Controls.Add(this.Btn_UploadByStream);
            this.Controls.Add(this.Btn_FolderView);
            this.Controls.Add(this.TB_LocalPath);
            this.Controls.Add(this.Btn_UploadByPath);
            this.Controls.Add(this.TB_Token);
            this.Controls.Add(this.Btn_CreateFolder);
            this.Controls.Add(this.Btn_GetFileList);
            this.Controls.Add(this.Gb);
            this.Controls.Add(this.TB_FilePath);
            this.Controls.Add(this.Btn_GetFileInfo);
            this.Controls.Add(this.Btn_RefreshToken);
            this.Name = "MainForm";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gb.ResumeLayout(false);
            this.Gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_RefreshToken;
        private System.Windows.Forms.Button Btn_GetFileInfo;
        private System.Windows.Forms.TextBox TB_FilePath;
        private System.Windows.Forms.RadioButton RB_Gokuai_1;
        private System.Windows.Forms.RadioButton RB_Team_1;
        private System.Windows.Forms.GroupBox Gb;
        private System.Windows.Forms.Button Btn_GetFileList;
        private System.Windows.Forms.Button Btn_CreateFolder;
        private System.Windows.Forms.TextBox TB_Token;
        private System.Windows.Forms.Button Btn_UploadByPath;
        private System.Windows.Forms.TextBox TB_LocalPath;
        private System.Windows.Forms.Button Btn_FolderView;
        private System.Windows.Forms.Button Btn_UploadByStream;
        private System.Windows.Forms.OpenFileDialog FolderViewDialog;
        private System.Windows.Forms.TextBox TB_ServerPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Team_2;
        private System.Windows.Forms.RadioButton RB_Gokuai_2;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.TextBox TB_OriginPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_TargetPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_Team_3;
        private System.Windows.Forms.RadioButton RB_Gokuai_3;
        private System.Windows.Forms.Button Btn_Move;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RB_Team_4;
        private System.Windows.Forms.RadioButton RB_Gokuai_4;
        private System.Windows.Forms.Button Btn_GetCollaboration;
        private System.Windows.Forms.Button btn_ShareOperation;
        private System.Windows.Forms.Button Btn_Download;
        private System.Windows.Forms.Button Btn_GetGroupAndMember;
        private System.Windows.Forms.TextBox TB_GroupId;
        private System.Windows.Forms.Button Btn_GetGroupMemeber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_SearchContent;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_SaveSearch;
        private System.Windows.Forms.TextBox TB_Code;
        private System.Windows.Forms.Button Btn_GetUpdateList;
        private System.Windows.Forms.TextBox TB_UpdateFilePath;
        private System.Windows.Forms.Button Btn_RemoveSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RB_Team_5;
        private System.Windows.Forms.RadioButton RB_Gokuai_5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton RB_Team_6;
        private System.Windows.Forms.RadioButton RB_Gokuai_6;
        private System.Windows.Forms.Button Btn_ReSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_GetMemberInfo;
        private System.Windows.Forms.TextBox TB_MemberID;
        private System.Windows.Forms.TextBox TB_AccountID;
        private System.Windows.Forms.Button Btn_GetAccountInfo;
    }
}

