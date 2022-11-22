using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EMPD6
{
    public class program
    {
        static void Main(string[] args)
        {
            EMPD6 obj = new EMPD6();
            Console.WriteLine("1.Sum Of Salary");
            Console.WriteLine("2.Average Of Salary");
            Console.WriteLine("3.Minimum Of Salary");
            Console.WriteLine("4.Maximum Of Salary");
            Console.Write("Enter Option:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.Write("Sum Of Salary Is:" + obj.sum());
                    break;
                case 2:
                    Console.Write("Average Salary Is:" + obj.avg());
                    obj.avg();
                    break;
                case 3:
                    Console.Write("Minimum Salary Is:" + obj.min());
                    obj.min();
                    break;
                case 4:
                    Console.Write("Maximum Salary Is:" + obj.max());
                    obj.max();
                    break;
            }
        }
    }
}