using System;

namespace S.Week10
{
    class Program
    {
        public class EntSystem
        {
            private string model;
            private string type;
            private string serialNumber;
            private static EntSystem entSystem = null;

            private static int count = 0;
            private static int amount = 0;

            public const string code = "PMMNDe1";

            private EntSystem(string md, string tipo)
            {
                model = md;
                type = tipo;
                serialNumber = String.Format("{0,0:D6}", (count++) + 1);

            }

            public static int ProdAmount()
            {
                amount++;
                return count;
            }

            public static EntSystem GetEntSystem(string md, string tipo)
            {
                
                if (entSystem == null)
                {
                    entSystem = new EntSystem(md,tipo);

                }

                return entSystem;
            }


            public override string ToString()
            {
                string text = ("PopMyMachine, Model: " + model + ", Type: " + type + ", Serial No.:"
                    + code + serialNumber);

                return text;
            }


        }


        static void Main(string[] args)
        {
            
        }
    }
}
