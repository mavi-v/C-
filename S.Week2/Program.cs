using System;

namespace S.Week2
{
    public class Point
    {
        private int xPos;
        private int yPos;

        public Point()
        {
            xPos = 10;
            yPos = 20;
        }

        public Point(int x1, int y1)
        {
            xPos = x1;
            yPos = y1;
        }

        public void SetPoint(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
        public void ShowPoint()
        {
            Console.WriteLine("Point: " + xPos + ", " + yPos);
        }
    }

    public class Grade
    {
        private int studentID;
        private int studentGrade;

        public Grade(int stID, int stGrade)
        {
            if (stID >=1 && stID >= 1000)
            {
                studentID = 0;
            }
            else
                studentID = stID;

            if (stGrade > 5 || stGrade < 0)
            {
                studentGrade = -1;
            }
            else
                studentGrade = stGrade;
        }

        //are the "Set" methods needed here also? or is it possible to just request the values from the constructors?

        public int GetStudentID()
        {
            return studentID;
        }

        public int GetGrade()
        {
            return studentGrade;
        }
    }



    class Program
    {

        static void Main(string[] args)
        {

             //Point p1 = new Point();
             //p1.ShowPoint();
             const int MAX_SIZE = 4;
             Point[] points = new Point[MAX_SIZE];
             for (int i = 0; i < MAX_SIZE; i++)
             points[i] = new Point();
             /*points[i] = new Point();
             points[i] = new Point();
             points[i] = new Point();*/

             points[0].ShowPoint();
             points[1].SetPoint(-1, 7);
             points[1].ShowPoint();
             points[2].SetPoint(-6, -2);
             points[2].ShowPoint();
             points[3].SetPoint(0, 13);
             points[3].ShowPoint(); 

             //is there anyother way to output and fill this information
            for ( int index = 0; index < points.Length; index++ )
             Console.WriteLine("Point {0}:" + points[index].ToString()); //esto esta mal jeje
            /* Console.WriteLine("Point 1: " points[0].ShowPoint());
             "Point 2: "  points[1].ShowPoint();*/

            //GRADE CLASS
            Grade grades = new Grade(123,4);
            Console.WriteLine("Student ID: " + grades.GetStudentID() + ", Grade: " + grades.GetGrade());

            //while loop
            //input initialization
            //try cath structure if the user inputs something iligal to stop the program terminating
            //info saying the loop is full



        }
        
        /*public class Student
        {
            private int studentID;
            private int credits;
            private DateTime startDate;

            public Student()
            {
                credits = 0;
                studentID = 130000;
                startDate = DateTime.Today;
            }
        }*/

        
    }
}
