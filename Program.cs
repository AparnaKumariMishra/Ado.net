using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EMPD5
{
    public class program
    {
        static void Main(string[] args)
        {
            EMPD5 obj = new EMPD5();
            Employee emp = new Employee();

            emp.date = Convert.ToDateTime("2019/01/01");
            emp.date = Convert.ToDateTime("2019/11/01");

            obj.EmployeeBetweenDates(emp);
        }
    }
}