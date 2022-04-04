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
    public partial class FormChallange : Form
    {
        UserService userService;
        UserInfoService userInfoService;
        UserDatailsServece userDatailsServece;
        MealService mealService;
        public FormChallange()
        {
            InitializeComponent();
            userService = new UserService();
            userInfoService = new UserInfoService();
            userDatailsServece = new UserDatailsServece();
            mealService = new MealService();

        }
        int sUserID;
        public FormChallange(int _userID)
        {
            InitializeComponent();
            userService = new UserService();
            userInfoService = new UserInfoService();
            userDatailsServece = new UserDatailsServece();
            mealService = new MealService();
            sUserID = _userID;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCongratulations_Click(object sender, EventArgs e)
        {
            try
            {
                userID = Convert.ToInt32(listView2.SelectedItems[0].Tag);
                UserInfo info = new UserInfo();
                info.DUserID = userID;
                info.MessageComment = "Woav Congratulations";
                UserDetail userDetail = userDatailsServece.GetUserDetailByID(sUserID);
                info.SenderName = userDetail.UserName;
                userInfoService.AddMess(info);
                MessageBox.Show("Tebrik ettiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
        }
        int userID;
        private void btnChallange_Click(object sender, EventArgs e)
        {
            try
            {
                userID = Convert.ToInt32(listView2.SelectedItems[0].Tag);
                UserInfo info = new UserInfo();
                info.DUserID = userID;
                info.MessageComment = "Lets Challenge";
                UserDetail userDetail = userDatailsServece.GetUserDetailByID(sUserID);
                info.SenderName = userDetail.UserName;
                userInfoService.AddMess(info);
                MessageBox.Show("Challenge Davet ettiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FiilListView();
            txtSearcUser.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            DUser dUser = userService.GetUserByUserID(sUserID);
            List<DUser> userList = new List<DUser>();

            userList = userService.GetUserForChallengeAndKey(dUser.Wish,txtSearcUser.Text);
            ListViewItem listVItem;
            foreach (DUser item in userList)
            {
                UserDetail userDetail = userDatailsServece.GetUserDetailByID(item.DUserID);
                listVItem = new ListViewItem();
                listVItem.Tag = item.DUserID;
                listVItem.Text = item.Email;
                listView2.Items.Add(listVItem);
            }
        }

        private void FormChallange_Load(object sender, EventArgs e)
        {
            FiilListView();
        }
        void FiilListView()
        {
            listView2.Items.Clear();
            DUser dUser = userService.GetUserByUserID(sUserID);
            List<DUser> userList = new List<DUser>();

            userList = userService.GetUserForChallenge(dUser.Wish);
            ListViewItem listVItem;
            foreach (DUser item in userList)
            {
                UserDetail userDetail = userDatailsServece.GetUserDetailByID(item.DUserID);
                listVItem = new ListViewItem();
                listVItem.Tag = item.DUserID;
                listVItem.Text = item.Email;
                listView2.Items.Add(listVItem);
            }
        }
    }
}
