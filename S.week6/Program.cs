using System;

namespace S.week6
{
    class Program
    {
        class Employee
        {
            protected int salary;

            public Employee()
            {
                salary = 1000;
            }

            public int GetSalary()
            {
                return salary;
            }
        }

        class Manager : Employee
        {
            private Employee subordinate;
            //private int managerNew;

            public Manager() : base()
            {
                salary = 1500;
            }

            public void SetSubordinate(Employee sub)
            {
                
                salary =+ salary + (1000 * 10 / 100);
                sub = subordinate;

                //sub = subordinate;
                //salary += (subordinate.GetSalary() / 10);!!
                //salary += ((int)GetSalary() * 0.1);
                //subordinate.GetSalary() += * (10 /100);

            }

            public Employee GetSubordinate()
            {

                //return subordinate;
                
                if (subordinate !=null)
                {
                    return subordinate;
                }

                return null;
            }

            public void DropSubordinate()
            {
                if (subordinate != null)
                {
                    subordinate = null;
                    salary -= (subordinate.GetSalary() /10);
                    
                }

                    
            }

        }

        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Console.WriteLine(emp2.GetSalary());
            Console.WriteLine(emp1.GetSalary());

            Manager man1 = new Manager();
            man1.SetSubordinate(emp1);
            //Console.WriteLine(man1.GetSalary());
        }
    }
}
