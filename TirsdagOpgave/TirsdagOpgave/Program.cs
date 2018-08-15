using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TirsdagOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Udskriv data
            string tekst;
            Console.WriteLine("Frederik:");
            tekst = Console.ReadLine();
            Console.WriteLine("Dit navn er: {0}", tekst);
            Console.ReadKey();

            int alder;
            Console.WriteLine(23);
            alder = int.Parse(Console.ReadLine());
            Console.WriteLine("Din alder er: {0}", alder);
            Console.ReadKey();

            */
            /*
            //Fahrenheit udregning

            Console.WriteLine("Indtast decimal tal i fahrenheit brug ',' til at adskille tal og decimaler");
            decimal talSvar = Convert.ToDecimal(Console.ReadLine());
            decimal celsius;

            celsius = (talSvar - 32) * 5 / 9;

            Console.WriteLine("Svaret er {0}",celsius);
            */


            Console.WriteLine("Kom med en temperatur i Celsius");
            double svar = Convert.ToDouble(Console.ReadLine());
            double output1;
            double output2;
            double output3;

            output1 = (svar * 9 / 5) + 32;
            output2 = svar + 273.15;
            output3 = svar * 0.8;

            Console.WriteLine("Resultatet er for: \n Fahrenheit: {0}\n Kelvin: {1}\n Réaumur: {2}", output1, output2, output3);

        }
    }
}
