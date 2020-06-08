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

using System.Text.RegularExpressions;
using YarlHospitalWPF.YarlHospital_Ref;

namespace YarlHospitalWPF
{
    /// <summary>
    /// Interaction logic for Drugs.xaml
    /// </summary>
    public partial class Drugs : Window
    {
        Service1Client drugSerClient = new Service1Client();

        public Drugs()
        {
            InitializeComponent();
            Loaded += Drugs_Loaded;
        }

        private void Drugs_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridDrugMain.ItemsSource = drugSerClient.GetDrugs();

            }catch(Exception ex)
            {

            }

        }

        private void btnLogout1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddDrug_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnViewDrug_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string did = txtDrugID.Text;
            DateTime today = DateTime.Today;


            try
            {

                if ((txtinsrtDrugID.Text == "") || (txtinsrtDrugName.Text == "") || (txtinsrtScientificName.Text == "") || (txtdomanu.Text == "") || (txtdateofexp.Text == "") || (txtPrice.Text == "") || (txtQuantity.Text == ""))
                {
                    MessageBox.Show("Please fill all fields to add", "Fields Required", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else

                if (!Regex.IsMatch(txtinsrtDrugName.Text,@"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Please enter the valid drug name", "invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else

                if (!Regex.IsMatch(txtinsrtScientificName.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Please enter a valid Scientific name", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else

                if (Convert.ToDateTime(txtdomanu.Text) > today)
                {
                    MessageBox.Show("Please select a valid date OF Manufacture", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else

                if(Convert.ToDateTime(txtdateofexp.Text) < today)
                {
                    MessageBox.Show("Please select a valid date OF Expiry", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    drugSerClient.Add_drug(txtinsrtDrugID.Text, txtinsrtDrugName.Text, txtinsrtScientificName.Text, txtdomanu.Text, txtdateofexp.Text, int.Parse(txtPrice.Text), int.Parse(txtQuantity.Text));
                    MessageBox.Show("Information Successfully Added ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    txtDrugID.Text = "";
                    txtDrugName.Text = "";
                    txtinsrtScientificName.Text = "";
                    txtdomanu.Text = "";
                    txtdateofexp.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";

                }
            }
            catch(Exception ex)
            {

            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                drugSerClient.Update_Drug(txtinsrtDrugID.Text, txtinsrtDrugName.Text, txtinsrtScientificName.Text, txtdomanu.Text, txtdateofexp.Text, int.Parse(txtPrice.Text), int.Parse(txtQuantity.Text));


                MessageBox.Show("Information Successfully Updated ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();

        }
    }
}
