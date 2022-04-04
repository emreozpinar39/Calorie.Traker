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
    public partial class FormSettings : Form
    {
        UserService userService;
        PasswordService passService;
        UserDatailsServece userDatailsServece;
        public FormSettings()
        {
            InitializeComponent();
        }
        int userID;
        public FormSettings(int _userID)
        {
            InitializeComponent();
            userService = new UserService();
            passService = new PasswordService();
            userDatailsServece = new UserDatailsServece();
            userID = _userID;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            Password password = new Password();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

            UserDetail userDetail1 = userDatailsServece.GetUserDetailByID(userID);

            if (userDetail1.Gender == false) pictureBox1.Image = Image.FromFile(@"C:\Users\Yunus\Desktop\SaglikliYER\Man.png");
            else if (userDetail1.Gender == true) pictureBox1.Image = Image.FromFile(@"C:\Users\Yunus\Desktop\SaglikliYER\Woman.png");

            try
            {
                UserDetail userDetail = userDatailsServece.GetUserDetailByID(userID);
                txtName.Text = userDetail.UserName;
                txtSurname.Text = userDetail.SurName;
                int Age = DateTime.Now.Year - userDetail.BirthDate.Year;
                labelAge.Text = Age.ToString();
                txtHeight.Text = userDetail.Height.ToString();
                txtWeight.Text = userDetail.Weight.ToString();
                labelMail.Text = userDetail.DUser.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                Password activePassword = passService.GetActivePassword(userID);
                if (txtOldPass.Text != activePassword.PasswordText)
                {
                    MessageBox.Show("Mevcut şifrenizi hatalı girdiniz");
                    return;
                }
                if (txtNewPass1.Text != txtNewPass2.Text)
                {
                    MessageBox.Show("Şifre tekrarı hatalı");
                    return;
                }
                bool check = passService.AddPassword(new Password()
                {
                    PasswordText = txtNewPass1.Text,
                    DUserID = userID
                });
                MessageBox.Show(check ? "Şifre değiştirildi" : "Şifre değiştirileMedi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                
                userDatailsServece.CUpdateUserDetails(new UserDetail()
                {
                    UserDetailID = userID,
                    UserName = txtName.Text,
                    SurName = txtSurname.Text,
                    Height = Convert.ToDecimal(txtHeight.Text),
                    Weight = Convert.ToDecimal(txtWeight.Text)
                });
                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
