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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Close();  
        }

        private void btnAppointment_Click(object sender, RoutedEventArgs e)
        {
            Appointment Appointment = new Appointment();
            Appointment.Show();
            this.Close();
        }

        private void btnDrug_Click(object sender, RoutedEventArgs e)
        {
            Drugs drugForm = new Drugs();
            drugForm.Show();
            this.Close();
        }

        private void btnTreatment_Click(object sender, RoutedEventArgs e)
        {
            Treatment treatmentForm = new Treatment();
            treatmentForm.Show();
            this.Close();
        }

        private void btnDoctor_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctorForm = new Doctor();
            doctorForm.Show();
            this.Close();
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            Payment paymentform = new Payment();
            paymentform.Show();
            this.Close();
        }
    }
}
