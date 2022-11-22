using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EMPD6
{
    public class Employee
    {
        public int employeeid { get; set; }
        public string employeename { get; set; }
        public string employeephonenumber { get; set; }
        public string employeeaddress { get; set; }
        public string employeedepartment { get; set; }
        public string employeegender { get; set; }
        public double basicpay { get; set; }
        public double deduction { get; set; }
        public double taxablepay { get; set; }
        public double tax { get; set; }
        public double netpay { get; set; }
        public DateTime date { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
    public class EMPD6
    {
        public static string str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ado_Payroll_Service;Integrated Security=True";
        SqlConnection con = new SqlConnection(str);
        public double sum()
        {
            double salary;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SUM(BasicPay) FROM Employee WHERE Gender = 'M' GROUP BY Gender;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    salary = dr.GetDouble(0);
                    return salary;
                }
            }
            con.Close();
            return 1;
        }
        public double avg()
        {
            double salary;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select AVG(BasicPay) FROM Employee WHERE Gender = 'M' GROUP BY Gender;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    salary = dr.GetDouble(0);
                    return salary;
                }
            }
            con.Close();
            return 1;
        }
        public double min()
        {
            double salary;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select MIN(BasicPay) FROM Employee WHERE Gender = 'M' GROUP BY Gender;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    salary = dr.GetDouble(0);
                    return salary;
                }
            }
            con.Close();
            return 1;
        }
        public double max()
        {
            double salary;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select MAX(BasicPay) FROM Employee WHERE Gender = 'M' GROUP BY Gender;", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    salary = dr.GetDouble(0);
                    return salary;
                }
            }
            con.Close();
            return 1;
        }

    }
}