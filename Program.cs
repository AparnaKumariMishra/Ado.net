using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace EmployeePayRollDataBaseSystem
{
    public class program
    {
      public  static void Main(string[] args)
        {
            EMPD1 obj = new EMPD1();
            obj.connect_database();
        }
    }
}