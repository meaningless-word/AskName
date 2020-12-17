using System;

namespace AskName
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Roman";

            Console.WriteLine(myName);
            // символьные литералы
            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", myName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            //логические литералы
            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.ReadKey();
        }
    }
}
