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
    /// Interaction logic for FrmTherapyHistory.xaml
    /// </summary>
    public partial class FrmTherapyHistory : Window
    {
        Patient patient;
        Doctor doctor;
        public FrmTherapyHistory(User user)
        {
            if (user is Patient)
                this.patient = (Patient)user;
            if (user is Doctor)
                this.doctor = (Doctor)user;
            InitializeComponent();
            TherapyHistoryController.displayTherapies(user, dgTherapyHistory);
        }
        
    }
}
