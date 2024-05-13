using System;

namespace Exam
{
    class Program

    {
        static void Name (double X, double j, double n)
        {
            double PV;
            PV = X / Math.Pow((1 + j), n);
             //PV = X / (1 + (Math.Pow(j, n)));
            Console.WriteLine(PV);
        }
        static void Main(string[] args)

        {
            /*Console.WriteLine("Please Give the Information from when you were born: ");
            Console.WriteLine("Day: ");
            int BirthDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month: ");
            int BirthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year: ");
            int BirthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select Format: 1. Day first, 2. Month first, 3.Year First");
            int BrtFormat = Convert.ToInt32(Console.ReadLine());

            if (!(BrtFormat != 1 && BrtFormat != 2 && BrtFormat != 3))

                switch (BrtFormat)
            {
                    case 1:
                Console.WriteLine(BirthDay + "." + BirthMonth + "." + BirthYear);
                        break;

                    case 2:
                        Console.WriteLine(BirthMonth + "/" + BirthDay + "/" + BirthYear);
                        break;
                    case 3:
                        Console.WriteLine(BirthYear + " " + BirthDay + " " + BirthMonth);

                       break;

            }*/



            //Task 2
             int Array_Size = 10;
             string[] Characters = new string[Array_Size];
             Console.WriteLine("Please Give " + Array_Size + "Characters");
             string[] MyChar = { "a,e,i,o,u");
             int i = 0;

             {
                // if ((Characters == 'a' && 'e' && 'i' && 'o' && 'u')) ;

             }

             while (i < Array_Size)
             {
                 Characters[i++] = Console.ReadLine();
                 Console.WriteLine("Add Next Character, Please");

             }

             i = 0;

             while (i < Array_Size-1)
             {

                 Console.Write(Characters[i++] + ", ");

             }

             
             Console.Write(Characters[Array_Size - 1]);




            //Task 3

            Name(1000, 0.08, 3);
            


            

        }
    }
}
