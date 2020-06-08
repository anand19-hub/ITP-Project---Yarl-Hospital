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

using System.Text.RegularExpressions; //for validation 
using YarlHospitalWPF.YarlHospital_Ref;

namespace YarlHospitalWPF
{
    /// <summary>
    /// Interaction logic for Appointment.xaml
    /// </summary>
    public partial class Appointment : Window
    {
        Service1Client ap = new Service1Client();
        public Appointment()
        {
            Loaded += Appointment_Loaded;
            InitializeComponent();
        }

        private void Appointment_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridappointment.ItemsSource = ap.Get_Appointment_List();
            }
            catch(Exception ex)
            {

            }
        }

        private void BtnAddAppointment1_Click(object sender, RoutedEventArgs e)
        {
                string aid = txtAID.Text;
            DateTime today = DateTime.Today;    

            try
            {
                if((txtAID.Text=="") || (txtDID.Text=="") || (txtPID.Text=="") || (txtPName.Text=="") || (txtContactNumber.Text=="") || (txtAppointmentDate.Text=="") || (txttime.Text == ""))
                {
                    MessageBox.Show("Please Fill All The Fields To Add","Fields Required ",MessageBoxButton.OK,MessageBoxImage.Error);

                }

                /// patient name validation
                if (!Regex.IsMatch(txtPName.Text,@"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Please enter a valid patient name", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                
                // contact validation
                if(!Regex.IsMatch(txtContactNumber.Text,@"^[0-9]{10}$"))
                {
                    MessageBox.Show("Please enter a valid Contact NO", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                if (Convert.ToDateTime(txtAppointmentDate) < today)
                {
                    MessageBox.Show("Please enter a valid Date", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                //if (Convert.ToDateTime(txttime) < today)
                //{
                //    MessageBox.Show("Please enter a valid Time", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Warning);
                //}
                else
                {
                    ap.Add_Appointment(txtAID.Text, txtDID.Text, txtPID.Text, txtPName.Text, int.Parse(txtContactNumber.Text), txtAppointmentDate.Text, txttime.Text);
                    MessageBox.Show("Information Successfully Added ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);


                    txtAID.Text = "";
                    txtDID.Text = "";
                    txtPID.Text = "";
                    txtPName.Text = "";
                    txtContactNumber.Text = "";
                    txtAppointmentDate.Text = "";
                    txttime.Text = "";


                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Information couldn't be added "+ex.Message, "Fail", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnUpdateAppointment1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                ap.Update_Appoinment(txtAID.Text, txtDID.Text, txtPID.Text, txtPName.Text, int.Parse(txtContactNumber.Text), txtAppointmentDate.Text, txttime.Text);


                MessageBox.Show("Information Successfully Updated ", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Btnback1_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();

        }

        private void Btnback2_Click(object sender, RoutedEventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }
    }
}
