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
            Console.WriteLine("Task: New Year Gif");
            Console.WriteLine();
            Sweet sweet = new Sweet();
            sweet.Add(new Candy("Аэрофлотские", 0.05, 0.3m, KindManufacturer.Коммунарка, 45, KindCandy.Wafer));
            sweet.Add(new Chocolate("Спартак", 0.07, 0.5m, KindManufacturer.Спартак, 61, 54, KindChocolate.Black));
            sweet.Add(new Marshmallow("Краковский", 0.12, 0.4m, KindManufacturer.Nestle, 32, true, KindMarshmallow.Glazed));
            sweet.Add(new Candy("Российские", 0.25, 1.3m, KindManufacturer.Saadet, 73, KindCandy.PigeonsMilk));
            sweet.Add(new Chocolate("Белорусский грильяж", 0.7, 4.5m, KindManufacturer.Спартак, 32, 23, KindChocolate.Black));
            sweet.Add(new Marshmallow("Полоцкий", 0.2, 0.9m, KindManufacturer.Конти, 84, false, KindMarshmallow.Unglazed));
            SortByName(sweet);
            Console.WriteLine("Sweets:\n" + sweet);

            Gift gift = CreateGiftByWeight("Gift by weight", sweet);
            Console.WriteLine(gift);
            Console.WriteLine();
            
            SortByWeight(gift);
            Console.WriteLine("Sort by weight (asc):");
            Console.WriteLine(gift);
            Console.WriteLine();
            
            SortByPrice(gift, false);
            Console.WriteLine("Sort by price (desc):");
            Console.WriteLine(gift);
            Console.WriteLine();
            
            gift = CreateGiftByCost("Gift by price",  sweet);
            Console.WriteLine(gift);
            Console.WriteLine();
            
            SortByManufacturer(gift);
            Console.WriteLine("Sort by manufacturer (asc):");
            Console.WriteLine(gift);
            Console.WriteLine();
            
            SortBySugar(gift, false);
            Console.WriteLine("Sort by sugar (desc):");
            Console.WriteLine(gift);
            Console.WriteLine();

            Console.WriteLine(FilterSweetsByPrice(sweet));
            Console.WriteLine(FilterSweetsByWeight(sweet));
            
        }
    }
}