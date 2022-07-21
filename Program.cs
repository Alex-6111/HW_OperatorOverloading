
using System;

namespace HW_OperatorOverloading
{
    internal class Program
    {
        static void Main()
        {

            Problem1();
            Problem2();
            Problem3();

        }

        static void Problem1()
        {
            var testMagazine = new Magazine("TopGear", "2020", "Cars magazine", "+1835381248", "topgear@mail.com", 50);
            testMagazine.PrintInfo();
            var testMagazine2 = new Magazine();
            testMagazine2.EnterInfo();
            testMagazine2.PrintInfo();
        }

        public static void Problem2()
        {
            var testShop = new Shop("Apple","2000",
                "Electronic shop", "+11111111111", "apple@mail.com", 1000);
            testShop.PrintInfo();
        }

        static void Problem3()
        {
            var testBook = new Book("Hobzar", 500, "Taras Shevchenko");
            testBook.OutInfo();
        }

    }
}