using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class User
    {
        private static int id;
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string NotRobotCode { get; set; }

        public Month RegistrationMonth { get; set; }
        public User(string name, string surname, string notRoboteCode, Month registrationMonth)
        {
            id++;
            ID = id;
            Name = name;
            Surname = surname;
            NotRobotCode = notRoboteCode;
            RegistrationMonth = registrationMonth;
        }
        public string GetDetails()
        {

            if (NotRobotCode.CheckNotRoboteCode())
            {
                return $"{ID},{Name},{Surname},{RegistrationMonth},{NotRobotCode}";
            }
            else
            {
                return $"{ID},{Name},{Surname},{RegistrationMonth},NotRoboteCode is not correct";

            }
        }

    }
    public enum Month
    {
        January = 1,
        February,
        March
    }
}
