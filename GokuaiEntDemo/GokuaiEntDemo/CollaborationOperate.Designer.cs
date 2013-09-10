namespace GokuaiEntDemo
{
    partial class CollaborationOperate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_AddShare = new System.Windows.Forms.Button();
            this.Btn_EditShare = new System.Windows.Forms.Button();
            this.TB_MemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Right = new System.Windows.Forms.ComboBox();
            this.CB_Type = new System.Windows.Forms.ComboBox();
            this.Btn_DelShare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_AddShare
            // 
            this.Btn_AddShare.Location = new System.Drawing.Point(12, 138);
            this.Btn_AddShare.Name = "Btn_AddShare";
            this.Btn_AddShare.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddShare.TabIndex = 0;
            this.Btn_AddShare.Text = "添加";
            this.Btn_AddShare.UseVisualStyleBackColor = true;
            this.Btn_AddShare.Click += new System.EventHandler(this.Btn_AddShare_Click);
            // 
            // Btn_EditShare
            // 
            this.Btn_EditShare.Location = new System.Drawing.Point(107, 138);
            this.Btn_EditShare.Name = "Btn_EditShare";
            this.Btn_EditShare.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditShare.TabIndex = 1;
            this.Btn_EditShare.Text = "编辑";
            this.Btn_EditShare.UseVisualStyleBackColor = true;
            this.Btn_EditShare.Click += new System.EventHandler(this.Btn_EditShare_Click);
            // 
            // TB_MemberID
            // 
            this.TB_MemberID.Location = new System.Drawing.Point(84, 59);
            this.TB_MemberID.Name = "TB_MemberID";
            this.TB_MemberID.Size = new System.Drawing.Size(75, 21);
            this.TB_MemberID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "共享人标识";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "权限";
            // 
            // CB_Right
            // 
            this.CB_Right.FormattingEnabled = true;
            this.CB_Right.Items.AddRange(new object[] {
            "拥有者",
            "编辑者",
            "查看者",
            "规定者 "});
            this.CB_Right.Location = new System.Drawing.Point(84, 93);
            this.CB_Right.Name = "CB_Right";
            this.CB_Right.Size = new System.Drawing.Size(121, 20);
            this.CB_Right.TabIndex = 9;
            // 
            // CB_Type
            // 
            this.CB_Type.FormattingEnabled = true;
            this.CB_Type.Items.AddRange(new object[] {
            "成员",
            "分组"});
            this.CB_Type.Location = new System.Drawing.Point(84, 25);
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.Size = new System.Drawing.Size(121, 20);
            this.CB_Type.TabIndex = 10;
            // 
            // Btn_DelShare
            // 
            this.Btn_DelShare.Location = new System.Drawing.Point(205, 137);
            this.Btn_DelShare.Name = "Btn_DelShare";
            this.Btn_DelShare.Size = new System.Drawing.Size(75, 23);
            this.Btn_DelShare.TabIndex = 11;
            this.Btn_DelShare.Text = "删除";
            this.Btn_DelShare.UseVisualStyleBackColor = true;
            this.Btn_DelShare.Click += new System.EventHandler(this.Btn_DelShare_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "（删除操作不传此参数）";
            // 
            // CollaborationOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 194);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_DelShare);
            this.Controls.Add(this.CB_Type);
            this.Controls.Add(this.CB_Right);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_MemberID);
            this.Controls.Add(this.Btn_EditShare);
            this.Controls.Add(this.Btn_AddShare);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CollaborationOperate";
            this.Text = "添加/编辑/删除共享人";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CollaborationOperate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddShare;
        private System.Windows.Forms.Button Btn_EditShare;
        private System.Windows.Forms.TextBox TB_MemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Right;
        private System.Windows.Forms.ComboBox CB_Type;
        private System.Windows.Forms.Button Btn_DelShare;
        private System.Windows.Forms.Label label4;
    }
}