using System;

namespace S.week7
{
    class Program
    {
        public abstract class GraphicalObject
             {
                 protected string color;

                 public GraphicalObject()
                 {

                 }
                 public GraphicalObject(string cl)
                 {
                     color = cl;
                 }

                 public void Display()
                 {
                     Console.WriteLine(", (10,45), (20,35)");
                 }

                 public void DispType()
                 {
                     Console.WriteLine("type: , " + "color: " + color + ", (10,45), (20,35)");
                 }

             }

             class Point : GraphicalObject
             {
                 private int xPos;
                 private int yPos;


                 public Point(string cl, int x, int y) : base ()
                 {
                     color = cl;
                     xPos = x;
                     yPos = y;
                 }

                 public void Display()
                 {
                     Console.WriteLine("type: Line, color: " + color +", ("+ xPos +","+ yPos +")");
                 }
             }

             class Line : GraphicalObject
             {
                 private Point xPos2;
                 private Point yPos2;

                 public Line(string cl, Point x2, Point y2) : base ()
                 {
                     xPos2 = x2;
                     yPos2 = y2;
                     color = cl;
                 }

                 public void Display()
                 {
                     Console.WriteLine("type: , " + "color: " + color);
                 }
             }

        static void Main(string[] args)
        {
            Point p1 = new Point("blue", 10, 35);
            p1.DispType();
            //p1.Display();
        }
    }
}
