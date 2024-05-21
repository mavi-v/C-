using System;

namespace S.week9
{
    class Program
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
                Display();
                Console.WriteLine();
            }
        }
        public class Point : GraphicalObject
        {
            private int x, y;
            public Point(string col, int _x, int _y) : base(col)
            {
                x = _x;
                y = _y;
            }

            public override void Display()
            {
                Console.Write(", (" + x + "," + y + ")");
            }
        }

        public class Line : GraphicalObject
        {
            private Point startPoint, endPoint;

            public Line(string col, Point a, Point b) : base(col)
            {
                startPoint = a;
                endPoint = b;
            }

            public override void Display()
            {
                startPoint.Display();
                endPoint.Display();
            }

        }

        public class Polygon : GraphicalObject
        {
            private Line[] lines;

            public Polygon(string col, Point[] pts) : base(col)
            {
                lines = new Line[pts.Length];
                if (pts != null && pts.Length >= 3)
                {
                    Point first = pts[0];
                    Point last = pts[pts.Length - 1];
                    int i = 0;
                    for (i = 0; i < pts.Length - 1; i++)
                        lines[i] = new Line(color, pts[i], pts[i + 1]);

                    lines[i] = new Line(color, last, first);
                }
            }

            public override void Display()
            {
                foreach (Line line in lines)
                    line.Display();
            }
        }

        public class Figure : GraphicalObject
        {
            public GraphicalObject[] gObjects; //or private doesn't really matter
            int MAX_SIZE = 100;
            private int nrOfObjs = 0;

            public Figure(string col, Point gObjs) : base(col)
            {
                color = col;

                gObjects = new GraphicalObject [MAX_SIZE];
                gObjects[0] = gObjs;
                if (gObjs != null)
                {
                    
                    nrOfObjs = 1;
                }
                /*if (gObjs != null && MAX_SIZE >= 3)
                {
                    Point first = gObjs;   
                }*/
            }

            public Boolean Add(GraphicalObject one)
            {
                int i = 0;
                while (i < MAX_SIZE && gObjects[i] != null)
                    i++;
                if (i < MAX_SIZE)
                {
                    gObjects[i] = one;
                    nrOfObjs++;
                    return true;
                }

                return false;
                
            }

            public Boolean RemoveFrom(int index)
            {
                if (gObjects[index] != null)
                {
                    gObjects[index] = null;
                    nrOfObjs--;
                    return true;
                }
                return false;
            }

            public GraphicalObject GetFrom(int index)
            {
                if (index >= 0 && index < MAX_SIZE)
                    return gObjects[index];
                return null;
            }


            public override void Display()
            {
                Console.WriteLine();
            }
        }

        



        static void Main(string[] args)
        {
            Figure fig = new Figure("red", new Point("green", 3, 4));
            fig.Display();

            //try and catch for when there are wront things so the course doesn't crash
        }
    }
}
