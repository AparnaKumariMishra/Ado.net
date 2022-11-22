using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EMPD4
{
    public class program
    {
        static void Main(string[] args)
        {
            Refactor_EMPD4 obj = new Refactor_EMPD4();
            Employee emp = new Employee();

            emp.employeename = "Jack";
            emp.basicpay = 16000;

            obj.UpdateSalary(emp);
        }
    }
}