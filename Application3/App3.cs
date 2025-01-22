using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application3
{
    public class App3 : ApplicationBase
    {
        public App3()
        {
            Cerinta = "Cititi un numar si calculati patratul " +
            "acestuia. Afisati rezultatul.";
        }

        public override void Launch()
        {
            int a = Utils.GetIntFromKeyboard("a");


            Console.WriteLine("Patratul unui numar a este: " + a * a);
        }
    }
}
