using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YerNTier.BLL.Services;
using YerNTier.Model.Entities;
using YerNTier.Model.Enums;

namespace SaglikliYER
{
    public partial class FormUrunEkleme : Form
    {
        FoodService foodService;
        public FormUrunEkleme()
        {
            InitializeComponent();
            foodService = new FoodService();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string filePath;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selID = Convert.ToInt32(listView1.SelectedItems[0].Tag);
                Food food = foodService.GetByFoodIdCheck(selID);
                food.FoodName = txtFoodName.Text;
                food.CategoryID = (int)cmbCategoryName.SelectedValue;
                food.Calorie = nudCalorie.Value;
                food.Protein = nudProtein.Value;
                foodService.Update(food);
                listviewDoldur();
                MessageBox.Show("Ürün değiştirme başarılı!");
                ClearItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFoodSave_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = new Food();
                food.FoodName = txtFoodName.Text;
                food.Calorie = nudCalorie.Value;
                food.Protein = nudProtein.Value;
                food.Portion = Portion.Gram;
                food.Quantity = 100;
                food.FoodImage = filePath;
                food.CategoryID = Convert.ToInt32(cmbCategoryName.SelectedValue); //seçilen kategorinin indexi tag de taşınır
                foodService.Insert(food);
                listviewDoldur();
                MessageBox.Show("Ürün kaydetme başarılı!");
                ClearItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormUrunEkleme_Load(object sender, EventArgs e)
        {
            CmbCategoryDoldur();
            listviewDoldur();
        }

        private void CmbCategoryDoldur()
        {
            List<FoodCategory> foodCategories = new List<FoodCategory>();
            foodCategories = foodService.GetFoodCategories();

            cmbCategoryName.DataSource = foodCategories;

            cmbCategoryName.DisplayMember = "CategoryName";
            cmbCategoryName.ValueMember = "FoodCategoryID";
        }

        private void listviewDoldur()
        {
            try
            {
                listView1.Items.Clear();

                List<Food> foods = new List<Food>();
                foods = foodService.GetFoodsCheck();
                ListViewItem lvi;
                foreach (var item in foods)
                {
                    lvi = new ListViewItem();
                    lvi.Tag = item.FoodID;
                    lvi.Text = item.FoodName;
                    lvi.SubItems.Add(item.Calorie.ToString());
                    lvi.SubItems.Add(item.Protein.ToString());
                    lvi.SubItems.Add(item.FoodCategory.CategoryName);

                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FoodCategory foodCategory = new FoodCategory();
                foodCategory.CategoryName = txtCategoryName2.Text;
                foodCategory.Description = txtDescription.Text;
                foodService.InsertFoodCategory(foodCategory);

                MessageBox.Show("Ürün kategori kaydetme başarılı!");
                CmbCategoryDoldur();
                ClearItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearItems()
        {
            txtFoodName.Text = "";
            txtDescription.Text = "";
            txtCategoryName2.Text = "";
            nudCalorie.Value = 0;
            nudProtein.Value = 0;
            cmbCategoryName.SelectedIndex = -1;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int selID = Convert.ToInt32(listView1.SelectedItems[0].Tag);
                Food food = foodService.GetByFoodIdCheck(selID);
                txtFoodName.Text = food.FoodName;
                cmbCategoryName.Text = food.FoodCategory.CategoryName;
                nudCalorie.Value = food.Calorie;
                nudProtein.Value = food.Protein;
                txtCategoryName2.Text = food.FoodCategory.CategoryName;
                txtDescription.Text = food.FoodCategory.Description;
                if (food.FoodImage != null) pbFood.Image = Image.FromFile(food.FoodImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Food food = new Food();
                food.FoodID = (int)listView1.SelectedItems[0].Tag;
                foodService.Delete(food);
                MessageBox.Show("Silme işlemi başarılı");
                listviewDoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFolderPath_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Choose food image";
                openFileDialog1.Filter = "image files (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg";
                filePath = openFileDialog1.InitialDirectory;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbFood.Image = Image.FromFile(openFileDialog1.FileName);
                    filePath = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
