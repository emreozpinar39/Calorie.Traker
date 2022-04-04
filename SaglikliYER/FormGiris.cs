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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnSesAc_Click(object sender, EventArgs e)
        {
           
        }
        
        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp signUp = new FormSignUp();
            signUp.ShowDialog();
        }

        private void btnKacKalori_Click(object sender, EventArgs e)
        {
            FormKalHesaplama kalHesaplama = new FormKalHesaplama();
            kalHesaplama.ShowDialog();
        }

        private void smSaglikliYer_Click(object sender, EventArgs e)
        {
            FormBilgilendirme bilgilendirme = new FormBilgilendirme(0);
            bilgilendirme.ShowDialog();
        }

        private void smEkibimiz_Click(object sender, EventArgs e)
        {
            FormBilgilendirme bilgilendirme = new FormBilgilendirme(1);
            bilgilendirme.ShowDialog();
        }

        private void msKaratay_Click(object sender, EventArgs e)
        {
            FormBilgilendirme bilgilendirme = new FormBilgilendirme(2);
            bilgilendirme.ShowDialog();
        }

        private void msKetojenik_Click(object sender, EventArgs e)
        {
            FormBilgilendirme bilgilendirme = new FormBilgilendirme(3);
            bilgilendirme.ShowDialog();
        }

        private void msIletisim_Click(object sender, EventArgs e)
        {
            FormBilgilendirme bilgilendirme = new FormBilgilendirme(4);
            bilgilendirme.ShowDialog();
        }

        private void msKonum_Click(object sender, EventArgs e)
        {
            FormBilgilendirme bilgilendirme = new FormBilgilendirme(5);
            bilgilendirme.ShowDialog();
        }
    }
}
