using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
    class DoctorRepository : IRepository<Doctor>
    {
        public void add(Doctor objectElement)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(Doctor objectElement)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> getAll()
        {
            List<Doctor> lstDoctors = new List<Doctor>();
            string[] fileLines = File.ReadAllLines("../../Data/doctors.txt");
            foreach (string line in fileLines)
            {
                
                    string firstName = line.Split(',')[0];
                    string lastName = line.Split(',')[1];
                    string uniqueNumber = line.Split(',')[2];
                    string emailAddress = line.Split(',')[3];
                    string address = (line.Split(',')[4]);
                    string sex = line.Split(',')[5];
                    string password = line.Split(',')[6];
                    int hospitalId = Convert.ToInt32(line.Split(',')[7]);
                    HospitalRepository hospitalrepository = new HospitalRepository();
                    Hospital hospital = hospitalrepository.getOne(hospitalId);

                    Doctor doctor = new Doctor(firstName, lastName, uniqueNumber, emailAddress, address, sex, password, hospital);
                    lstDoctors.Add(doctor);




            }
            return lstDoctors;

        }

        public Doctor getOne(string uniqueNum)
        {
            string[] fileLines = File.ReadAllLines("../../Data/doctors.txt");
            foreach (string line in fileLines)
            {
                string uniqueNumber = line.Split(',')[2];

                if (uniqueNum == uniqueNumber)
                {
                    string firstName = line.Split(',')[0];
                    string lastName = line.Split(',')[1];
                    string emailAddress = line.Split(',')[3];
                    string address = (line.Split(',')[4]);
                    string sex = line.Split(',')[5];
                    string password = line.Split(',')[6];
                    int hospitalId = Convert.ToInt32(line.Split(',')[7]);
                    HospitalRepository hospitalrepository = new HospitalRepository();
                    Hospital hospital = hospitalrepository.getOne(hospitalId);

                    return new Doctor(firstName, lastName, uniqueNumber, emailAddress, address, sex, password, hospital);
                }

                
            }
            return null;
        }

        public Doctor getOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
