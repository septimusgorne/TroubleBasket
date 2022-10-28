using System;

namespace Get_Set
{
    /*class MyClass
    {
        private int num;
        private int max;
        private int min;

        public MyClass(int a, int b)
        {
            min = a;
            max = b;

            code = (min + max) / 2;
        }

        public int code
        {
            get { return num; }
            set 
            {
                if (value < min) 
                    num = min;
                
                else if (value > max) 
                    num = max;
                else
                    num = value;
            }

        }
    }*/
    class UsingPropsDemo
    {
        static void Main()
        {
            MyClass obj = new MyClass(1, 9);
            
            obj.code = -3;
            Console.WriteLine("Propetry code: " + obj.code);
            
            obj.code = 7;
            Console.WriteLine("Property code: " + obj.code);
            
            obj.code = 20;
            Console.WriteLine("Property code: " + obj.code);
            
            obj.code = -10;
            Console.WriteLine("Property code: " + obj.code);
        }
    }

    
    class MyClass
    {
        private int num;
        private int min;
        private int max;

        public MyClass(int a, int b)
        {
            min = a;
            max = b;

            code = (min + max) / 2;
        }

        public int code
        {
            get
            {
                return num;
            }

            set
            {
                if (value < min)
                    num = min;
                else if (value > max)
                    num = max;
                else
                    num = value;
            }
        }
    }
}