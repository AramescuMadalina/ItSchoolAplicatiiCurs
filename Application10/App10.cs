using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application10
{
    public class App10 : ApplicationBase
    {
        public App10()
        {
            Cerinta = "Cititi un numar si continuati sa cititi " +
            "numere pana cand se introduce un numar negativ. " +
            "Afisati suma numerelor introduse.";
        }
        public override void Launch()
        {
            Console.WriteLine("n este: ");
            int n;
            int suma = 0;
            string nInput = Console.ReadLine();
            bool Nvalid = int.TryParse(nInput, out n);


            while (!Nvalid)
            {
                Console.WriteLine("Nu este bine!!");
                Console.WriteLine("n este defapt: !!");
                nInput = Console.ReadLine();
                Nvalid = int.TryParse(nInput, out n);
            }

            while (n > 0)
            {
                suma += n;
                Console.WriteLine("n este: ");
                nInput = Console.ReadLine();
                Nvalid = int.TryParse(nInput, out n);

            }
            Console.WriteLine($"Suma numerelor introduse este {suma}");
        }
    }
}
