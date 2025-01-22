using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application20
{
    public class App20 : ApplicationBase
    {
        public App20()
        {
            Cerinta = "Sa se defineasca urmatoarele forme geometrice: patrat, dreptunghi, cerc, triunghi. " +
                "Elementele trebuie sa poata oferi metode de calcul pentru arie si perimetru";
        }

        public override void Launch()
        {
            Square shape1 = new Square(3);
            Console.WriteLine("Avem un patrat cu latura de 3 cm");
            Console.WriteLine($"Aria patratului este : {shape1.GetArea()} cm²");
            Console.WriteLine($"Perimetrul patratului este :{shape1.GetPerimeter()} cm");
            Rectangle shape2 = new Rectangle(2, 3);
            Console.WriteLine();
            Console.WriteLine("Avem un dreptunghi cu lungimea de 3 cm si latimea de 2 cm");
            Console.WriteLine($"Aria dreptunghiului este : {shape2.GetArea()} cm²");
            Console.WriteLine($"Perimetrul dreptunghiului este :{shape2.GetPerimeter()} cm");
            Circle shape3 = new Circle(5);
            Console.WriteLine();
            Console.WriteLine("Avem un cerc cu raza de 5 cm");
            Console.WriteLine($"Aria cercului este : {shape3.GetArea()} cm²");
            Console.WriteLine($"Perimetrul cercului este :{shape3.GetPerimeter()} cm");
            Console.WriteLine();
        }


    }
}
