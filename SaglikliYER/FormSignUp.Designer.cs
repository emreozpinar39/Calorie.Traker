
namespace SaglikliYER
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.btnBack = new System.Windows.Forms.Button();
            this.numKilo = new System.Windows.Forms.NumericUpDown();
            this.numBoy = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDerece = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnQuestions = new System.Windows.Forms.Button();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioWoman = new System.Windows.Forms.RadioButton();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.radioToBeFit = new System.Windows.Forms.RadioButton();
            this.radioGain = new System.Windows.Forms.RadioButton();
            this.radioKeep = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 473);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 37);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numKilo
            // 
            this.numKilo.DecimalPlaces = 2;
            this.numKilo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numKilo.Location = new System.Drawing.Point(110, 136);
            this.numKilo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numKilo.Name = "numKilo";
            this.numKilo.Size = new System.Drawing.Size(79, 22);
            this.numKilo.TabIndex = 6;
            // 
            // numBoy
            // 
            this.numBoy.DecimalPlaces = 2;
            this.numBoy.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numBoy.Location = new System.Drawing.Point(110, 100);
            this.numBoy.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numBoy.Name = "numBoy";
            this.numBoy.Size = new System.Drawing.Size(79, 22);
            this.numBoy.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.numKilo);
            this.groupBox3.Controls.Add(this.numBoy);
            this.groupBox3.Controls.Add(this.dateTimeBirth);
            this.groupBox3.Controls.Add(this.txtSurname);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 202);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Details";
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(110, 169);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(125, 22);
            this.dateTimeBirth.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(110, 63);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(125, 22);
            this.txtSurname.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Birth Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Weight :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 22);
            this.txtName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Height :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "SurName :";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(110, 97);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(245, 22);
            this.txtPassword2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblDerece);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.btnShowPass);
            this.groupBox2.Controls.Add(this.btnQuestions);
            this.groupBox2.Controls.Add(this.txtPassword2);
            this.groupBox2.Controls.Add(this.txtPassword1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 152);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(54, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Şifre Zorluk Derecesi :";
            // 
            // lblDerece
            // 
            this.lblDerece.AutoSize = true;
            this.lblDerece.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDerece.Location = new System.Drawing.Point(195, 126);
            this.lblDerece.Name = "lblDerece";
            this.lblDerece.Size = new System.Drawing.Size(0, 13);
            this.lblDerece.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.Silver;
            this.btnShowPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowPass.BackgroundImage")));
            this.btnShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPass.FlatAppearance.BorderSize = 0;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.Location = new System.Drawing.Point(345, 59);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(27, 27);
            this.btnShowPass.TabIndex = 13;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnQuestions
            // 
            this.btnQuestions.BackColor = System.Drawing.Color.Silver;
            this.btnQuestions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuestions.BackgroundImage")));
            this.btnQuestions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuestions.FlatAppearance.BorderSize = 0;
            this.btnQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestions.Location = new System.Drawing.Point(310, 124);
            this.btnQuestions.Name = "btnQuestions";
            this.btnQuestions.Size = new System.Drawing.Size(30, 17);
            this.btnQuestions.TabIndex = 13;
            this.btnQuestions.UseVisualStyleBackColor = false;
            this.btnQuestions.Click += new System.EventHandler(this.btnQuestions_Click);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(110, 61);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(223, 22);
            this.txtPassword1.TabIndex = 0;
            this.txtPassword1.TextChanged += new System.EventHandler(this.txtPassword1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(207, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioWoman);
            this.groupBox1.Controls.Add(this.radioMan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(13, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 77);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioWoman
            // 
            this.radioWoman.AutoSize = true;
            this.radioWoman.Location = new System.Drawing.Point(107, 32);
            this.radioWoman.Name = "radioWoman";
            this.radioWoman.Size = new System.Drawing.Size(78, 20);
            this.radioWoman.TabIndex = 2;
            this.radioWoman.TabStop = true;
            this.radioWoman.Text = "Woman";
            this.radioWoman.UseVisualStyleBackColor = true;
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Location = new System.Drawing.Point(265, 32);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(55, 20);
            this.radioMan.TabIndex = 2;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "Man";
            this.radioMan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(296, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 61);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioToBeFit
            // 
            this.radioToBeFit.AutoSize = true;
            this.radioToBeFit.Location = new System.Drawing.Point(12, 42);
            this.radioToBeFit.Name = "radioToBeFit";
            this.radioToBeFit.Size = new System.Drawing.Size(89, 20);
            this.radioToBeFit.TabIndex = 0;
            this.radioToBeFit.TabStop = true;
            this.radioToBeFit.Text = "To Be Fit";
            this.radioToBeFit.UseVisualStyleBackColor = true;
            // 
            // radioGain
            // 
            this.radioGain.AutoSize = true;
            this.radioGain.Location = new System.Drawing.Point(12, 94);
            this.radioGain.Name = "radioGain";
            this.radioGain.Size = new System.Drawing.Size(110, 20);
            this.radioGain.TabIndex = 0;
            this.radioGain.TabStop = true;
            this.radioGain.Text = "Gain Weight";
            this.radioGain.UseVisualStyleBackColor = true;
            // 
            // radioKeep
            // 
            this.radioKeep.AutoSize = true;
            this.radioKeep.Location = new System.Drawing.Point(12, 144);
            this.radioKeep.Name = "radioKeep";
            this.radioKeep.Size = new System.Drawing.Size(83, 20);
            this.radioKeep.TabIndex = 0;
            this.radioKeep.TabStop = true;
            this.radioKeep.Text = "Keep Fit";
            this.radioKeep.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioToBeFit);
            this.groupBox4.Controls.Add(this.radioKeep);
            this.groupBox4.Controls.Add(this.radioGain);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(266, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 202);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Your Goals";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(404, 531);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            ((System.ComponentModel.ISupportInitialize)(this.numKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBoy)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numKilo;
        private System.Windows.Forms.NumericUpDown numBoy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuestions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioWoman;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDerece;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.RadioButton radioKeep;
        private System.Windows.Forms.RadioButton radioGain;
        private System.Windows.Forms.RadioButton radioToBeFit;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}