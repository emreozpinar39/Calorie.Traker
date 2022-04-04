using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YerNTier.BLL.Services;
using YerNTier.Model.Entities;

namespace SaglikliYER
{
    public partial class FormNotification : Form
    {
        UserInfoService infoService;
        UserService userService;
        public FormNotification()
        {
            InitializeComponent();
            infoService = new UserInfoService();
            userService = new UserService();
        }
        int userID;
        public FormNotification(int _userID)
        {
            InitializeComponent();
            infoService = new UserInfoService();
            userService = new UserService();
            userID = _userID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFeedMonster formFeedMonster = new FormFeedMonster();
            formFeedMonster.ShowDialog();
        }

        private void FormNotification_Load(object sender, EventArgs e)
        {
            FillListView();
        }
        void FillListView()
        {
            try
            {
                listView1.Items.Clear();
                List<UserInfo> infoList = infoService.ShowMess(userID);
                foreach (UserInfo item in infoList)
                {
                    ListViewItem listView = new ListViewItem();
                    //listView.Tag = item.DUserID;
                    //listView.Text = item.DUsers.UserDetail.UserName;
                    //listView.SubItems.Add(item.DUsers.UserDetail.SurName);
                    //listView.SubItems.Add(item.MessageComment);
                    listView.Text = item.MessageComment;
                    listView.SubItems.Add(item.SenderName);
                    listView1.Items.Add(listView);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
