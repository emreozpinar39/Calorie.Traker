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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }
        MealService mealService;
        public FormReports(int _userID)
        {
            InitializeComponent();
            mealService = new MealService();
            userID = _userID;
        }
        int userID;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormReports_Load(object sender, EventArgs e)
        {
            List<Meal> meals = mealService.GetById(userID);
            listviewdoldur(meals);
            label3.Text = mealService.MostEatenFood();
        }
        void listviewdoldur(List<Meal> meals)
        {
            try
            {
                listView1.Items.Clear();
                ListViewItem lvi;
                foreach (Meal item in meals)
                {
                    foreach (var item2 in item.EatenFoods)
                    {
                        lvi = new ListViewItem();
                        lvi.Text = item.MealName;
                        lvi.SubItems.Add(item2.EatenFoodName);
                        lvi.SubItems.Add(item2.EatenPortion.ToString());
                        lvi.SubItems.Add(item2.EatenQuantity.ToString());
                        lvi.SubItems.Add(item2.EatenColorie.ToString());
                        lvi.SubItems.Add(item2.EatenProtein.ToString());
                        lvi.SubItems.Add(item.MealDate.ToString());

                        listView1.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGun_Click(object sender, EventArgs e)
        {
            try
            {
                List<Meal> meals = mealService.GetDailyByUserID(userID);
                lblTotCalorie.Text = mealService.DailyCalorie(userID).ToString();
                lblTotPro.Text = mealService.DailyProtein(userID).ToString();
                listviewdoldur(meals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnHafta_Click(object sender, EventArgs e)
        {
            try
            {
                List<Meal> meals = mealService.GetWeeklyByUserID(userID);
                lblTotCalorie.Text = mealService.WeeklyCalorie(userID).ToString();
                lblTotPro.Text = mealService.WeeklyProt(userID).ToString();
                listviewdoldur(meals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAy_Click(object sender, EventArgs e)
        {
            try
            {
                List<Meal> meals = mealService.GetMonthByUserID(userID);
                lblTotCalorie.Text = mealService.MonthlyCalorie(userID).ToString();
                lblTotPro.Text = mealService.MonthlyProtein(userID).ToString();
                listviewdoldur(meals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
