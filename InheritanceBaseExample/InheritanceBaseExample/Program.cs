/* System;

/*namespace Inheritance
{
    class Point2D : Object
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Вызван конструктор класса Point2D{" " + x + " " +  y}");
        }
        public int X { get; set; }
        public int Y { get; set; }

        public void Print2D()
        {
            Console.WriteLine("X:\t " + X);
            Console.WriteLine("Y:\t " + Y);
        }

        public void Print()
        {
            Console.WriteLine("First method class Point2D");
        }
    }

    class Point3D : Point2D
    {
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine($"Вызван конструктор класса Point3D{" " + x + " " +  y + " " +  z}");
        }
        public int Z { get; set; }

        public void Print3D()
        {
            base.Print2D();
            Console.WriteLine("Z:\t " + Z);
        }

        public void Print()
        {
            Console.WriteLine("First method class Point3D");
        }
    }

    class Program
    {
        public void Main(string[] args)
        {
            Point3D point3D = new Point3D(3, 6, 9);
            //point3D.Print2D();
            point3D.Print3D();
            point3D.Print();

            
        }
    }
}*/

/*namespace AsIsExample
{
    class Point : MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int x, y;
        /*public Point()
        {
            X = y;
            Y = x;
        }*/
        /*public void Print()
        {
            Console.WriteLine("Привет objPoint!");
            Console.WriteLine($"Поле X: {X}");
            Console.WriteLine($"Поле Y: {Y}");
        }
 
    }

    /*class PointX : MyClass
    {
        public int Z { get; set; }
        public int V { get; set; }

        public PointX(int z, int v)
        {
            Z = z;
            V = v;
        }
    }*/

   /* class MyClass 
    {

    }

    class Program
    {

        public static void Foo(object obj)
        {
            Point point = obj as Point;//преобразовываем объект obj в тип Point

            if (point != null)
            {
                point.Print();
            }
            //Логика as - если в входящем параметре obj
            //действительно был Point
            //то метод вызовется, если было что-то иное,
            //например строка - то будет NULL - соответственно
            //метод не вызовется
            //
        }

        static void Bar(object obj)
        {
            if(obj is Point)
            {
                Point point = (Point)obj;

                point.Print();
            }
        }

        static void BarE(object obj)
        {
            if (obj is Point point)
                //Если obj это Point
                //то
                //Присвоить в экземпляр point
                //
            {
                point.Print();
            }
        }
        static void Main(string[] args)
        {
            /*object obj = new Point { X = 3, Y = 5};

            //Point point = (Point)obj;//указывает на то, что 
            //объект obj это на самом деле Point, нужно для 
            //того, чтобы можно было обратиться к классу Point
            //для вызова метода Print();

            //point.Print();*/

            //----------------------------------


            /*      object obj = new Point { X = 3, Y = 5 };

                    Point point = (Point)obj;

                    point.Print();          */


            //----------------------------------

         /*   object obj = new Point { X = 3, Y =  5 };//{ x = 3, y = 5 };
            //object obj = "string";//object don't NULL

            //Point point = (Point)obj;

            //Foo(obj);

            //Bar(obj);

            BarE(obj);
            //----------------------------------

            //MyClass obj1 = new Point { X = 3, Y = 5 };
            //MyClass obj2 = new PointX(4, 8) { Z = 4, V = 6 };

            /*object obj4 = new Point { X = 10, Y = 7 };
            Point point = (Point)obj4;
            point.Print();
        }
    }
}*/