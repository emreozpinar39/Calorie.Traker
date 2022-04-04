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
    public partial class FormKalHesaplama : Form
    {
        FoodService foodService;
        public FormKalHesaplama()
        {
            InitializeComponent();
            foodService = new FoodService();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFindingFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.Clear();

                List<Food> foodList = foodService.GetFoodsByTextCheck(txtFindingFood.Text);
                foreach (Food item in foodList)
                {
                    ListViewItem listview = new ListViewItem();
                    listview.Tag = item.FoodID;
                    listview.Text = item.FoodName;
                    listview.SubItems.Add(item.FoodCategory.CategoryName);
                    listview.SubItems.Add(item.Calorie.ToString());
                    listview.SubItems.Add(item.Protein.ToString());
                    listView1.Items.Add(listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormKalHesaplama_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<Food> foodList = foodService.GetFoodsCheck();
            foreach (Food item in foodList)
            {
                ListViewItem listview = new ListViewItem();
                listview.Tag = item.FoodID;
                listview.Text = item.FoodName;
                listview.SubItems.Add(item.FoodCategory.CategoryName);
                listview.SubItems.Add(item.Calorie.ToString());
                listview.SubItems.Add(item.Protein.ToString());
                listView1.Items.Add(listview);
            }
        }
    }
}
