using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoSql
{

    internal class Stud_Details


    {
        StudentClassesDataContext stucontext = new StudentClassesDataContext();

        public void ReadDatafromSqlServer()


        {

            //var res = from st in stucontext.stud_detail1s where st.rno > 88 select st;


            var res = stucontext.stud_detail1s.Where(st => st.rno > 105);

            foreach (var n in res)
            {
                Console.WriteLine(n.rno + " " + n.name);
            }
        }

        public void CountMinMaxAvg()
        {
            int cou = (from st in stucontext.stud_detail1s select st).Count();

            Console.WriteLine("Row: " + cou);

            int? min = (from st in stucontext.stud_detail1s select st.rno).Min();

            Console.WriteLine("Min: " + min);


            double avg = (double)stucontext.stud_detail1s.Average(st => st.rno);
            Console.WriteLine("Average: " + avg);
        }

    }
}
