using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandX
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            
            public Person(string firstName, string lastName, DateTime dateOfBirth, string address, string phoneNumber, string email)
            {
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
                Address = address;
                PhoneNumber = phoneNumber;
                Email = email;
            }

        }


        public string GetFullName()
        {

        }

        public void DisplayInfo()
        {

        }

        public bool IsAdult()
        {

        }
        public void HaveBirthday()
        {

        }
        static void Main(string[] args)
        {
            
        }
    }
}
