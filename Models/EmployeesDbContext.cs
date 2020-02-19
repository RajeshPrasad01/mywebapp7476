using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using myWebApp7475.Models;

namespace myWebApp7475.Models
{
    public class EmployeesDbContext
    {
        public string ConnectionStringMySql { get; set; }

        public EmployeesDbContext(string connectionStringMySql)
        {
            this.ConnectionStringMySql = connectionStringMySql;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionStringMySql);
        }

        public List<Album> GetAllAlbums()
        {
            List<Album> list = new List<Album>();

            using (MySqlConnection connMySql = GetConnection())
            {
                connMySql.Open();
                MySqlCommand cmd = new MySqlCommand("select e.emp_no, e.First_name, e.Last_name, e.gender, e.hire_date, de.dept_no, dep.dept_name, sa.salary, ti.title  from employees e inner join dept_emp as de on e.emp_no = de.emp_no inner join departments as dep on de.dept_no =dep.dept_no inner join salaries as sa on e.emp_no = sa.emp_no inner join titles as ti on e.emp_no = ti.emp_no where sa.to_date = '1995-06-24' ", connMySql);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Album()
                        {
                            emp_no = Convert.ToInt32(reader["emp_no"]),
                            first_name = reader["first_name"].ToString(),
                            last_name = reader["last_name"].ToString(),
                            gender = reader["gender"].ToString(),
                            hire_date = Convert.ToDateTime(reader["hire_date"]),
                            dept_no = reader["dept_no"].ToString(),
                            dept_name = reader["dept_name"].ToString(),
                            salary = Convert.ToInt32(reader["salary"]),
                            title = reader["title"].ToString()
                    });
                    }
                }
                connMySql.Close();
            }
            return list;
        }
    }
}
