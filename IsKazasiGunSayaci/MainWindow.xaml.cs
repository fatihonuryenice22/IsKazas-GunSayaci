using IsKazasiGunSayaci.Models;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IsKazasiGunSayaci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private myVariables _variables = new myVariables();
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            DisplayData();
        }
        private void LoadData()
        {
            try
            {
                if (File.Exists("dates.txt"))
                {
                    var json = File.ReadAllText("dates.txt");
                    if (!string.IsNullOrEmpty(json))
                    {
                        _variables = JsonConvert.DeserializeObject<myVariables>(json);
                    }
                    else
                    {
                        _variables = new myVariables();
                        MessageBox.Show("Dosya boş. Varsayılan değerlerle başlatılıyor.");
                    }
                }
                else
                {
                    _variables = new myVariables();
                    MessageBox.Show("dates.txt dosyası bulunamadı. Varsayılan değerlerle başlatılıyor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken bir hata oluştu: ");
                _variables = new myVariables();  // Hata durumunda yine de bir instance oluşturulur
            }
        }

        private void SaveData(myVariables variables)
        {
            var json = JsonConvert.SerializeObject(variables, Formatting.Indented);
            File.WriteAllText("dates.txt", json);

        }
        private void updateValues()
        {
            //
        }
        private void DisplayData()
        {
            if (_variables != null)
            {
                songunedirne.Text = _variables.edirnesongun.ToString();
                DateTime edirne = _variables.edirnesongun;
                TimeSpan toplamzamanedirne = DateTime.Now - edirne;
                songunedirne_Kopyala.Text = toplamzamanedirne.Days.ToString();
                songunavcilar.Text = _variables.avcilarsongun.ToString();
                DateTime avcilar = _variables.avcilarsongun;
                TimeSpan toplamzamanavcilar = DateTime.Now - avcilar;
                songunavcilar_Kopyala.Text = toplamzamanavcilar.Days.ToString();
                songunbagcilar.Text = _variables.bagcilarsongun.ToString();
                DateTime bagcilar = _variables.bagcilarsongun;
                TimeSpan toplamzamanbagcilar = DateTime.Now - bagcilar;
                songunbagcilar_Kopyala.Text = toplamzamanbagcilar.Days.ToString();
                songunbevler.Text = _variables.bevlersongun.ToString();
                DateTime bevler = _variables.bevlersongun;
                TimeSpan toplamzamanbevler = DateTime.Now - bevler;
                songunbevler_Kopyala.Text = toplamzamanbevler.Days.ToString();
                songunbköy.Text = _variables.bkoysongun.ToString();
                DateTime bkoy = _variables.bkoysongun;
                TimeSpan toplamzamanbkoy = DateTime.Now - bkoy;
                songunbköy_Kopyala.Text = toplamzamanbkoy.Days.ToString();
                songunbpasa.Text = _variables.bayrampasasongun.ToString();
                DateTime bayrampasa = _variables.bayrampasasongun;
                TimeSpan toplamzamanbayrampasa = DateTime.Now - bayrampasa;
                songunbpasa_Kopyala.Text = toplamzamanbayrampasa.Days.ToString();
                songunbebek.Text = _variables.bebeksongun.ToString();
                DateTime bebek = _variables.bebeksongun;
                TimeSpan toplamzamanbebek = DateTime.Now - bebek;
                songunbebek_Kopyala.Text = toplamzamanbebek.Days.ToString();
                songunbeyoglu.Text = _variables.beyoglusogun.ToString();
                DateTime beyoglu = _variables.beyoglusogun;
                TimeSpan toplamzamanbeyoglu = DateTime.Now - beyoglu;
                songunbeyoglu_Kopyala.Text = toplamzamanbeyoglu.Days.ToString();
                songunbcekmece.Text = _variables.bcekmecesongun.ToString();
                DateTime bcekmece = _variables.bcekmecesongun;
                TimeSpan toplamzamanbcekmece = DateTime.Now - bcekmece;
                songunbcekmece_Kopyala.Text = toplamzamanbcekmece.Days.ToString();
                songuneminonu.Text = _variables.eminonusongun.ToString();
                DateTime eonu = _variables.eminonusongun;
                TimeSpan toplamzamaneonu = DateTime.Now - eonu;
                songuneminonu_Kopyala.Text = toplamzamaneonu.Days.ToString();
                songunfatih.Text = _variables.fatihsongun.ToString();
                DateTime fatih = _variables.fatihsongun;
                TimeSpan toplamzamanfatih = DateTime.Now - fatih;
                songunfatih_Kopyala.Text = toplamzamanfatih.Days.ToString();
                songungtepe.Text = _variables.gayrettepesongun.ToString();
                DateTime gayrettepe = _variables.gayrettepesongun;
                TimeSpan toplamzamangtepe = DateTime.Now - gayrettepe;
                songungtepe_Kopyala.Text = toplamzamangtepe.Days.ToString();
                songungop.Text = _variables.gopsongun.ToString();
                DateTime gop = _variables.gopsongun;
                TimeSpan toplamzamangop = DateTime.Now - gop;
                gungop.Text = toplamzamangop.Days.ToString();
                songunikitelli.Text = _variables.ikitellisongun.ToString();
                DateTime telli = _variables.ikitellisongun;
                TimeSpan toplamzamantelli = DateTime.Now - telli;
                gunikitelli.Text = toplamzamantelli.Days.ToString();
                songunerenkoy.Text = _variables.erenkoysongun.ToString();
                DateTime ekoy = _variables.erenkoysongun;
                TimeSpan toplamzamanekoy = DateTime.Now - ekoy;
                gunerenkoy.Text = toplamzamanekoy.Days.ToString();
                songunkadiköy.Text = _variables.kadiköysongun.ToString();
                DateTime kkoy = _variables.kadiköysongun;
                TimeSpan toplamzamankkoy = DateTime.Now - kkoy;
                gunkadikoy.Text = toplamzamankkoy.Days.ToString();
                songunkucukyali.Text = _variables.kucukyalisongun.ToString();
                DateTime kyali = _variables.kucukyalisongun;
                TimeSpan toplamzamankyali = DateTime.Now - kyali;
                gunkucukyali.Text = toplamzamankyali.Days.ToString();
                songunpendik.Text = _variables.pendiksongun.ToString();
                DateTime pendik = _variables.pendiksongun;
                TimeSpan toplamzamanpendik = DateTime.Now - pendik;
                gunpendik.Text = toplamzamanpendik.Days.ToString();
                songunumraniye.Text = _variables.umraniyesongun.ToString();
                DateTime umraniye = _variables.umraniyesongun;
                TimeSpan toplamzamanumraniye = DateTime.Now - umraniye;
                gunumraniye.Text = toplamzamanumraniye.Days.ToString();
                songunuskudar.Text = _variables.uskudarsongun.ToString();
                DateTime uskudar = _variables.uskudarsongun;
                TimeSpan toplamzamanuskudar = DateTime.Now - uskudar;
                gunuskudar.Text = toplamzamanuskudar.Days.ToString();
                songunkirklareli.Text = _variables.kirklarelisongun.ToString();
                DateTime keli = _variables.kirklarelisongun;
                TimeSpan toplamzamaneli = DateTime.Now - keli;
                gunkirklareli.Text = toplamzamaneli.Days.ToString();
                songuntekirdag.Text = _variables.tekirdagsongun.ToString();
                DateTime tekirdag = _variables.tekirdagsongun;
                TimeSpan toplamzamantekirdag = DateTime.Now - tekirdag;
                guntekirdag.Text = toplamzamantekirdag.Days.ToString();
                songunsakarya.Text = _variables.sakaryasongun.ToString();
                DateTime sakarya = _variables.sakaryasongun;
                TimeSpan toplamzamansakarya = DateTime.Now - sakarya;
                gunsakarya.Text = toplamzamansakarya.Days.ToString();
                songunkocaeli.Text = _variables.kocaelisongun.ToString();
                DateTime kocaeli = _variables.kocaelisongun;
                TimeSpan toplamzamankocaeli = DateTime.Now - kocaeli;
                gunkocaeli.Text = toplamzamankocaeli.Days.ToString();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputDialog dialog = new InputDialog();
            if (dialog.ShowDialog() == true)
            {
                string selectedSube = dialog.SelectedSube;
                DateTime girilenTarih = dialog.GirilenTarih;
                switch (selectedSube)
                {
                    case "Edirne": _variables.edirnesongun = girilenTarih; break;
                    case "Avcılar": _variables.avcilarsongun = girilenTarih; break;
                    case "Bağcılar": _variables.bagcilarsongun = girilenTarih; break;
                    case "Bahçelievler": _variables.bevlersongun = girilenTarih; break;
                    case "Bakırköy": _variables.bkoysongun = girilenTarih; break;
                    case "Bayrampaşa": _variables.bayrampasasongun = girilenTarih; break;
                    case "Bebek": _variables.bebeksongun = girilenTarih; break;
                    case "Beyoğlu": _variables.beyoglusogun = girilenTarih; break;
                    case "Büyükçekmece": _variables.bcekmecesongun = girilenTarih; break;
                    case "Eminönü": _variables.eminonusongun = girilenTarih; break;
                    case "Fatih": _variables.fatihsongun = girilenTarih; break;
                    case "Gayrettepe": _variables.gayrettepesongun = girilenTarih; break;
                    case "Gaziosmanpaşa": _variables.gopsongun = girilenTarih; break;
                    case "İkitelli": _variables.ikitellisongun = girilenTarih; break;
                    case "Erenköy": _variables.erenkoysongun = girilenTarih; break;
                    case "Kadıköy": _variables.kadiköysongun = girilenTarih; break;
                    case "Küçükyalı": _variables.kucukyalisongun = girilenTarih; break;
                    case "Pendik": _variables.pendiksongun = girilenTarih; break;
                    case "Ümraniye": _variables.umraniyesongun = girilenTarih; break;
                    case "Üsküdar": _variables.uskudarsongun = girilenTarih; break;
                    case "Kırklareli": _variables.kirklarelisongun = girilenTarih; break;
                    case "Tekirdağ": _variables.tekirdagsongun = girilenTarih; break;
                    case "Sakarya": _variables.sakaryasongun = girilenTarih; break;
                    case "Kocaeli": _variables.kocaelisongun = girilenTarih; break;
                    default: MessageBox.Show("Hata oluştu"); break;
                        


                }
                SaveData(_variables);
               
                this.Close();

            }
        }
        private void UpdateUI()
        {
            this.Hide();
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
            this.Close();
        }
    }
}