using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_IntroAnDebugging
{
    class Program
    {

        static void Main(string[] args)
        {

            double dBill;
            int iTipPrecent;
            double dTipConversion;
            double dTotal;
            string strI;

            Console.Write("Enter Bill Amount: ");
            strI = Console.ReadLine();

            if (!double.TryParse(strI, out dBill))
            {

            }

            Console.Write("Enter Tip Percentage: ");
            strI = Console.ReadLine();

            if (!Int32.TryParse(strI, out iTipPrecent))
            {

            }

            dTipConversion = iTipPrecent % 100;

            Console.WriteLine(dTipConversion);

            dTotal = dTipConversion + dBill;

            Console.WriteLine("Total is: " + dTotal);




        }
    }
}
