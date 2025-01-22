using Application1;
using Application2;
using Application3;
using Application4;
using Application5;
using Application6;
using Application7;
using Application8;
//using Application9;
using Application10;
using Application11;
using Application12;
using Application13;
using Application14;
using Application15;
using Application16;
using Application17;
using Application18;
using Application19;
using Application20;
using ItSchool.App.Utilities;

namespace ApplicationControler
{
    internal class Program
    {
        private static void Main(string[] args)

        {

            ApplicationBase.Applications.AddRange([
                new App1(),
                new App2(),
                new App3(),
                new App4(),
                new App5(),
                new App6(),
                new App7(),
                new App8(),
                //new App9(),
                new App10(),
                new App11(),
                new App12(),
                new App13(),
                new App14(),
                new App15(),
                new App16(),
                new App17(),
                new App18(),
                new App19(),
                new App20(),
            ]);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Lista aplicatiilor :");
                Console.WriteLine(" ");

                for (int i = 0; i < ApplicationBase.Applications.Count; i++)
                {
                    Console.Write($"{(i + 1)}: ");
                    Console.WriteLine(ApplicationBase.Applications[i].Cerinta);

                }

                Console.WriteLine();
                Console.WriteLine("0:EXIT");

                int input = CitesteNumardelatastatura(0, ApplicationBase.Applications.Count);
                Console.WriteLine(" ");

                if (input == 0)
                {
                    return;
                }

                Console.Clear();
                ApplicationBase.Applications[input - 1].Launch();


                Console.WriteLine("Apasati tasta ENTER pentru a reveni ");
                Console.ReadLine();
            }

        }
        static int CitesteNumardelatastatura(int minim, int maxim)
        {
            Console.WriteLine("Introdu un numar:");
            string aInput = Console.ReadLine();
            bool aValid = int.TryParse(aInput, out int a);

            while (!aValid || (a < minim || a > maxim))
            {
                Console.WriteLine("Datele introduse nu sunt corespunde");
                Console.Write("Introdu un numar:");
                aInput = Console.ReadLine();
                aValid = int.TryParse(aInput, out a);

            }

            return a;
        }
    }
}