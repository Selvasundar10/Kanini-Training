using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_project
{
    internal class StaticDemo
    {
        static int cno=123, pre=10000, curr=12000;
        static double amt;

        public static int Cno { get => cno; set => cno = value; }
        public static int Pre { get => pre; set => pre = value; }
        public static int Curr { get => curr; set => curr = value; }
        public static double Amt { get => amt; set => amt = value; }

        public static void  calc()
        {
            Amt = ((Curr - Pre) * 5);
        }

        public void disp()
        {
            Console.WriteLine();
        }

    }
}
