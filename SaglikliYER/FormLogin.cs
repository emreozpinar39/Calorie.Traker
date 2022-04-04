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
    public partial class FormLogin : Form
    {
        bool count = true;
        UserService userService;
        PasswordService passwordService;
        public FormLogin()
        {
            InitializeComponent();
            userService = new UserService();
            passwordService = new PasswordService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string pass = txtPassword1.Text;
                DUser dUser = userService.CheckLogin(email, pass);
                if (dUser != null)
                {
                    FormMain formMain = new FormMain(dUser.DUserID);
                    formMain.ShowDialog();
                    txtEmail.Text = "";
                    txtPassword1.Text = "";
                    this.Close();
                }
                else MessageBox.Show("Kullanıcı hatalı veya şifre hatalı ");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (count == true)
            {
                txtPassword1.PasswordChar = '\0';
                count = false;
            }
            else if (count == false)
            {
                txtPassword1.PasswordChar = '*';
                count = true;
            }
        }
    }
}
