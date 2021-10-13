using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleAppointment.Model
{
    public class User
    {
        string firstName;
        string lastName;
        string uniqueNumber;
        string emailAddress;
        string address;
        string sex;
        string password;

        public User(string firstName, string lastName, string uniqueNumber, string emailAddress, string address, string sex, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UniqueNumber = uniqueNumber;
            this.EmailAddress = emailAddress;
            this.Address = address;
            this.Sex = sex;
            this.Password = password;
        }

        public User(User user)
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.UniqueNumber = user.UniqueNumber;
            this.EmailAddress = user.EmailAddress;
            this.Address = user.Address;
            this.Sex = user.Sex;
            this.Password = user.Password;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UniqueNumber { get => uniqueNumber; set => uniqueNumber = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Address { get => address; set => address = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Password { get => password; set => password = value; }
    }
}
