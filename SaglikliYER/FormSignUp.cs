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
    public partial class FormSignUp : Form
    {
        UserService userService;
        UserDatailsServece userDatailsServece;
        PasswordService passwordService;
        bool count = true;
        public FormSignUp()
        {
            InitializeComponent();
            userService = new UserService();
            userDatailsServece = new UserDatailsServece();
            passwordService = new PasswordService();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword1.Text != "" && txtPassword1.Text == txtPassword2.Text)
                {
                    bool sonuc = userService.UserEmailIfExist(txtEmail.Text);
                    if (sonuc == true)
                    {
                        if (!txtEmail.Text.Contains("@") || !txtEmail.Text.EndsWith(".com"))
                        {
                            MessageBox.Show("Please type a correct email.");
                            return;
                        }
                        passwordService.CheckPasswordText(txtPassword1.Text);

                        DUser dUser = new DUser();
                        dUser.Email = txtEmail.Text;
                        if (radioGain.Checked)
                            dUser.Wish = "Gain";
                        else if (radioKeep.Checked)
                            dUser.Wish = "Keep";
                        else if (radioToBeFit.Checked)
                            dUser.Wish = "To Be Fit";
                        else
                        {
                            MessageBox.Show("Choose Your Goals");
                            return;
                        }
                        userService.AddUser(dUser);
                        
                        Password password = new Password();
                        password.PasswordText = txtPassword1.Text;
                        password.DUserID = dUser.DUserID;
                        passwordService.AddPassword(password);

                        UserDetail userDetail = new UserDetail();
                        userDetail.UserName = txtName.Text;
                        userDetail.SurName = txtSurname.Text;
                        userDetail.Height = numBoy.Value;
                        userDetail.Weight = numKilo.Value;
                        userDetail.BirthDate = dateTimeBirth.Value;
                        if (radioMan.Checked) userDetail.Gender = false;
                        else if (radioWoman.Checked) userDetail.Gender = true;
                        userDetail.UserDetailID = dUser.DUserID;
                        userDatailsServece.CAddUserDetail(userDetail);
                        MessageBox.Show("Kayıt Başarılı");
                    }
                    
                    txtEmail.Text = "";
                    txtPassword1.Text = "";
                    txtPassword2.Text = "";
                    txtName.Text = "";
                    txtSurname.Text = "";
                    numBoy.Value = 0;
                    numKilo.Value = 0;
                }
                else MessageBox.Show("Şifreler uyuşmuyor.");             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string PassLevel(string _pass)
        {
            bool buyukMu = false;
            bool kucukMu = false;
            bool rakamMi = false;
            int UzunlukAl = _pass.Length;
            if (UzunlukAl < 6)
            {
                return "Zayıf Şifre..";
            }
            else
            {
                if (_pass.Any(char.IsUpper))
                {
                    buyukMu = true;
                }
                if (_pass.Any(char.IsLower))
                {
                    kucukMu = true;
                }
                if (_pass.Any(char.IsDigit))
                {
                    rakamMi = true;
                }

                if (rakamMi == true && buyukMu == true && kucukMu == true)
                {
                    return "Güçlü Şifre..";
                }
                else if (rakamMi == true && buyukMu == true && kucukMu == false)
                {
                    return "Orta Şifre..";
                }
                else if (rakamMi == false && buyukMu == false && kucukMu == false)
                {
                    return "Zayıf Şifre..";
                }
                else
                {
                    return "Orta Şifre..";
                }
            }
            
        }
        private void btnQuestions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En az 6 karakter." +
                    "En az bir Rakam, bir Büyük Harf ve Küçük Harf Kullanın !");
        }
        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            lblDerece.Text = PassLevel(txtPassword1.Text);

            if (PassLevel(txtPassword1.Text) == "Zayıf Şifre..")
                lblDerece.ForeColor = Color.Red;
            else if (PassLevel(txtPassword1.Text) == "Orta Şifre..")
                lblDerece.ForeColor = Color.Orange;
            else if (PassLevel(txtPassword1.Text) == "Güçlü Şifre..")
                lblDerece.ForeColor = Color.Green;
        }
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (count == true)
            {
                txtPassword1.PasswordChar = '\0';
                txtPassword2.PasswordChar = '\0';
                count = false;
            }
            else if (count == false)
            {
                txtPassword1.PasswordChar = '*';
                txtPassword2.PasswordChar = '*';
                count = true;
            }
        }
        public string PasswordStrengthCheck(string password)
        {
            string passwordStrength = "";
            if (!string.IsNullOrEmpty(password) && password.Length >= 4)
            {
                if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsLetter) && password.Any(char.IsDigit) && password.Any(char.IsSymbol) && password.Length <= 6)
                {
                    passwordStrength = "Strong Password..";
                }
                else if (password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Length <= 4)
                {
                    passwordStrength = "Medium Password..";
                }
                else
                {
                    passwordStrength = "Weak Password..";
                }
            }
            return passwordStrength;
        }
    }
}
