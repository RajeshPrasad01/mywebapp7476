using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace myWebApp7475.Models
{
    public class DataAccessController
    {
        // TODO: Add your connection string in the following statements
        private string connectionString = "Server=tcp:mysqlserver7476.database.windows.net,1433;Initial Catalog=mySQLDB7476;Persist Security Info=False;User ID=rajesh.prasad0;Password=Happy@200789;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public IEnumerable<CoursesAndModules> GetAllCoursesAndModules()
        {
            List<CoursesAndModules> courseList = new List<CoursesAndModules>();

            // TODO: Connect to the database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Specify the SQL query to run
                SqlCommand cmd = new SqlCommand(@"
                  select Person.Person.FirstName, Person.Person.MiddleName, Person.Person.LastName, HumanResources.Employee.NationalIDNumber, HumanResources.Employee.LoginID, HumanResources.Employee.JobTitle, HumanResources.Employee.BirthDate, HumanResources.Employee.MaritalStatus, HumanResources.Employee.Gender, HumanResources.Employee.HireDate, PAdd.AddressLine1, PAdd.City, PAdd.PostalCode, PAdd.SpatialLocation.STAsText() as Coordinates, [Person].[EmailAddress].EmailAddress, [Person].[PersonPhone].PhoneNumber
                    From [Person].[Person] 
                    JOIN [HumanResources].[Employee]  ON [Person].[Person].BusinessEntityID = [HumanResources].[Employee].BusinessEntityID 
                    JOIN [Person].[EmailAddress]  ON [Person].[Person].BusinessEntityID = [Person].[EmailAddress].BusinessEntityID 
                    JOIN [Person].[PersonPhone]  ON [Person].[Person].BusinessEntityID = [Person].[PersonPhone].BusinessEntityID
                    JOIN [Person].[Address] as PAdd ON [Person].[Person].BusinessEntityID = PAdd.AddressID 
                ", con);
                cmd.CommandType = CommandType.Text;

                // Execute the query
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                
                // Read the data a row at a time
                while (rdr.Read())
                {
                    string fn = rdr["FirstName"].ToString();
                    string mn = rdr["MiddleName"].ToString();
                    string ln = rdr["LastName"].ToString();
                    int nationalIDNumber = Convert.ToInt32(rdr["NationalIDNumber"]);
                    string loginID = rdr["LoginID"].ToString();
                    string jobTitle = rdr["JobTitle"].ToString();
                    DateTime birthDate = Convert.ToDateTime(rdr["BirthDate"]);
                    string ms = rdr["MaritalStatus"].ToString();
                    string gender = rdr["Gender"].ToString();
                    DateTime hireDate = Convert.ToDateTime(rdr["HireDate"]);
                    string al = rdr["AddressLine1"].ToString();
                    string city = rdr["City"].ToString();
                    string pc = rdr["PostalCode"].ToString();
                    //object sl =  rdr["SpatialLocation"];
                    string ea = rdr["EmailAddress"].ToString();
                    string pn = rdr["PhoneNumber"].ToString();

                    CoursesAndModules course = new CoursesAndModules(fn, mn, ln, nationalIDNumber, loginID, jobTitle, birthDate, ms, gender, hireDate, al, city, pc, ea, pn);
                    courseList.Add(course);
                    
                }
            }
            return courseList;
        }


        public IEnumerable<EmployeeDetails> GetAllCoursesAndModulesEmployees()
        {
            List<EmployeeDetails> employee = new List<EmployeeDetails>();

            // TODO: Connect to the database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Specify the SQL query to run
                SqlCommand cmdEmployee = new SqlCommand(@"SELECT * from [Person].[Person]", con);
                cmdEmployee.CommandType = CommandType.Text;

                // Execute the query
                con.Open();
                SqlDataReader rdrEmployee = cmdEmployee.ExecuteReader();
                while (rdrEmployee.Read())
                {
                    string firstName = rdrEmployee["FirstName"].ToString();
                    string middleName = rdrEmployee["MiddleName"].ToString();
                    string lastName = rdrEmployee["LastName"].ToString();
                    EmployeeDetails courseEmployee = new EmployeeDetails(firstName, middleName, lastName);
                    employee.Add(courseEmployee);
                }

                // Close the database connection
                con.Close();
            }
            return employee;

        }
    }
}
