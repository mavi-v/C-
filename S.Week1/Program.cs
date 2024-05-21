using System;

namespace S.Week1
{
   /* public class Employee
    {
        private String firstName;
        private String lastName;
        //private int idNumber;
        private double salary;

        public void SetSalary(double p)
        {
            salary = p;
        }

        public void AddSalary(double p)
        {
            salary += p;
        }
        public void PrintSalary()
        {
            Console.WriteLine("The salary" + "of the employee " + firstName + " " + lastName + " is " + salary);
        }
        public double GetSalary()
        {
            return salary;
        }

        public void SetName(string nm, string lnm)
        {
            firstName = nm;
            lastName = lnm;
        }

        public string GetName()
        {
            return firstName + " " + lastName; //add space " " // NEW LINE "\n"

        }

        public double CalcTax(double TaxNmb)
        {
            return (TaxNmb / 100) * salary; // use the constant in the same format for example "100.0" is more "safe" en especial con las divisiones.
        }

        
    }*/

    /* public class Point
    {
        private int xPos;
        private int yPos;

        //private int xPos, yPos; otra forma de hacerlo 

        public void SetPoint(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        public void ShowPoint()
        {
            Console.WriteLine(xPos + ", " + yPos);
        }

    } */

    public class Car
    {
        private String register;
        private String colour;
        private String licence;
        private int speed; //double también está bien


        public void SetRegister(String reg)
        {
            register = reg;
        }

        public void SetCar(String color, String lic)
        {
            colour = color;
            licence = lic;
        }

        public void SetSpeed(int sp)
        {
            speed = sp;
        }

        public double GetSpeed()
        {
            return speed;
        }

        public void ShowCar()
        {
            Console.WriteLine("Reregister: "+ register +", Color" + colour + ", Speed "+ speed);
        }
       
        public void Accelerate(int sp)
        {

            //if (speed + sp > 120 && speed + sp > 0) thi is another way of doing this, it will only go up if it is allow; 
            // speed += sp;                          segunda parte no va a dejar que la velocidad baje a 0 cuando le pida que baje                       
            //                                        la velocidad llamando   
            speed += sp;

            if (speed > 120)
            {
                speed = 120;
            }


        }

        public void BreakALittle()
        {
            Accelerate(-5);

            if (speed < 0)
            {
                speed = 1;
            }
        }

        public void BreakALot()
        {
            Accelerate (-10);

            if (speed < 0)
            {
                speed = 1;
            }
        }

        /*public string ReadInput()
        {
            string localinput = Console.ReadLine();
            return localinput;
        }*/
    }

    /*public class Cars
    {
        private string register;
        private string colour;
        private int speed;

        public void ShowCar()
        {
            Console.WriteLine(register + ", colour:" + colour + ", speed: " + speed);
        }
        public void SetCar(string reg, string col)
        {
            register = reg;
            colour = col;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void Accelerate(int add)
        {
            speed += add;
            if (speed > 120)
            {
                speed = 120;
            }
        }
        public void BreakALittle()
        {
            while (speed > 0)
            //Call Accelerate with negative parameter value to break 
            {
                Accelerate(-5);
            }

            if (speed < 0)
            {
                speed = 1;
            }
        }
        public void BreakALot()
        {
            while (speed > 0)
            //Call BreakALittle twice to reduce speed by 10 units
            {
                BreakALittle();
                BreakALittle();
            }
        }*/

        
        class Program
        {
            static void Main(string[] args)
            {

                

                Car car1 = new Car();
                Car car2 = new Car();

                car1.SetSpeed(0);
                car2.SetSpeed(0);

                //Not sure how to make this part as an input from user -- besides this way of application 
                car1.SetCar("Blue", "A1234");
                car2.SetCar("Green", "B1234");


                //is it suppossed to be able to take many commands at one go?

                Console.WriteLine("Press Any key to start ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) //estoy pidiendo la informaciónd dos veces 

                    //how to make it show the "Input command" without waiting for a key command?
                {
                    Console.WriteLine("Input command: ");
                    char command = Convert.ToChar(Console.ReadLine());

                    if (command == 'b')
                    {
                        car1.Accelerate(5);
                    }

                    if (command == 'c')
                    {
                        car2.Accelerate(5);
                    }

                    if (command == 'd')
                    {
                        car1.BreakALittle();
                    }

                    if (command == 'e')
                    {
                        car1.BreakALot();
                    }

                    if (command == 'f')
                    {
                        car2.BreakALittle();
                    }

                    if (command == 'g')
                    {
                        car2.BreakALot();
                    }
                    else // si lo hago con if tengo que poner else al final para que no testee todas las opciones el programa es más eficiente asi
                    // era mejor switch case (no recuerdo por que no use ese) 
                    if (command == 'q')
                    {
                        Console.WriteLine("Speed of Car 1: " + car1.GetSpeed() + " Speed of Car 2: " + car2.GetSpeed());
                        if (car1.GetSpeed() == car2.GetSpeed())
                        {
                            Console.WriteLine("Speed is exactly the same.");
                        }
                    }

                    if (command == 'x')
                    {
                        car1.SetSpeed(0);
                        car2.SetSpeed(0);
                    }

                    Console.WriteLine("Press Enter to End or Another key to continue");
                    

                }

                //how to make the speed add up 

                /* Point num1 = new Point();

                 num1.SetPoint(13, 14);

                 num1.ShowPoint();*/

                //Console.WriteLine("HERE IS THE MAIN OUTPUT PROGRAM");

                /* Employee emp1 = new Employee();
                emp1.SetSalary(1000.0);
                emp1.SetName("Mavi", "Villatoro");
                Console.WriteLine(emp1.GetName() + ", Salary: " + emp1.GetSalary() + ",tax calculated : " + emp1.CalcTax(30.0));

                Console.ReadLine(); */

                /*Car c1, c2, c3;
                c1 = new Car();
                c2 = new Car();
                c3 = new Car();

                c1.ShowCar();*/




            }
        } 
}
