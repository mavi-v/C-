using System;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Mavi Villatoro");

            //funciona si escribo solo los parentensis, /\n, /t, investigar esos ultimos comandos option 
            //Console.WriteLine("" +
            //"");


            Console.WriteLine();

            //task 2
            //Console.WriteLine("Mavi");
            //Console.WriteLine("Villatoro");

            Console.WriteLine("Mavi\nVillatoro");

            Console.WriteLine();

            //task 3
            Console.WriteLine("   o");
            Console.WriteLine("  ooo");
            Console.WriteLine(" o   o");
            Console.WriteLine("o     o");
            Console.WriteLine(" o   o");
            Console.WriteLine("  ooo");
            Console.WriteLine("   o");

            Console.WriteLine();

            //task 4
            Console.Write("   o\n");
            Console.Write("  ooo\n");
            Console.Write(" o   o\n");
            Console.Write("o     o\n");
            Console.Write(" o   o\n");
            Console.Write("  ooo\n");
            Console.Write("   o\n");

            //Console.Write("\n");
            Console.WriteLine();

            //task 5
            Console.Write("   o\n  ooo\n o   o\no     o\n o   o\n  ooo\n   o\n");
            Console.WriteLine();
            //task 6
            //Console.Write(4);

            Console.WriteLine("Mavi, Age: " + (10 + 14));

            Console.WriteLine();
            //task 7 
            //Console.WriteLine("Mavi Villatoro");

            /*
            Console.WriteLine("Mavi Villatoro");
            Console.WriteLine("Mavi\nVillatoro");
            */

            int BirthYear, CurrentYear;
            int Age;

            CurrentYear = 2021;
            BirthYear = 1996;

            Age = 24;

            Age = CurrentYear - BirthYear + 34; //no entiendo por que puso el 34, creo que solo esta desmotrando como hacer estas cosas

            //bool b = true;  // la b es una variable 
            //bool b = false;
            bool agelessThan18 = Age < 18; //puede ser así también 

        }
    }
}
