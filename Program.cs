using System;

namespace ProductBase
{
    class Program
    {
        static void Main(string[] args)
        {

            StartProduct a = new StartProduct("film", "fajny", 2000, 20);
            a.AddBase();
            StartProduct b = new StartProduct("film2", "bardzn fajny", 2000, 23);
            b.AddBase();
            StartProduct.DisplayBase();





        }
    }
}
