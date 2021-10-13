using ScheduleAppointment.Controller;
using ScheduleAppointment.Model;
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

namespace ScheduleAppointment.View
{
    /// <summary>
    /// Interaction logic for FrmTherapy.xaml
    /// </summary>
    public partial class FrmTherapy : Window
    {
        Appointment appointment;
        public FrmTherapy(Appointment appointment)
        {
            this.appointment = appointment;
            InitializeComponent();
            TherapyController.setDataDisplay(appointment, lbDateTime, lbPatient);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e) // utorak 10 30
        {
            if (tbDescription.Text != "")
            {
                TherapyController.addTherapy(appointment, tbDescription.Text);
                this.Close();
            }
            else
                MessageBox.Show("You must enter description");
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
