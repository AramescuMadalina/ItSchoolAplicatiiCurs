using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application11
{
    public class App11 : ApplicationBase
    {
        public App11()
        {
            Cerinta = "Generati si afisati toate numerele de la 1 la " +
            "50 care sunt divizibile cu 3.";
        }
        public override void Launch()
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {

                    Console.Write(i + ",");
                }

            }
        }
    }
}
