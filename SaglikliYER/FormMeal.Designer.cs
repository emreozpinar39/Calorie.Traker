
namespace SaglikliYER
{
    partial class FormMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeal));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMealDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMealSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.cmbPortion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Food = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoodUpdate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.Food.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnMealDelete);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.dtpMealDate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnMealSave);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 208);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Meal";
            // 
            // btnMealDelete
            // 
            this.btnMealDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMealDelete.BackgroundImage")));
            this.btnMealDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMealDelete.FlatAppearance.BorderSize = 0;
            this.btnMealDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealDelete.Location = new System.Drawing.Point(26, 106);
            this.btnMealDelete.Name = "btnMealDelete";
            this.btnMealDelete.Size = new System.Drawing.Size(75, 67);
            this.btnMealDelete.TabIndex = 18;
            this.btnMealDelete.UseVisualStyleBackColor = true;
            this.btnMealDelete.Click += new System.EventHandler(this.btnMealDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sabah",
            "Branç",
            "Öğle",
            "Ara Öğün",
            "Akşam"});
            this.comboBox1.Location = new System.Drawing.Point(107, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Location = new System.Drawing.Point(106, 61);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(140, 22);
            this.dtpMealDate.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Meal Name :";
            // 
            // btnMealSave
            // 
            this.btnMealSave.BackColor = System.Drawing.Color.Silver;
            this.btnMealSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMealSave.BackgroundImage")));
            this.btnMealSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMealSave.FlatAppearance.BorderSize = 0;
            this.btnMealSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMealSave.Location = new System.Drawing.Point(161, 106);
            this.btnMealSave.Name = "btnMealSave";
            this.btnMealSave.Size = new System.Drawing.Size(85, 67);
            this.btnMealSave.TabIndex = 15;
            this.btnMealSave.UseVisualStyleBackColor = false;
            this.btnMealSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Meal Date :";
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Silver;
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Location = new System.Drawing.Point(336, 133);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(85, 67);
            this.btnAddFood.TabIndex = 15;
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(615, 466);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.DecimalPlaces = 2;
            this.nudQuantity.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nudQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudQuantity.Location = new System.Drawing.Point(281, 90);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(140, 22);
            this.nudQuantity.TabIndex = 4;
            // 
            // cmbFood
            // 
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(281, 22);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(140, 24);
            this.cmbFood.TabIndex = 3;
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            // 
            // cmbPortion
            // 
            this.cmbPortion.FormattingEnabled = true;
            this.cmbPortion.Location = new System.Drawing.Point(281, 55);
            this.cmbPortion.Name = "cmbPortion";
            this.cmbPortion.Size = new System.Drawing.Size(140, 24);
            this.cmbPortion.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Food :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quantity :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Portion :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.ContextMenuStrip = this.contextMenuStrip2;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(173, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(569, 234);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Meal";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Food";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Portion";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MealDate";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Picture";
            this.columnHeader6.Width = 96;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // Food
            // 
            this.Food.Controls.Add(this.pictureBox1);
            this.Food.Controls.Add(this.nudQuantity);
            this.Food.Controls.Add(this.btnFoodUpdate);
            this.Food.Controls.Add(this.cmbPortion);
            this.Food.Controls.Add(this.btnAddFood);
            this.Food.Controls.Add(this.cmbFood);
            this.Food.Controls.Add(this.label13);
            this.Food.Controls.Add(this.label10);
            this.Food.Controls.Add(this.label11);
            this.Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Food.Location = new System.Drawing.Point(298, 252);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(444, 208);
            this.Food.TabIndex = 17;
            this.Food.TabStop = false;
            this.Food.Text = "Food";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoodUpdate
            // 
            this.btnFoodUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFoodUpdate.BackgroundImage")));
            this.btnFoodUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoodUpdate.FlatAppearance.BorderSize = 0;
            this.btnFoodUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodUpdate.Location = new System.Drawing.Point(184, 133);
            this.btnFoodUpdate.Name = "btnFoodUpdate";
            this.btnFoodUpdate.Size = new System.Drawing.Size(81, 67);
            this.btnFoodUpdate.TabIndex = 16;
            this.btnFoodUpdate.UseVisualStyleBackColor = true;
            this.btnFoodUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 212);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 22);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FormMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(754, 511);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBack);
            this.Name = "FormMeal";
            this.Text = "FormMeal";
            this.Load += new System.EventHandler(this.FormMeal_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.Food.ResumeLayout(false);
            this.Food.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.ComboBox cmbPortion;
        private System.Windows.Forms.DateTimePicker dtpMealDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox Food;
        private System.Windows.Forms.Button btnMealSave;
        private System.Windows.Forms.Button btnFoodUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.Button btnMealDelete;
    }
}