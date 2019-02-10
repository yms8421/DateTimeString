using System;
using System.Globalization;
using System.Windows.Forms;

namespace BilgeAdam.DatetimeString
{
    public partial class frmString : Form
    {
        public frmString()
        {
            InitializeComponent();
            txtText.Text = "Bana ne banA ne bana ne, benI al beni al onu alma.Hatta ondan al bana vEr.";
        }
        private void btnUpper_Click(object sender, EventArgs e)
        {
            rtbResult.Text = txtText.Text.ToUpper();
        }
        private void btnLower_Click(object sender, EventArgs e)
        {
            rtbResult.Text = txtText.Text.ToLower();
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            //IsNullOrEmpty --> farkına bak
            if (!string.IsNullOrWhiteSpace(txtHelper.Text))
            {
                rtbResult.Text = txtText.Text.Replace("bana", txtHelper.Text);
            }
        }
        private void btnTrim_Click(object sender, EventArgs e)
        {
            var text = "     Mustafa Kemal Atatürk      ";
            rtbResult.Text = text.Trim();
            //rtbResult.Text = text.TrimEnd();
            //rtbResult.Text = text.TrimStart();
        }
        private void btnLength_Click(object sender, EventArgs e)
        {
            rtbResult.Text = string.Format("İfadede {0} adet karakter vardır\n", txtText.Text.Length);
            rtbResult.Text += $"İfadede {txtText.Text.Length} adet karakter vardır\n";

            var vowels = new char[8] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            //for (int i = 0; i < txtText.Text.ToLower().Length; i++)
            //{
            //    var letter = txtText.Text[i];
            //}
            var vowelCount = 0;
            foreach (var letter in txtText.Text.ToLower(CultureInfo.GetCultureInfo(1055)))// Dil farklılıkları olursa türkçe esaslı harfleri küçült
            {
                if (Array.IndexOf(vowels, letter) > -1)
                {
                    vowelCount++;
                }
            }
            //var isim = "Deniz";
            //var yas = 22;
            //var tarih = DateTime.Now.ToString("dd MMMM yyyy");
            //var a = $"Merhaba benim adım {isim}, Yaşım {yas}, Bugün {tarih}";
            rtbResult.Text += $"İfadede {vowelCount} adet sesli harf vardır";
        }
        private void btnSubstring_Click(object sender, EventArgs e)
        {
            var text = "Mustafa Hamdi Seyfettin Kemal Atatürk ";
            text = text.Trim();
            var lastNameIndex = text.LastIndexOf(' ') + 1;
            rtbResult.Text = text.Substring(lastNameIndex, text.Length - lastNameIndex);

            //var isim = "201934834785 - Gamze İnşaat ve Sanayi - Ankara";
            //var lastDashIndex = isim.LastIndexOf('-') - 2;
            //isim = isim.Substring(15, lastDashIndex - 15);
        }
        private void btnPad_Click(object sender, EventArgs e)
        {
            var index = 903; //"00000000903"
            rtbResult.Text = index.ToString().PadLeft(10, '0');

            var ccn = "3454983409122179";
            var secret = ccn.Substring(0, 4).PadRight(16, '*');
            MessageBox.Show(secret);
        }
        private void btnSplit_Click(object sender, EventArgs e)
        {
            var company = "201934834785 - Gamze İnşaat ve Sanayi - Ankara";
            var values = company.Split('-');

            var comp = new Company();
            comp.LicenseNo = values[0].Trim();
            comp.Name = values[1].Trim();
            comp.City = values[2].Trim();
            /*
             0: "201934834785 "
             1: " Gamze İnşaat ve Sanayi "
             2: " Ankara"
             */
            var wordsCount = 0;
            var parts = txtText.Text.Split(' ', '.', ',');
            foreach (var part in parts)
            {
                if (!string.IsNullOrEmpty(part))
                {
                    wordsCount++;
                }
            }
            rtbResult.Text = $"İfadede {wordsCount} adet kelime bulunmuştur";
        }
        private void btnEndStart_Click(object sender, EventArgs e)
        {
            var mail = txtHelper.Text;
            //Regex
            //StartsWith
            if (txtHelper.Text.EndsWith(".gov.tr"))
            {
                MessageBox.Show("Vatandaş ama Bakanlık personeli");
            }
            else
            {
                MessageBox.Show("Sade vatandaş");
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            rtbResult.Text = txtText.Text.Remove(20, 10);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //rtbResult.Text = txtText.Text.Insert(5, "Can PERK");
            var textToRemove = "bana";
            var placeIndex = txtText.Text.LastIndexOf(textToRemove);
            var text = txtText.Text.Remove(placeIndex, textToRemove.Length);
            rtbResult.Text = text.Insert(placeIndex, "Can PERK'e");


            /*
             * 
             * Mustafa Kemal Atatürk
             * substr(0,15) + " Can " + substr(15)
             * */
        }
    }

    class Company
    {
        public string LicenseNo;
        public string Name;
        public string City;
    }
}
