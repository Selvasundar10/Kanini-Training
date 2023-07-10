using ADO_Assesment;
using System.Configuration;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        ADOConnect adoconn = new ADOConnect();

       // adoconn.Region();
      //  adoconn.Cus_Nodes();
        adoconn.Cust_Transaction();

    }
}