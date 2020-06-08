using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using YarlHospitalWPF.YarlHospital_Ref;

namespace YarlHospitalWPF
{
    /// <summary>
    /// Interaction logic for Doctor.xaml
    /// </summary>
    public partial class Doctor : Window
    {
        Service1Client doc_ser_cli = new Service1Client();

        public Doctor()
        {
            InitializeComponent();
            Loaded += Doctor_Loaded;
        }

        private void Doctor_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGriddoctor.ItemsSource = doc_ser_cli.get_doctor_list();

            }
            catch(Exception ex)
            {

            }
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
            this.Close();
        }

        private void btnback_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu mainmenu = new MainMenu();
            mainmenu.Show();
            this.Close();            
        }

        private void btnback1_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void BtnAddDoctor_Click(object sender, RoutedEventArgs e)
        {
            txtDID.Text =  doc_ser_cli.get_max_doctor_id();
        }
    }
}   
