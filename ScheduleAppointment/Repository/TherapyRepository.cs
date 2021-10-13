using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
    class TherapyRepository : IRepository<Therapy>
    {
        public void add(Therapy objectElement)
        {
            //Therapy(int uniqueId, string therapydesc, Appointment appointment)
            string newLine = objectElement.UniqueId + "," + objectElement.Therapydesc +
                "," + objectElement.getAppointment().UniqueId + Environment.NewLine;

            File.AppendAllText("../../Data/therapies.txt", newLine);
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(Therapy objectElement)
        {
            throw new NotImplementedException();
        }

        public List<Therapy> getAll()
        {
            List<Therapy> lstTherapies = new List<Therapy>();
            string[] fileLines = File.ReadAllLines("../../Data/therapies.txt");
            foreach (string line in fileLines)
            {

                int uniqueId = Convert.ToInt32(line.Split(',')[0]);
                string therapyDesc = line.Split(',')[1];
                int appointmendId = Convert.ToInt32(line.Split(',')[2]);
                AppointmentRepository appointmentRep = new AppointmentRepository();
                Therapy therapy = new Therapy(uniqueId, therapyDesc, appointmentRep.getAll().Where(a=>a.UniqueId==appointmendId).FirstOrDefault());
                lstTherapies.Add(therapy);




            }
            return lstTherapies;
        }

        public Therapy getOne(int id)
        {
            throw new NotImplementedException();
        }

        public Therapy getOne(string id)
        {
            throw new NotImplementedException();
        }
    }
}
