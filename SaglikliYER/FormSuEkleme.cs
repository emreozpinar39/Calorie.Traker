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
    public partial class FormSuEkleme : Form
    {
        WaterService waterService;
        UserDatailsServece UserDatailsServece;
        public FormSuEkleme()
        {
            InitializeComponent();
            waterService = new WaterService();
        }
        public FormSuEkleme(int dUserID)
        {
            InitializeComponent();
            waterService = new WaterService();
            UserDatailsServece = new UserDatailsServece();
            userID = dUserID;
        }
        int userID ;
        private void btnBack_Click(object sender, EventArgs e)
        {
            //içilen suyu database gönderir
            try
            {
                int _quantity = Convert.ToInt32(txtDrunkWater.Text);
                waterService.UpdateQuantity(userID, _quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void FormSuEkleme_Load(object sender, EventArgs e)
        {
            UserDetail userDetail = UserDatailsServece.GetUserDetailByID(userID);
            
            //database deki daha önce içtiği suyu getirir
            try
            {
                txtDrunkWater.Text= waterService.WaterQuantity(userID).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //girilen kg ye göre içmesi gereken suyu yazdırır
            if (userDetail.Weight<50)
            {
                txtWater.Text = "1800";
            }
            else if (userDetail.Weight >= 50 && userDetail.Weight < 60)
            {
                txtWater.Text = "2100";
            }
            else if (userDetail.Weight >= 60 && userDetail.Weight < 70)
            {
                txtWater.Text = "2400";
            }
            else if (userDetail.Weight >= 70 && userDetail.Weight < 80)
            {
                txtWater.Text = "2700";
            }
            else if (userDetail.Weight >= 80 && userDetail.Weight < 90)
            {
                txtWater.Text = "3000";
            }
            else if (userDetail.Weight >= 90 && userDetail.Weight < 100)
            {
                txtWater.Text = "3300";
            }
            else if (userDetail.Weight >= 100 && userDetail.Weight < 110)
            {
                txtWater.Text = "3600";
            }
            else
            {
                txtWater.Text = "3900";
            }

            //daha önce içilmiş sua göre butonu görünmez yapma
            if (Convert.ToInt32(txtDrunkWater.Text) - 300 >= 0) button1.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 600 >= 0) button2.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 900 >= 0) button3.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 1200 >= 0) button4.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 1500 >= 0) button5.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 1800 >= 0) button6.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 2100 >= 0) button7.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 2400 >= 0) button8.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 2700 >= 0) button9.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 3000 >= 0) button10.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 3300 >= 0) button11.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 3600 >= 0) button12.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 3900 >= 0) button13.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 4200 >= 0) button14.Visible = false;
            if (Convert.ToInt32(txtDrunkWater.Text) - 4500 >= 0)
            {
                button15.Visible = false;
                MessageBox.Show("Bugün yeterince su içtin !! Yoksa su zehirlenmesi olabilirsin Allah Muhafaza !! ");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button13.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button14.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDrunkWater.Text = (Convert.ToInt32(txtDrunkWater.Text) + 300).ToString();
            button15.Visible = false;           
        }
    }
}
