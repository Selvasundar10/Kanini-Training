using GenericDelegate;
using System.Runtime.InteropServices;



public delegate int MyDelegate();

class Program

{
    //static ArithmeticException arithmeticException;
    /*static void InvokeDelegate(MyDelegate del)
    {
        del("Hello world");
    }*/
    public static void Main(string[] args)
    /*{
        GenUse<int> guint = new GenUse<int>(10);
        GenUse<double> gudouble = new GenUse<double>(10.8980);
        GenUse<string> gustring = new GenUse<string>("Sundar");

        Console.WriteLine(gudouble.Number);
        Console.WriteLine(guint.Number);
        Console.WriteLine(gustring.Number);


    }*/


    /*GenUse<int> intarr = new GenUse<int>(5);
    for (int i = 0; i < 5; i++)
    {
        intarr.setarr(i, ((i+1) *10));
    }
    for (int i = 0;i < 5; i++)
    {
        Console.WriteLine(intarr.getarr(i));

    }
    GenUse<char> chararr = new GenUse<char>(5);
    for (int i = 0; i < 5; i++)
    {
        chararr.setarr(i, Convert.ToChar(i+65));
    }
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(chararr.getarr(i));

    }
}*/

    /*{
        GenUse<ArithmeticException> ae = new GenUse<ArithmeticException>(throw new ArithmeticException());
        Console.WriteLine(ae.disp().Message);
    }*/
    /*{
        int n1 = 10, n2 = 5;
        char c1 = 'A', c2 = 'B';
         

        Swap<int>(ref n1, ref n2);
        Swap<char>(ref c1, ref c2);

        Console.WriteLine("a = {0}, b ={1}, n1, n2");
        Console.WriteLine("c = {0}, d ={1}, c1, c2");





    }*/


    //DELEGATE
    /*{

        MyDelegate myDelegate1 = new MyDelegate(DelUse1.Method1);
        // myDelegate1.Invoke("Hello Sundar");


        MyDelegate myDelegate2;

        myDelegate2 = DelUse2.Method2;
        // myDelegate1("Hi Sundar");

        InvokeDelegate(myDelegate1);
        InvokeDelegate(myDelegate2);



    }*/
    {
        MyDelegate del1 = DelUse1.Method1;
        MyDelegate del2 = DelUse2.Method2;

        // MyDelegate del = del1 + del2;
        //Console.WriteLine("After del1" + "del2");
        //del("Hello");

        MyDelegate del =  del2 +del1;
       Console.WriteLine( del());


    }
}