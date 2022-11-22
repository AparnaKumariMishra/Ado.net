using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EMPD2
{
    public class program
    {
        static void Main(string[] args)
        {
            EMPD2 obj = new EMPD2();
            obj.retrieve_data_from_database();
        }
    }
}