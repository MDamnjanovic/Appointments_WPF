using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ScheduleAppointment.Repository
{
    public class AppointmentRepository : IRepository<Appointment>
    {
        public void add(Appointment objectElement)
        {
            //(int uniqueId, Doctor doctor, DateTime appointmentDate, bool availability, Patient patient)
            string newLine = objectElement.UniqueId + "," + objectElement.Doctor.UniqueNumber +
                "," + objectElement.AppointmentDate + "," + objectElement.Availability + "," + objectElement.Patient.UniqueNumber + Environment.NewLine;

            File.AppendAllText("../../Data/appointments.txt", newLine);
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(Appointment objectElement)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> getAll()
        {
            //(int uniqueId, Doctor doctor, DateTime appointmentDate, bool availability, Patient patient)

            List<Appointment> lstAppointments = new List<Appointment>();
            string[] fileLines = File.ReadAllLines("../../Data/appointments.txt");
            foreach (string line in fileLines)
            {
                if (line != "")
                {
                    int uniqueId = Convert.ToInt32(line.Split(',')[0]);
                    DoctorRepository doctorRepository = new DoctorRepository();
                    Doctor doctor = doctorRepository.getOne(line.Split(',')[1]);
                    DateTime appointmentDate = Convert.ToDateTime(line.Split(',')[2]);
                    bool availability = Convert.ToBoolean(line.Split(',')[3]);
                    PatientRepository patientRepository = new PatientRepository();
                    Patient patient = patientRepository.getOne(line.Split(',')[4]);


                    Appointment appointment = new Appointment(uniqueId, doctor, appointmentDate, availability, patient);
                    //MessageBox.Show(appointment.DisplayData());
                    lstAppointments.Add(appointment);

                }


            }
            return lstAppointments;
        }

        public Appointment getOne(int id)
        {
            throw new NotImplementedException();
        }

        public Appointment getOne(string id)
        {
            throw new NotImplementedException();
        }
    }
}
