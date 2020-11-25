using System;
using Model;
using Model.Entity;
using static Model.BusinessLogic;

namespace Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweet sweet = new Sweet();
            sweet.Add(new Candy("Candy", 10, 24, KindManufacturer.Ferrero, 94, KindCandy.Wafer));
            sweet.Add(new Chocolate("Chocolate", 12, 17, KindManufacturer.Fini, 32, 54, KindChocolate.White));
            sweet.Add(new Chocolate("1hocolate", 12, 17, KindManufacturer.Nestle, 32, 54, KindChocolate.White));
            sweet.Add(new Chocolate("yocolate", 12, 17, KindManufacturer.Mars, 32, 54, KindChocolate.White));
            sweet.Add(new Chocolate("0ocolate", 12, 17, KindManufacturer.Коммунарка, 32, 54, KindChocolate.White));
            SortByManufacturer(sweet);
            Console.WriteLine(sweet);
        }
    }
}