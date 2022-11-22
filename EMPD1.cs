using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace EmployeePayRollDataBaseSystem
{
    public class EMPD1
    {
        public static string str = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
        public void connect_database()
        {
            try
            {
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand cmd = new SqlCommand("Create Database Ado_Payroll_Service", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //static void Main(string[] args)
        //{
          //  EMPD1 obj = new EMPD1();
            //obj.connect_database();
        //}
    }
}
