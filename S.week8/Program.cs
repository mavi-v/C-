using System;

namespace S.week8
{
    public abstract class GraphicalObject
    {
        protected string color;

        public GraphicalObject(string col)
        {
            color = col;
        }

        public abstract void Display();

        public void DispType()
        {
            Console.Write("type: " + this.GetType().Name + ", color: " + color);
            Display(); //no new line is generated
            Console.WriteLine();
        }
            
    }

    public class Point : GraphicalObject
    {
        private int xPos, yPos;

        public Point(string col, int x, int y) : base(col)
        {
            xPos = x;
            yPos = y;
        }

        public override void Display()
        {
            Console.Write(",(" + xPos + ", " + yPos + ")");
        }

    }

    public class Line : GraphicalObject
    {
        private Point endPoint, startPoint;

        public Line(string col, Point p1, Point p2) : base(col)
        {
            endPoint = p2;
            startPoint = p1;
        }

        public override void Display()
        {
            endPoint.Display();
            startPoint.Display();
        }
    }

    public class Polygon : GraphicalObject
    {
        Line[] edges;

        public Polygon(string col, Point[] pts) : base(col)
        {
            edges = new Line[pts.Length];

            if (pts != null && pts.Length >= 3)
            {
                Point first = pts[0];
                Point last = pts[pts.Length - 1];
                int i = 0;
                for (i = 0; i < pts.Length - 1; i++)
                    edges[i] = new Line(col, pts[i], pts[i + 1]);

                edges[i] = new Line(col, last, first);
            }
        }

        public override void Display()
        {
            foreach Line 
            line.Display();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point("red", 3, 4);
            p1.DispType();
            p1.Display();
            Line line = new Line("Blue", p1, new Point("blue", 4, 6));
            line.Display();



            Point[] corners = new Point[3];
            corners[0] = new Point("pink", 3, 5);
            corners[1] = new Point("pink", 5, 5);
            corners[2] = new Point("pink", 6, 1);

            Polygon Poly = new Polygon("pink", corners);
            Poly.Display();
          
        }
    }
}
