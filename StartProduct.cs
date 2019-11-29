using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductBase
{
    class StartProduct
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private int Yearofproduction { get; set; }
        private double Price { get; set; }

        public StartProduct(string name, string description, int year, double price)
        {
            Name = name;
            Description = description;
            Yearofproduction = year;
            Price = price;

            Console.WriteLine($"You've created product: {Name} with price: {Price}");
        }

        public void AddBase()
        {
            using (var db = new ProductBaseSet())
            {
                db.MyBase.Add(
                    new ProductDefinition
                    {
                        ProductName = Name,
                        ProductDescription = Description,
                        YearOfProduction = Yearofproduction,
                        ActualPrice = Price
                    }
                    );
                db.SaveChanges();//Zmienić plik konfiguracyjny
            }

        }

        public static void DisplayBase()
        {
            using (var db = new ProductBaseSet())
            {
                var products = db.MyBase.ToList();
                foreach (var n in products)
                {
                    Console.WriteLine($"|NumerID: {n.ProductDefinitionId,-2}|Tytuł: {n.ProductName,-30}| rok produkcji: {n.YearOfProduction,-8}|");
                }
            }
        }
        public static void ProductRemove(int x) { 
            using (var db = new ProductBaseSet())
            {
                var singleBaseItem = db.MyBase
                        .Single(b => b.ProductDefinitionId == x);
                db.MyBase.Remove(singleBaseItem);
                db.SaveChanges();
            }
        }
        
        public static void BaseClean()
        {
            using (var db = new ProductBaseSet())
               
            {
                List<int> numery = new List<int>();
                var lista = db.MyBase.ToList();
                foreach(var n in lista)
                {
                    numery.Add(n.ProductDefinitionId);

                }
                foreach(var n in numery)
                {
                    var singleBaseItem = db.MyBase
                        .Single(b => b.ProductDefinitionId == n);
                    db.MyBase.Remove(singleBaseItem);
                    db.SaveChanges();
                }
            }
        }
        

        public static void ProductChangeName( int x, string newname)
        {
            using(var db = new ProductBaseSet())
            {
                var singleBaseItem = db.MyBase
                    .Single(b => b.ProductDefinitionId == x);
                singleBaseItem.ProductName = newname;
                db.SaveChanges();
            }
        }

    }
}
