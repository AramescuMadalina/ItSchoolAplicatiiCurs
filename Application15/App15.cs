using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application15
{
    public class App15 : ApplicationBase
    {
        public App15()
        {
            Cerinta = "Cititi o serie de numere pana la " +
           "introducerea valorii 0 si " +
           "afisati media aritmetica " +
           "a numerelor introduse.";
        }
        public override void Launch()
        {
            Console.WriteLine("n este:");

            int mediaAritmetica = 0;
            int numarGasit = 0;
            string nInput = Console.ReadLine();

            int n = Utils.GetIntFromKeyboard("n");
            while (n != 0)
            {
                Console.WriteLine("n este:");
                nInput = Console.ReadLine();
                bool nValid = int.TryParse(nInput, out n);
                numarGasit++;
                mediaAritmetica += n;
            }
            mediaAritmetica = mediaAritmetica / numarGasit;
            Console.WriteLine("Media aritemtica a numerelor introduse este:" + mediaAritmetica);
        }
    }
}
