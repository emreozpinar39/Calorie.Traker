
namespace SaglikliYER
{
    partial class FormUrunEkleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunEkleme));
            this.btnFoodSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFolderPath = new System.Windows.Forms.Button();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudCalorie = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategoryName = new System.Windows.Forms.ComboBox();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryName2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFoodSave
            // 
            this.btnFoodSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFoodSave.BackgroundImage")));
            this.btnFoodSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoodSave.FlatAppearance.BorderSize = 0;
            this.btnFoodSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodSave.Location = new System.Drawing.Point(223, 150);
            this.btnFoodSave.Name = "btnFoodSave";
            this.btnFoodSave.Size = new System.Drawing.Size(36, 35);
            this.btnFoodSave.TabIndex = 10;
            this.btnFoodSave.UseVisualStyleBackColor = true;
            this.btnFoodSave.Click += new System.EventHandler(this.btnFoodSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Food Picture :";
            // 
            // btnFolderPath
            // 
            this.btnFolderPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolderPath.BackgroundImage")));
            this.btnFolderPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolderPath.FlatAppearance.BorderSize = 0;
            this.btnFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderPath.Location = new System.Drawing.Point(162, 150);
            this.btnFolderPath.Name = "btnFolderPath";
            this.btnFolderPath.Size = new System.Drawing.Size(38, 35);
            this.btnFolderPath.TabIndex = 8;
            this.btnFolderPath.UseVisualStyleBackColor = true;
            this.btnFolderPath.Click += new System.EventHandler(this.btnFolderPath_Click);
            // 
            // nudProtein
            // 
            this.nudProtein.Location = new System.Drawing.Point(136, 124);
            this.nudProtein.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(146, 22);
            this.nudProtein.TabIndex = 7;
            // 
            // nudCalorie
            // 
            this.nudCalorie.Location = new System.Drawing.Point(136, 93);
            this.nudCalorie.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCalorie.Name = "nudCalorie";
            this.nudCalorie.Size = new System.Drawing.Size(146, 22);
            this.nudCalorie.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Protein :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calorie :";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(136, 64);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(146, 22);
            this.txtFoodName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Food Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCategoryName);
            this.groupBox1.Controls.Add(this.btnFoodSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnFolderPath);
            this.groupBox1.Controls.Add(this.nudProtein);
            this.groupBox1.Controls.Add(this.nudCalorie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFoodName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food/per100gr";
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(136, 37);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(146, 24);
            this.cmbCategoryName.TabIndex = 4;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCategory.BackgroundImage")));
            this.btnSaveCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCategory.FlatAppearance.BorderSize = 0;
            this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCategory.Location = new System.Drawing.Point(244, 150);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(36, 35);
            this.btnSaveCategory.TabIndex = 12;
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Category Name :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(135, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(145, 77);
            this.txtDescription.TabIndex = 0;
            // 
            // txtCategoryName2
            // 
            this.txtCategoryName2.Location = new System.Drawing.Point(135, 34);
            this.txtCategoryName2.Name = "txtCategoryName2";
            this.txtCategoryName2.Size = new System.Drawing.Size(145, 22);
            this.txtCategoryName2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveCategory);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.txtCategoryName2);
            this.groupBox3.Location = new System.Drawing.Point(313, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 202);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CategoryName";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Protein";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calorie";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FoodName";
            this.columnHeader1.Width = 88;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(390, 174);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 50);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(500, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 56);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pbFood
            // 
            this.pbFood.Location = new System.Drawing.Point(390, 19);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(185, 143);
            this.pbFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFood.TabIndex = 15;
            this.pbFood.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(356, 208);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBack);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.pbFood);
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Location = new System.Drawing.Point(6, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(597, 245);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Food";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 482);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adding Group";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUrunEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(639, 502);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormUrunEkleme";
            this.Text = "FormUrunEkleme";
            this.Load += new System.EventHandler(this.FormUrunEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFoodSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFolderPath;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudCalorie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCategoryName2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCategoryName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}