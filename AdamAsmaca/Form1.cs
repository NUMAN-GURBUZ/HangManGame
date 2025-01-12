using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class KelımeGosterımı : DevExpress.XtraEditors.XtraForm
    {

        List<string> words =new List<string> 
        {
    "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin",
    "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
    "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan",
    "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul",
    "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir",
    "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş",
    "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas",
    "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"
        }; //oyunda kullanılacak olan kelimeleri tanımladık
        int DogruTahmin;//TAHMİN SAYISI İLE İLGİSİ TANIM YAPTIK
        Random random;//KELİMELERİN RASTGELE EKRANA ÇIKMASI İÇİN TANIMLANDI
        string SeciliKelime;//RANDOM OLARAK KULLANILAN KELİM BELİRLENMESİ   
        char[] GorunenKelıme;//BİRER BİRER KELİME GİRMESİNİ SAĞLAR
        

        public KelımeGosterımı()
        {
            InitializeComponent();//FORMUN GÖRSEL TASARIMINA YARAR
        }

        private void KelımeGosterımı_Load(object sender, EventArgs e)
        {
            DogruTahmin = 0;//TAHMİN SAYISI 0 DAN BAŞLASIN 
            random = new Random();//RANDOM TANIMLAMA
            SeciliKelime = words[random.Next(words.Count)];//OYUNA RASTGELE ŞEHİR TANIMLAMASI 
            GorunenKelıme = new string('_', SeciliKelime.Length).ToCharArray();//
           string GırılenGorünenKelime = string.Join(" ", GorunenKelıme);//
            KelimeGösterimi.Text = GırılenGorünenKelime;//EŞİTLİK DURUMUNDA CLASSLA ÇALIŞIR
        }

        private void GırısButtonu_Click(object sender, EventArgs e)
        {
            char Gırıs = KelimeGirisBox.Text.ToLower()[0];
            bool BoxDogruTahmin = false;
            for (int i = 0; i < SeciliKelime.Length; i++) //SEÇİLEN KELİMENİN GİRİLDİĞİNDE DEVAM ETMESİ SAĞLANIR
            {
                if (SeciliKelime[i]==Gırıs)//SEÇİLİ KELİME GİRİŞE EŞİTLENİR
                {
                    GorunenKelıme[i] = Gırıs;
                    BoxDogruTahmin = true;//HARF DOĞRU İSE TEKRAR DÖNER
                }
            }
            KelimeGösterimi.Text = string.Join(" ", GorunenKelıme);//DOĞRU KELİME YERİNİ ALIR
            if(!BoxDogruTahmin)//DOĞRU OLMADIĞINDA ÇALIŞIR
            {
                UpdateAdamAsmacaResım();//HATADA ADIM ADIM RESİMLER İŞLENİR
            }
            if(!KelimeGösterimi.Text.Contains('_'))//DOĞRU OLDUĞUNDA BLOG ÇALIŞIR
            {
                MessageBox.Show("TEBRİKLER! KAZANDINIZ");//KAZANANI GÖSTERİR
                Application.Restart();//OYUN TEKRARLANIR
            }


        }

        private void UpdateAdamAsmacaResım()//BU CLASS'DA HATA OLDUKÇA ADIM İLERLEYEREK KALAN HAKKI GÖSTERİR
        {
            DogruTahmin++;//OYUN DEVAM EDER
            switch(DogruTahmin)//TAHMİNİN YANLIŞ OLMASI DURUMUNDA CASE ADIM ADIM ÇALIŞIR
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._2;//1.HATADA GÖRSEL ORTAYA ÇIKAR 
                    break;//CASE YAPISINI DURDURUR
                case 2:
                    pictureBox1.Image = Properties.Resources._3;//2.HATADA GÖRSEL ORTAYA ÇIKAR 
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._4;//3.HATADA GÖRSEL ORTAYA ÇIKAR 
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._5;//4.HATADA GÖRSEL ORTAYA ÇIKAR 
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._6;//5.HATADA GÖRSEL ORTAYA ÇIKAR 
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._7;//6.HATADA GÖRSEL ORTAYA ÇIKAR 

                    MessageBox.Show("KAYBETTİNİZ TEKRAR DENEYİN");//EKRANA YAZI ÇIKAR OYUN BİTTİ DİYE
                    Application.Restart();//KAYBEDİNCE TEKRARDAN BAŞLAMASI İÇİN KULLANILDI
                    break;

                
            }
        }
        
    }
}
