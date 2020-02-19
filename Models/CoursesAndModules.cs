using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp7475.Models
{
    public class CoursesAndModules
    {
        public string Fn { get; }
        public string Mn { get; }
        public string Ln { get; }
        public int NationalIDNumber { get; }
        public string LoginID { get; }
        public string JobTitle { get; }
        public DateTime BirthDate { get; }
        public string Ms { get; }
        public string Gender { get; }
        public DateTime HireDate { get; }
        public string Al { get; }
        public string City { get; }
        public string Pc { get; }
        //public object Sl { get; }
        public string Ea { get; }
        public string Pn { get; }

        public CoursesAndModules(string fn, string mn, string ln, int nationalIDNumber, string loginID, string jobTitle, DateTime birthDate, string ms, string gender, DateTime hireDate, string al, string city, string pc,  string ea, string pn)
        {
            this.Fn = fn;
            this.Mn = mn;
            this.Ln = ln;
            this.NationalIDNumber = nationalIDNumber;
            this.LoginID = loginID;
            this.JobTitle = jobTitle;
            this.BirthDate = birthDate;
            this.Ms = ms;
            this.Gender = gender;
            this.HireDate = hireDate;
            this.Al = al;
            this.City = city;
            this.Pc = pc;
            //this.Sl = sl;
            this.Ea = ea;
            this.Pn = pn;
        }
    }

    public class EmployeeDetails
    {
            public string FirstName { get; }
            public string MiddleName { get; }
            public string LastName { get; }

            public EmployeeDetails(string firstName, string middleName, string lastName)
            {
                this.FirstName = firstName;
                this.MiddleName = middleName;
                this.LastName = lastName;

            }
    }
}
