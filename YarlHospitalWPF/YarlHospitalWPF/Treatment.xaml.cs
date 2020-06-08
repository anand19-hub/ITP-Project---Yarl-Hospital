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
using System.Text.RegularExpressions;

namespace YarlHospitalWPF
{
    /// <summary>
    /// Interaction logic for Treatment.xaml
    /// </summary>
    public partial class Treatment : Window
    {
        Service1Client treatement_ser_client = new Service1Client();
        
        public Treatment()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string tid = txtinsertTreatmentID.Text;
            DateTime today = DateTime.Today;

            try
            {
                //if ((txtinsertTreatmentID.Text == "") || (txtinsertPatientID.Text == "") || (txtPatientName.Text == "") || (txtVisitDate.Text == "") || (txtDiagnostic.Text == "") || (txtnextvisitdate.Text == "") || (txtNextVisitTime.Text == "") || (txtDrugUsed.Text == "") || (txttimesperday.Text == "") || (txtnoofdays.Text == ""))
                //{
                //    MessageBox.Show("please fill all the fields", "Fields required", MessageBoxButton.OK, MessageBoxImage.Warning);

                //}

                //if (!Regex.IsMatch(txtinsertTreatmentID.Text, @"^[a-zA-z0-9]+$"))
                //{
                //    MessageBox.Show("Please Enter the valid Treatement Id", "invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);

                //}


                //if (!Regex.IsMatch(txtinsertPatientID.Text, @"^[a-zA-z0-9]+$"))
                //{
                //    MessageBox.Show("please enter valid patient id","invalid output",MessageBoxButton.OK,MessageBoxImage.Warning);

                //}


                //if (!Regex.IsMatch(txtPatientName.Text, @"^[a-zA-Z]+$"))
                //{
                //    MessageBox.Show("please enter valid patient name", "invalid output", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}

                ////if (!Convert.ToDateTime(txtVisitDate) > today)
                ////{

                ////    MessageBox.Show("Please enter the valid ", "Invalid Output", MessageBoxButton.OK, MessageBoxImage.Warning);
                ////}

                //if (!Regex.IsMatch(txtDiagnostic.Text, @"^[a-zA-z]+$"))
                //{
                //    MessageBox.Show("Please Enter the valid Diagnostic details", "invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);

                //}
                //else
                //{
                    treatement_ser_client.Add_Treatement(txtinsertTreatmentID.Text, txtPatientID.Text, txtPatientName.Text, txtVisitDate.Text, txtDiagnostic.Text, txtnextvisitdate.Text, txtNextVisitTime.Text, txtDrugUsed.Text, int.Parse(txttimesperday.Text), int.Parse(txtnoofdays.Text));
                    MessageBox.Show("Added Sucessfully", "Added", MessageBoxButton.OK, MessageBoxImage.Information);

                    txtinsertTreatmentID.Text = "";
                    txtPatientID.Text = "";
                    txtPatientName.Text = "";
                    txtVisitDate.Text = "";
                    txtDiagnostic.Text = "";
                    txtnextvisitdate.Text = "";
                    txtNextVisitTime.Text = "";
                    txtDrugUsed.Text = "";
                    txttimesperday.Text = "";
                    txtnoofdays.Text = "";


                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Faild to add infromation", "faild", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void TxtNextVisitTime_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            string tid = txtinsertTreatmentID.Text;
            DateTime today = DateTime.Today;
            try
            {
                if ((txtinsertPatientID.Text == "") | (txtinsertTreatmentID.Text == "") | (txtPatientName.Text == "") | (txtVisitDate.Text == "") | (txtDiagnostic.Text == "") |
                    (txtnextvisitdate.Text == "") | (txtNextVisitTime.Text == "") | (txttimesperday.Text == "") | (txtnoofdays.Text == ""))
                {
                    MessageBox.Show("Please fill all fields to add", "Fields Required", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (!Regex.IsMatch(txtPatientName.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Please enter a patient name", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {

                    treatement_ser_client.Add_Treatement(txtinsertTreatmentID.Text, txtinsertPatientID.Text, txtPatientName.Text, txtVisitDate.Text, txtDiagnostic.Text, txtnextvisitdate.Text, txtNextVisitTime.Text, txtDrugUsed.Text, int.Parse(txttimesperday.Text), int.Parse(txtnoofdays.Text));
                    MessageBox.Show("Information Successfully Added ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                    txtinsertTreatmentID.Text = "";
                    txtinsertPatientID.Text = "";
                    txtPatientName.Text = "";
                    txtVisitDate.Text = "";
                    txtDiagnostic.Text = "";
                    txtnextvisitdate.Text = "";
                    txtNextVisitTime.Text = "";
                    txtDrugUsed.Text = "";
                    txttimesperday.Text = "";
                    txtnoofdays.Text = "";
                }

            }
            catch (Exception ex)
            { }
        }

        private void Btnback1_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //  treatement_ser_client.Update_Treatement(string tid, string pid, string fullname, string visitdate, string diagnos, string nxtvisitdate, string nxtvisittime, string drugused, int timesperday, int numofdays);
                treatement_ser_client.Update_Treatement(txtinsertTreatmentID.Text, txtinsertPatientID.Text, txtPatientName.Text, txtVisitDate.Text, txtDiagnostic.Text, txtnextvisitdate.Text, txtNextVisitTime.Text, txtDrugUsed.Text, int.Parse(txttimesperday.Text), int.Parse(txtnoofdays.Text));

                MessageBox.Show("Information Successfully Updated ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
