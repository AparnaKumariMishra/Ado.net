using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EMPD3
{
    public class program
    {
        static void Main(string[] args)
        {
            EMPD3 obj = new EMPD3();
            Employee emp = new Employee();

            emp.employeeid = 5;
            emp.employeename = "Terrisa";
            emp.basicpay = 20000;

            obj.UpdateSalary(emp);
        }
    }
}