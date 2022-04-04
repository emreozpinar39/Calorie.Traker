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
    public partial class FormTicTacToe : Form
    {
        //true "X" false "O"
        bool turn = true;
        int turnCount = 0,count=0;
        UserInfoService userInfoService;
        public FormTicTacToe()
        {
            InitializeComponent();
            userInfoService = new UserInfoService();
        }
        public FormTicTacToe(int _userID)
        {
            InitializeComponent();
            userInfoService = new UserInfoService();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Öncelikle rakibinizden gelen teklifi kabul etmelisin. " +
                "Eğer teklifi kabul ettiysen bir hamle yap ve kendi sembolün ile oynamaya başla." +
                "Şimdi rakibinde sıra. Hamle yapmasını bekle bunu tekrarla challenge'in kazananı programın belirlemesine izin ver.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void button_click(object sender, EventArgs e)
        //{
        //    UserInfo userInfo = new UserInfo(); 
        //    Button button = (Button)sender;
        //    if (turn)
        //    {
        //        button.Text = "X";
        //        userInfo.YourTurn = "X";
        //        userInfoService.AddMess(userInfo);
        //    }
        //    else
        //    {
        //        button.Text = "O";
        //        userInfo.YourTurn = "O";
        //        userInfoService.AddMess(userInfo);
        //    }
        //    turn =!turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
        //    button.Enabled = false;
        //    //turnCount++;
        //    CheckWin();
        //}
        string win="";
        void CheckWin()
        {
            foreach (Control item in Controls)
            {
                bool winner = false;
                if ((btnX1.Text == btnX2.Text) && (btnX2.Text == btnX3.Text)&&(!btnX1.Enabled))
                    winner = true;
                else if ((btnZ1.Text == btnZ2.Text) && (btnZ2.Text == btnZ3.Text) && (!btnZ1.Enabled))
                    winner = true;
                else if ((btnY1.Text == btnY2.Text) && (btnY2.Text == btnY3.Text) && (!btnY1.Enabled))
                    winner = true;

                else if ((btnX1.Text == btnZ1.Text) && (btnZ1.Text == btnY1.Text) && (!btnX1.Enabled))
                    winner = true;
                else if ((btnX2.Text == btnZ2.Text) && (btnZ2.Text == btnY2.Text) && (!btnX2.Enabled))
                    winner = true;
                else if ((btnX3.Text == btnX3.Text) && (btnZ3.Text == btnY3.Text) && (!btnX3.Enabled))
                    winner = true;

                else if ((btnX1.Text == btnY2.Text) && (btnY2.Text == btnZ3.Text) && (!btnX1.Enabled))
                    winner = true;
                else if ((btnX3.Text == btnY2.Text) && (btnY2.Text == btnZ1.Text) && (!btnY1.Enabled))
                    winner = true;

                
            }
            //if (winner)
            //{
            //    ButtonDis();
            //    if (turn)
            //        win = "O";
            //    else
            //        win = "X";
            //    // MessageBox.Show(win+" Wins");
            //}
            //else
            //{
            //    //if (turnCount==9)
            //    //{
            //    //    MessageBox.Show("Fail!");
            //    //}
            //}
        }
        void ButtonDis()
        {
            try
            {
                foreach (Control item in Controls)
                {
                    Button button = (Button)item;
                    button.Enabled = false;
                }
            }
            catch (Exception)
            {
                
            }
        }
        string a = "";
        char[] char1;

        private void FormTicTacToe_Load(object sender, EventArgs e)
        {
            GetTurn();
        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);


            if (count < 2)
            {
                if (turn)
                {
                    TicTac ticTac1 = new TicTac();
                    ticTac1.YourTurn = "XX1";
                    ticTac1.DUserID = 1;
                    userInfoService.UpdateTicTac(ticTac1);

                    //btnX1.Text = "X";
                    //ticTac.YourTurn = "XX1";
                }
                else
                {
                    btnX1.Text = "O";
                    ticTac.YourTurn = "OX1";
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnX1.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();


        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);

            if (count <2)
            {
                if (turn)
                {
                    TicTac ticTac1 = new TicTac();
                    ticTac1.YourTurn = "XX1";
                    ticTac1.DUserID = 1;
                    userInfoService.UpdateTicTac(ticTac1);

                    //btnX2.Text = "X";
                    //ticTac.YourTurn = "XX2";
                }
                else
                {
                    btnX2.Text = "O";
                    ticTac.YourTurn = "OX2";
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnX2.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);

            if (count<2)
            {
                if (turn)
                {
                    btnX3.Text = "X";
                    ticTac.YourTurn = "XX3";
               
                }
                else
                {
                    btnX3.Text = "O";
                    ticTac.YourTurn = "OX3";                    
 
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnX3.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }

        private void btnY2_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);

            if (count<2)
            {
                if (turn)
                {
                    btnY2.Text = "X";
                    ticTac.YourTurn = "XY2";                    
     
                }
                else
                {
                    btnY2.Text = "O";
                    ticTac.YourTurn = "OY2";                   
 
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnY2.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }

        private void btnY1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);

            if (count<2)
            {
                if (turn)
                {
                    btnY1.Text = "X";
                    ticTac.YourTurn = "XY1";
      
                }
                else
                {
                    btnY1.Text = "O";
                    ticTac.YourTurn = "OY1";
 
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnY1.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }

        private void btnY3_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);

            if (count<2)
            {
                if (turn)
                {
                    btnY3.Text = "X";
                    ticTac.YourTurn = "XY3";
 
                }
                else
                {
                    btnY3.Text = "O";
                    ticTac.YourTurn = "OY3";
 
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnY3.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }

        private void btnZ1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);

            if (count <2)
            {
                if (turn)
                {
                    btnZ1.Text = "X";
                    ticTac.YourTurn = "XZ1";            
 
                }
                else
                {
                    btnZ1.Text = "O";
                    ticTac.YourTurn = "OZ1";   
 
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnZ1.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }

        private void btnZ2_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);

            if (count<2)
            {
                if (turn)
                {
                    btnZ2.Text = "X";
                    ticTac.YourTurn = "XZ2";    
 
                }
                else
                {
                    btnZ2.Text = "O";
                    ticTac.YourTurn = "OZ2";
 
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnZ2.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }
        private void btnZ3_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            count++;
            TicTac ticTac = userInfoService.FindByID(1);
            if (count < 2)
            {
                if (turn)
                {
                    btnZ3.Text = "X";
                    ticTac.YourTurn = "XZ3";
                }
                else
                {
                    btnZ3.Text = "O";
                    ticTac.YourTurn = "OZ3";
                }
                turn = !turn; //Yapılan turn işlem (X,O) seçiminin zıt hareketini yapmak için kullanılan 
                btnZ3.Enabled = false;
                //turnCount++;
                CheckWin();
            }
            else ButtonFalse();
        }
        void ButtonFalse()
        {
            btnX1.Enabled = false;
            btnX2.Enabled = false;
            btnX3.Enabled = false;
            btnY1.Enabled = false;
            btnY2.Enabled = false;
            btnY3.Enabled = false;
            btnZ1.Enabled = false;
            btnZ2.Enabled = false;
            btnZ3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetTurn(); 

        }
        void GetTurn()
        {
            TicTac ticTac = userInfoService.GetTicTac(1);
            a = ticTac.YourTurn;
            if (a == "XX1")
            {
                btnX1.Text = "X";
                btnX1.Enabled = false;
            }
            else if (a == "XX2")
            {
                btnX2.Text = "X";
                btnX2.Enabled = false;
            }
            else if (a == "XX3")
            {
                btnX3.Text = "X";
                btnX3.Enabled = false;
            }
            else if (a == "XY1")
            {
                btnY1.Text = "X";
                btnY1.Enabled = false;
            }
            else if (a == "XY2")
            {
                btnY2.Text = "X";
                btnY2.Enabled = false;
            }
            else if (a == "XY3")
            {
                btnY3.Text = "X";
                btnY3.Enabled = false;
            }
            else if (a == "XZ1")
            {
                btnZ1.Text = "X";
                btnZ1.Enabled = false;
            }
            else if (a == "XZ2")
            {
                btnZ2.Text = "X";
                btnZ2.Enabled = false;
            }
            else if (a == "XZ3")
            {
                btnZ3.Text = "X";
                btnZ3.Enabled = false;
            }

            if (a == "OX1")
            {
                btnX1.Text = "O";
                btnX1.Enabled = false;
            }
            else if (a == "OX2")
            {
                btnX2.Text = "O";
                btnX2.Enabled = false;
            }
            else if (a == "OX3")
            {
                btnX3.Text = "O";
                btnX3.Enabled = false;
            }
            else if (a == "OY1")
            {
                btnY1.Text = "O";
                btnY1.Enabled = false;
            }
            else if (a == "OY2")
            {
                btnY2.Text = "O";
                btnY2.Enabled = false;
            }
            else if (a == "OY3")
            {
                btnY3.Text = "O";
                btnY3.Enabled = false;
            }
            else if (a == "OZ1")
            {
                btnZ1.Text = "O";
                btnZ1.Enabled = false;
            }
            else if (a == "OZ2")
            {
                btnZ2.Text = "O";
                btnZ2.Enabled = false;
            }
            else if (a == "OZ3")
            {
                btnZ3.Text = "O";
                btnZ3.Enabled = false;
            }
        }
       
    }
}
