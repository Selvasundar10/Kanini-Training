using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoSql
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stud_Details stud_details = new Stud_Details();
            stud_details.ReadDatafromSqlServer();

            Stud_Details min = new Stud_Details();
            min.CountMinMaxAvg();

            Console.ReadLine();
        }
    }
}
