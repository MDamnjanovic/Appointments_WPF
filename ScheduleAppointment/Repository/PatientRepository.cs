using ScheduleAppointment.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Repository
{
    class PatientRepository : IRepository<Patient>
    {
        public void add(Patient objectElement)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public void edit(Patient objectElement)
        {
            throw new NotImplementedException();
        }

        public List<Patient> getAll()
        {
            List<Patient> lstPatients = new List<Patient>();
            string[] fileLines = File.ReadAllLines("../../Data/patients.txt");
            foreach (string line in fileLines)
            {

                if (line != "")
                {
                    string firstName = line.Split(',')[0];
                    string lastName = line.Split(',')[1];
                    string uniqueNumber = line.Split(',')[2];
                    string emailAddress = line.Split(',')[3];
                    string address = (line.Split(',')[4]);
                    string sex = line.Split(',')[5];
                    string password = line.Split(',')[6];


                    Patient patient = new Patient(firstName, lastName, uniqueNumber, emailAddress, address, sex, password);
                    lstPatients.Add(patient);

                }


            }
            return lstPatients;
        }

        public Patient getOne(string uniqueNum)
        {
            string[] fileLines = File.ReadAllLines("../../Data/patients.txt");
            foreach (string line in fileLines)
            {
                string uniqueNumber = line.Split(',')[2];

                if (uniqueNumber == uniqueNum)
                {
                    string firstName = line.Split(',')[0];
                    string lastName = line.Split(',')[1];
                    string emailAddress = line.Split(',')[3];
                    string address = (line.Split(',')[4]);
                    string sex = line.Split(',')[5];
                    string password = line.Split(',')[6];
                    Patient patient = new Patient(firstName, lastName, uniqueNumber, emailAddress, address, sex, password);
                    return patient;

                }


                
            }
            return null;
        }

        public Patient getOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
