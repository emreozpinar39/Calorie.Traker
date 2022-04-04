using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikliYER
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        int userID;
        public FormMain(int _userID)
        {
            InitializeComponent();
            userID = _userID;
        }

        private void btnDrinkWater_Click(object sender, EventArgs e)
        {
            FormSuEkleme suEkleme = new FormSuEkleme(userID);
            suEkleme.ShowDialog();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FormUrunEkleme urunEkleme = new FormUrunEkleme();
            urunEkleme.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FormKalHesaplama kalHesaplama = new FormKalHesaplama();
            kalHesaplama.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports reports = new FormReports(userID);
            reports.ShowDialog();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            FormMeal meal = new FormMeal(userID);
            meal.ShowDialog();
        }

        private void btnChallange_Click(object sender, EventArgs e)
        {
            FormChallange challange = new FormChallange(userID);
            challange.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
        }

        private void btnNotif_Click(object sender, EventArgs e)
        {
            FormNotification notification = new FormNotification(userID);
            notification.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings(userID);
            formSettings.ShowDialog();
        }

        private void btnOyun_Click(object sender, EventArgs e)
        {
            FormTicTacToe formTicTacToe = new FormTicTacToe();
            formTicTacToe.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormFeedMonster formFeedMonster = new FormFeedMonster();
            formFeedMonster.ShowDialog();
        }
    }
}
