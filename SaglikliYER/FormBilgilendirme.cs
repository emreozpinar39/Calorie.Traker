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
                case 0: lblBilgilendirme.Text = "SağlıklıYER Nedir? SağlıklıYER seni ideal kilona ve sağlıklı bir yaşama kavuşturmak için var olan ücretsiz bir diyet uygulamasıdır.Ayrıca YER ismi projenin kurucularının baş harfleri ile oluşturulmuştur. SağlıklıYER ile Gerçekten Kilo Verebilir Miyim?Elbette verebilirsin!Sen de projemizde bulunan Challange ekranından başarı hikayelerine göz atarak SağlıklıYER ile kilo verenleri görebilir, deneyimlerinden ilham alabilirsin. SağlıklıYER'e Nasıl Üye Olabilirim? Uygulama üzerinden üye olabilirsin. SağlıklıYER Ücretsiz Bir Uygulama mı? Evet, SağlıklıYER ücretsiz bir uygulama.Uygulamayı indirerek ücretsiz olarak yararlanabileceğin hizmetlerden bazıları şunlar: “Kaç Kalori” bölümünden besinlerin değerlerini ve kalorilerini sorgulama, “Kalori Takip”e yediğin besinleri ekleyerek aldığın kaloriyi takip etme, beslenme ve sağlıklı yaşam konularındaki güncel içerikleri takip etme, içtiğin su miktarını işaretleme ve takip etme.";break; 
                case 1: lblBilgilendirme.Text = "SağlıklıYER ekibi 3 kişiden oluşmaktaır. Uzman yazılımcıların bir araya gelerek oluşturmuş olduğu projemizin yazılımcı kadrosu; \nRezan Söylemez, \nYunus Emre Çakal, \nEmre Özpınar'dan oluşmaktadır.";break; 
                case 2: lblBilgilendirme.Text = "'Canan Karatay' diyeti olarak da tanımlanabilen Karatay diyeti, kilo vermek isteyen kadınların tercih ettiği en sağlıklı beslenme programlarından biridir. Hızlı ve sağlıksız yöntemlerle zayıflayıp kısa zamanda eski kilolarına yeniden dönen kadınlar tecrübe ettikleri bu olumsuz deneyimlerden sonra bir daha diyet yapmak istemeyebilir ve yaşadıkları hayal kırıklığı sonucunda mutsuz olabilir. Uzmanların açıklamalarına göre hem aç kalmayıp hem de doğal yollarla kilo vermek elbette mevcut. Sağlıklı beslenme dediğimizde akla ilk gelen isimlerden biri olan Canan Karatay, katıldığı programlarla sağlıklı zayıflamanın püf noktaları vermesinin yanı sıra sağlıksız yiyeceklerden uzak durarak sağlığımızı nasıl koruyabileceğimizi de bizlere aktarıyor. Gün içerisinde kolay kolay acıkmamızı sağlamayan tok tutucu besinlerin bir araya gelmesiyle oluşan Karatay diyeti sayesinde verdiğiniz kiloları geri almayıp kendinize sağlıklı bir beslenme rutini oluşturabileceksiniz. Her diyette olduğu gibi Karatay diyetinde de uymanız gereken bazı kurallar vardır. Sadece sağlıklı beslenmenin yeterli olmadığı aynı zamanda düzenli egzersiz hareketleri ile bunu destekleyebileceğiniz sıkı bir zayıflama programında en etkili sonucu almak için doktor kontrolü ile ilerlemelisiniz."; break; 
                case 3: lblBilgilendirme.Text = "Ketojenik diyet, tıpta öncelikle çocuklarda kontrol edilmesi zor yani refrakter epilepsiyi tedavi etmek için kullanılan yüksek yağlı besinler ile yeter miktarda protein içeren besinlerin öncelikli tüketildiği, düşük karbonhidratlı bir diyettir. Ketojenik diyetin halk arasındaki bir diğer adı da keto diyettir." +
                        " Ketojenik Diyette Yenilmesi Gereken Gıdalar Listesi " +
                        "Ketojenik diyet menüsü aşağıda listesi verilen et, balık, yumurta, tereyağı, fındık, sağlıklı yağlar, avokado ve bol miktarda düşük karbonhidratlı sebzeler gibi ürün gruplarına dayandırılmalıdır. Standart bir diyette yağ / protein yüzdeleri 75 ile 20 iken, yüksek proteinli ketojenik diyette bu oranlar yüzde 60 / 35 civarındadır. " +
                        "Düşük karbonhidratlı sebzeler: Çoğu yeşil olmak üzere, domates, soğan, biber gibi düşük karbonhidratlı sebzeleri tercih etmek önemlidir." +
                        "Et, balık, hindi eti, kırmızı et türleri ve tavuk eti: Bunlardan üretilmiş jambon, pastırma, salam ve sosis gibi ürünler ketojenik diyetin önemli bir kısmı olan proteinleri sağlar. Balık olarak özellikle omega-3 yağını bol miktarda içeren alabalık, hamsi, kefal, orkinoz, ringa, sazan, somon, ton balığı, uskumru ve yayın balığı gibi yağlı balık türleri tercih edilmelidir."; break; 
                case 4: lblBilgilendirme.Text = "saglikliyer@info.com mail adresinden 7/24 iletişime geçebilirsiniz"  +
                        "\nWhatsapp = 0532 111 11 11"  +
                        "\nInstagram = SaglikliYER"  +
                        "\nTwitter = SaglikliYER" 
                        ; break; 
                case 5:lblBilgilendirme.Text =
                    "Adres : Hüseyinağa Mah. İstiklal Cad. Saitpaşa Geçidi Çiçek Pasajı No:176, 34435 Beyoğlu/İstanbul";
                    pictureBox1.Visible = true; ;break; 
            }
        }
    }
}
