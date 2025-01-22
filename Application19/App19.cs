using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItSchool.App.Utilities;

namespace Application19
{
    public class App19 : ApplicationBase
    {
        public App19()
        {
            Cerinta = "Sa se realizeze un catalog pentru vehicule. " +
                "Obiectele trebuie sa contina cel putin informatii despre" +
                " marca, model, an fabricaţie, numar de kilometri si pret de vanzare. " +
                "Elementele trebuie sa poata fi sortate si afisate dupa pret, " +
                "an sau numarul de kilometri.";
        }

        public override void Launch()
        {
            ListofVehicles list = new ListofVehicles();

            list.Vehicles.Add(new Vehicle("Cherolet ", "Aveo", 2010, 153000, 1700));
            list.Vehicles.Add(new Vehicle("Volkswagen", "Polo", 2011, 123000, 4000));
            list.Vehicles.Add(new Vehicle("Audi", "A3", 2014, 130000, 3000));
            list.Vehicles.Add(new Vehicle("BMW", "X2", 2020, 23000, 20000));
            list.Vehicles.Add(new Vehicle("Seat", "Noul Leon", 2024, 5600, 27000));
            list.Vehicles.Add(new Vehicle("Seat", "Leon", 2006, 200000, 2700));
            list.Vehicles.Add(new Vehicle("Opel", "Zafira", 1999, 245000, 500));

            list.ShowListofVehicles();
            Console.WriteLine();
            list.SortbyYear(true);
            List<Vehicle> filteredList = list.FilterByBrand("Seat");
        }
    }
}
