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
    public partial class FormBilgilendirme : Form
    {
        public FormBilgilendirme()
        {
            InitializeComponent();
        }
        public FormBilgilendirme(int _type)
        {
            InitializeComponent();
            type = _type;
        }
        int type;
        
    private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBilgilendirme_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            switch (type)
            {
                case 0:
                    lblBilgilendirme.Text = "SağlıklıYER ? SağlıklıYER is a free diet application that helps you to reach your ideal weight and healthy life " +
                    "The 'YER' letters represents initials of the the founders names of this program" +
                    " Can I really lose weight with SağlıklıYER? " +
                    "?Of course you can!" +
                    "By looking at the Challange page you can see the user success stories who are using SağlıklıYER and get inspiration from their experiences How can I sign up to SağlıklıYER? " +
                    "You can sign up through the application. You will get services after downloading the application as:" +
                    "From “How much calorie” section finding foods neutrient values " +
                    ", Adding foods you eat to “Follow-up calorie”" +
                    "seeing the calorie you have been taken, following contents containing diets" +
                    ", following the amount of water"; break;
                case 1:
                    lblBilgilendirme.Text = "SağlıklıYER team is composed of three people." +
                    "Talented software developers who come together to create this project are; \nRezan Söylemez, " +
                    "\nYunus Emre Çakal (Esra's love <3), \nEmre Özpınar"; break;
                case 2:
                    lblBilgilendirme.Text = "The Karatay diet, which can also be defined as the 'Canan Karatay' " +
                    "diet, is one of the healthiest nutrition programs preferred by women who want to lose weight. " +
                    "Women who lose weight with fast and unhealthy methods and return to their old weight in a short " +
                    "time may not want to diet again after these negative experiences and may be unhappy as a result " +
                    "of their disappointment. According to the statements of experts, it is of course possible to lose " +
                    "weight naturally and not be hungry. Canan Karatay, one of the first names that comes to mind when " +
                    "we talk about healthy nutrition, not only gives tips on how to lose weight in a healthy way, but " +
                    "also tells us how we can protect our health by avoiding unhealthy foods. Thanks to the Karatay " +
                    "diet, which is formed by the combination of satiating foods that do not make us hungry easily " +
                    "during the day, you will be able to create a healthy nutrition routine for yourself without " +
                    "regaining the weight you have lost. As in every diet, there are some rules that you must follow " +
                    "in the Karatay diet. In order to get the most effective results in a strict weight loss program, " +
                    "where not only a healthy diet is sufficient, but you can also support this with regular exercise " +
                    "movements, you should proceed with a doctor's control."; break;
                case 3:
                    lblBilgilendirme.Text = "The ketogenic diet is a low-carbohydrate diet in which high-fat foods and foods containing " +
                    "sufficient protein are primarily used to treat refractory epilepsy, which is difficult to control in medicine primarily " +
                    "in children. Another name for the ketogenic diet among the people is the keto diet.List of Foods to Eat on the Ketogenic DietThe ketogenic diet menu should be based on the product groups listed below, such as meat, fish, eggs, butter, nuts, healthy " +
                    "fats, avocados, and lots of low - carb vegetables.Fat / protein percentages are 75 to 20 on a standard diet, while on a high-" +
                    "protein ketogenic diet these are It s around 60/35 percent." +
                    "Low-carb vegetables: It's important to choose low-carb vegetables, mostly greens, like tomatoes, onions, peppers." +
                    "Meat, fish, turkey meat, red meat types and chicken meat: Products such as ham, bacon, salami and sausage produced from these " +
                    "provide proteins, which are an important part of the ketogenic diet. As fish, especially trout, anchovy, mullet, which contain " +
                    "plenty of omega-3 fats. Oily fish species such as tuna, herring, carp, salmon, tuna, mackerel and catfish should be preferred."; break;
                case 4:
                    lblBilgilendirme.Text = "saglikliyer@info.com you can contact us 24/7 via email adress." +
                    "\nWhatsapp = 0532 111 11 11" +
                    "\nInstagram = SaglikliYER" +
                    "\nTwitter = SaglikliYER"
                    ; break;
                case 5:
                    lblBilgilendirme.Text =
                    "Adress : Hüseyinağa Mah. İstiklal Cad. Saitpaşa Geçidi Çiçek Pasajı No:176, 34435 Beyoğlu/İstanbul";
                    pictureBox1.Visible = true; ; break;
            }
        }
    }
}
