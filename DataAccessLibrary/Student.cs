using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
   public class Student 
    {
        private string name;
        private string lastName;
        private string phoneNumber;
        private string email; //primary/secondary
        private Address address;//primary/secondary
        private Subject subjects;

        public Student(string name, string lastName, string phoneNumber, string email, Address address, Subject subjects)
        {
            this.name = name;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.subjects = subjects;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public Subject Subjects
        {
            get
            {
                return subjects;
            }

            set
            {
                subjects = value;
            }
        }
    }
}
