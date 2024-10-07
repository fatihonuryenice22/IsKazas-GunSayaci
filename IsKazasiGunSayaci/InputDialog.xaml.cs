using IsKazasiGunSayaci.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IsKazasiGunSayaci
{
    /// <summary>
    /// InputDialog.xaml etkileşim mantığı
    /// </summary>
    public partial class InputDialog : Window
    {
        public string SelectedSube {  get; private set; } = string.Empty;
        public DateTime GirilenTarih {  get; private set; }
        public InputDialog()
        {
            InitializeComponent();
           
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem selectedSubeItem = (ComboBoxItem)SubeComboBox.SelectedItem;
            if (selectedSubeItem == null)
            {
                MessageBox.Show("Geçerli Bir Sube Seçin");
                return;
            }
            if(!DateTime.TryParseExact(tarihtextbox.Text,"dd.MM.yyyy", null,System.Globalization.DateTimeStyles.None, out DateTime girilentarih))
            {
                MessageBox.Show("Geçerli bir tarih giriniz");
                return;
            }
            SelectedSube = selectedSubeItem.Content.ToString();
            GirilenTarih = girilentarih;
            this.DialogResult = true;
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
            this.Close();




                

            
        }
    }
}
