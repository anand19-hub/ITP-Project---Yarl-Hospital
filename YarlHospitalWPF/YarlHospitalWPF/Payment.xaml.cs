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

namespace YarlHospitalWPF
{
    /// <summary>
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnLogout1_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm Log out", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Hide();
                MainWindow log = new MainWindow();
                log.Show();
            }
            else
            {
                this.Show();
            }

        }

        private void txtPaymentID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAddPayment_Click(object sender, RoutedEventArgs e)
        {
            //want to check//////////txtinsrtPaymentID.
        }

        private void txtBalanceAmount_SelectionChanged(object sender, RoutedEventArgs e)
        {
/////////////////////////////////////////
        }

        private void btnViewPayment_Click(object sender, RoutedEventArgs e)
        {
////////////////////////////////////////
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
/////////////////////////////////////
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            /////////////////////////////////
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
////////////////////////////////////
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
/////////////////////////////////////////////
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void dataGridPayment_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
///////////////////////////////////////////////////
        }
    }
}
