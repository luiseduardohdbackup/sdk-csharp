using GoKuai_EntSDK.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GokuaiEntDemo
{
    public partial class CollaborationOperate : Form
    {
        private MainForm _ParentForm;
        
       
        public CollaborationOperate(MainForm form)
        {
            InitializeComponent();
            _ParentForm = form;
        }

        private Collaboration GetValue()
        {
            Collaboration collaboration=new Collaboration();;
            Collaboration.ShareTargetType type;
            Collaboration.Right right;
            int memberId;

            switch (CB_Type.SelectedIndex)
            {

                case 0:
                    type = Collaboration.ShareTargetType.MEMBER;
                    break;
                case 1:
                    type = Collaboration.ShareTargetType.GROUP;
                    break;
                default:
                   type = Collaboration.ShareTargetType.GROUP;
                    break;

            }

            switch (CB_Right.SelectedIndex)
            {
                case 0:
                    right = Collaboration.Right.OWNER;
                    break;
                case 1:
                    right = Collaboration.Right.EDITOR;
                    break;
                case 2:
                    right = Collaboration.Right.VIEWER;
                    break;
                case 3:
                    right = Collaboration.Right.ARCHIVER;
                    break;
                default:
                    right = Collaboration.Right.OWNER;
                    break;

            }

            memberId = int.Parse(TB_MemberID.Text);
            collaboration.Add(type, memberId, right);
            return collaboration;
        }

        private void Btn_AddShare_Click(object sender, EventArgs e)
        {
            _ParentForm.AddShare(GetValue());
            this.Close();
        }

        private void Btn_EditShare_Click(object sender, EventArgs e)
        {
            _ParentForm.EditShare(GetValue());
            this.Close();
        }

        private void Btn_DelShare_Click(object sender, EventArgs e)
        {
            _ParentForm.DelShare(GetValue());
            this.Close();
        }

        private void CollaborationOperate_Load(object sender, EventArgs e)
        {
            CB_Right.SelectedIndex = 0;
            CB_Type.SelectedIndex = 0;
            TB_MemberID.Text = 625+"";
        }
    }
}
