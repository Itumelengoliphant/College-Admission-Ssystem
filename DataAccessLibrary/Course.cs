using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
   public class Course
    {
        private string name;
        private string code;
        private DateTime date;
        private int credits;
        private int aps;
        private string description;


        public Course(string name, string code, DateTime date, int credits, string description)
        {
            this.name = Name;
            this.code = Code;
            this.credits = Credits;
            this.credits = Credits;
            this.aps = Aps;
            this.description = Description;

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

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public int Aps
        {
            get
            {
                return aps;
            }

            set
            {
                aps = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
