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
    public partial class FormFeedMonster : Form
    {
        public FormFeedMonster()
        {
            InitializeComponent();
        }
        Random rnd;
        private void btnleft_Click(object sender, EventArgs e)
        {
            if (button1.Location.X == 0)
            {

            }
            else
            button1.Location = new Point(button1.Location.X - 50, 350);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (button1.Location.X == 700)
            {

            }
            else
            button1.Location = new Point(button1.Location.X + 50, 350);
        }

        int level = 100;
        private void FormFeedMonster_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Canavarı Besle Oyunumuza Hoşgeldiniz !! \n Oyunumuzun kuralları çok basit aşağıda" +
                " görüğün sağ, sol butonlarını kullanarak yemekleri yakala ve cana" +
                "varı doyur!! \n Hazır olduğunda Start butonuna basmayı unutma!!");

            button1.BringToFront();
            button1.Location = new Point(350, 350);
            rnd = new Random();
            button1.Enabled = false;
            timer1.Interval = level;
            pbBro.Location = new Point(1000, 1000);
            pbHam.Location = new Point(1000, 1000);
            pbHav.Location = new Point(1000, 1000);
            pbSos.Location = new Point(1000, 1000);

        }
        int skor = 0;
        int sayac2 = 0;
        int sayac;
        int urun;
        int sayac3 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) level = 750;
            else if (radioButton2.Checked) level = 500;
            else if (radioButton3.Checked) level = 250;

            sayac = 0;
            sayac2 = 0;
            sayac3 = 0;
            skor = 0;
            timer1.Interval = level;
            timer1.Start();
            label3.Visible = false;
            label4.Visible = false;
            groupBox1.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (sayac2 != 72)
            {
                sayac2++;
                if (sayac != 7)
                {
                    if (sayac3 == 0)
                    {
                        if (urun == 0) pbHam.Location = new Point(rnd.Next(0, 700), 0);
                        if (urun == 1) pbBro.Location = new Point(rnd.Next(0, 700), 0);
                        if (urun == 2) pbHav.Location = new Point(rnd.Next(0, 700), 0);
                        if (urun == 3) pbSos.Location = new Point(rnd.Next(0, 700), 0);

                        sayac3++;
                    }

                    if (urun == 0) pbHam.Location = new Point(pbHam.Location.X, pbHam.Location.Y + 50);
                    if (urun == 1) pbBro.Location = new Point(pbBro.Location.X, pbBro.Location.Y + 50);
                    if (urun == 2) pbHav.Location = new Point(pbHav.Location.X, pbHav.Location.Y + 50);
                    if (urun == 3) pbSos.Location = new Point(pbSos.Location.X, pbSos.Location.Y + 50);
                    sayac++;

                }
                else
                {
                    timer1.Stop();
                    sayac = 0;
                    if (urun == 0)
                    {
                        if (pbHam.Location.X - button1.Location.X <= 50 && pbHam.Location.X - button1.Location.X >= -50)
                        {
                            skor += 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                        else
                        {
                            skor -= 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                    }
                    else if (urun == 1)
                    {
                        if (pbBro.Location.X - button1.Location.X <= 50 && pbBro.Location.X - button1.Location.X >= -50)
                        {
                            skor += 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                        else
                        {
                            skor -= 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                    }
                    else if (urun == 2)
                    {
                        if (pbHav.Location.X - button1.Location.X <= 50 && pbHav.Location.X - button1.Location.X >= -50)
                        {
                            skor += 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                        else
                        {
                            skor -= 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                    }
                    else if (urun == 3)
                    {
                        if (pbSos.Location.X - button1.Location.X <= 50 && pbSos.Location.X - button1.Location.X >= -50)
                        {
                            skor += 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                        else
                        {
                            skor -= 100;
                            label2.Text = $"Your Score = {skor} ";
                        }
                    }
                    pbBro.Location = new Point(1000, 1000);
                    pbHam.Location = new Point(1000, 1000);
                    pbHav.Location = new Point(1000, 1000);
                    pbSos.Location = new Point(1000, 1000);
                    urun = rnd.Next(0, 4);
                    sayac3 = 0;
                    timer1.Start();
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Your Score = {skor}");
                label1.Text = ($"Best Score = {skor}");

                label3.Visible = true;
                label4.Visible = true;
                groupBox1.Visible = true;

            }
        }


        private void FormFeedMonster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                btnRight.PerformClick();
            }
            if (e.KeyCode == Keys.A)
            {
                btnleft.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
            }
        }
    }
}
