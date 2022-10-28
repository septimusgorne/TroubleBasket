using System;
using System.Collections.Generic;
//using static ExampleDelegateConsole.DateTime_Extenshion;

/*namespace DelExample
{
    class Program
    {
        /*public delegate void NoParameters();

        private delegate float WithParameters(int x, bool y);

        protected delegate float WithParameters1(ref int x, bool y);

        public delegate void NoParameters();
        public static void Main()
        {
            NoParameters noPrm = new(ShowMessage);
            //тип название перемемнной = сохрани ссылку на метод ShowMessage
            noPrm();

            Console.ReadLine();
        }

        private static void ShowMessage()
        {
            Console.WriteLine("Have fun");
        }
    }
}*/

/*namespace DelReturnExample
{
    class Program
    {
        public delegate string WithParameters(string name1, string name2);  

        static void Main()
        {
            WithParameters withPrm = new(ShowMessage);

            string value = withPrm("Boris", "Ivan");

            Console.WriteLine(value);

            Console.ReadLine();
        }

        private static string ShowMessage(string name1, string name2)
        {
            Console.WriteLine($"{name1}, {name2} Have fun!");

            return "example";
        }
    }
}*/

/*namespace DelegateMulticastExample
{
    class Program
    {
        public delegate void NoParameters();

        static void Main()
        {
            NoParameters Name = new(Method);// singlecast

            Name += Method2; // multicast, maybe delete method


            Name();

            Console.ReadLine();
        }

        private static void Method()
        {
            Console.WriteLine($"Call 1 Method!");
        }

        //private static void Method() => Console.WriteLine($"Call 1 Method!");

        //сокращенная запись объявления метода
        private static void Method2() => Console.WriteLine($"Call 2 Method!");
    }
}*/

/*namespace AnonymDelegate
{
    class Program
    {
        public delegate void Awake();

        static void Main()
        {
            // Anonymous method
            Awake awake = delegate ()
            {
                Console.WriteLine($"Have fun!");
            };

            awake();

            Console.ReadLine();
        }
    }
}*/

/*namespace DelegateExampleParameters
{
    class Program
    {
        public delegate void NoParam();
        static void Main()
        {
            NoParam noPrm = delegate ()
            {
                Console.WriteLine($"Have fun!");
            };

            Test(noPrm);
        }

        private static void Test (NoParam noPrm)
        {
            noPrm();
        }
    }
}*/


/*namespace GetExample
{
    class Program
    {

        public static void Main(string[] args)
        {
            Gun gun = new Gun();// create instance class before word new "Gun()" it's constructor classS
            //gun.isLoaded = true;
            gun.Shoot(false);
        }
        class Gun
        {
            private bool isLoaded;
            public Gun()
            {
                isLoaded = false;//не заряжено
            }

            private void Reload()
            { 
                Console.WriteLine("Заряжаю");
                isLoaded = true;// заряжено
                Console.WriteLine("Заряжено");
            }

            public void Shoot(bool isLoaded)
            {
                if (!isLoaded)
                {
                    Console.WriteLine("Оружие не заряжено");
                    Reload();//call method reload
                }
                Console.WriteLine("Тратата");
                isLoaded = false;//accept value bool false
            }
        }
       
    }
}*/


/*namespace ExampleGun
{
    class Program
    {  
        class Gun
        {
            public Gun(bool isLoaded)
            {
                this.isLoaded = isLoaded;
                //isLoaded = true;
                //Reload();
            }
            private bool isLoaded;

            private void Reload()
            {
                Console.WriteLine("Заряжается");
                isLoaded = true;
                Console.WriteLine("Оружие зяражено!");
            }

            public void Shoot()
            {
                if(!isLoaded)
                {
                    Console.WriteLine("Оружие не заряжено!");
                    Reload();
                }
                Console.WriteLine("Пыщь пыщь!");
            }
        }

        public delegate void Social();//delegate



        public static void Main(string[] args)
        {
            /*List<string> socialNetwork = new List<string>();

            //List<string> socialWork = () { "sds", "dfaaaa", "hjgjhjh"}; C# 10 example short write

            socialNetwork.Add("dfdf");
            socialNetwork.Add("aaaaa");
            socialNetwork.Add("lklklk");



            if (socialNetwork.Count == 3) 
            foreach (var item in socialNetwork)
            {
                Console.WriteLine(item);
            }*/

//Gun gun = new Gun(false);
/*Gun gun = new Gun(isLoaded: false);
gun.Shoot();
//gun.Shoot();
}
}
}*/

/*namespace ExampleConstrictor
{
    class Program
    {
        class Point
        {
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            private int x;
            private int y;

            public void Draw()
            {
                Console.WriteLine($"Value X:{x}, Value Y:{y}");
            }
        }
          public static void Main(string[ ] args)
        {
            Point point = new Point(5, 2);
            point.Draw();
        }
    }
}*/

/*namespace ExamplePeregruz
{
    class Program
    {
        class Student
        {
            private string firstName;
            public string middleName;
            public string lastName;
            private DateTime birthday;
            public Student(string lastName, DateTime birthday)
            {
                this.lastName = lastName;
                this.birthday = birthday;
            }

            public Student(string lastName, string firstName, string middleName, DateTime birthday) : this (lastName, birthday)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.middleName = middleName;
                this.birthday = birthday;
            }

            public Student(Student student) 
            {
                this.firstName = student.firstName;
                this.middleName = student.middleName;
                this.lastName = student.lastName;
                this.birthday = student.birthday;

            }
            public void Print()
            {
                Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}\nОтчество: {middleName}\nДень Рождения: {birthday}\n"); 
            }

            public void SetLastName(string lastName)
            {
                this.lastName = lastName;
            }

        }

        public static void Main(string[] args)
        {
            //Student student = new Student("Якобюк", new DateTime(1992,07,21));
            Student student1 = new Student("Артур", "Якобюк", "Андреевич", new DateTime(1992, 07, 21));
            //Student student2 =  student1;

            //student1.SetLastName("$$$$$$$");///Fatal ERROR
            Student student2 = new Student(student1);// copy data student21
            student1.SetLastName("fgfgfg");

            student1.Print();

            Console.WriteLine();

            student2.Print();
        }
    }
}*/

/*namespace ExampleGetSet
{

    /*private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }*/

/*class Program
{
    class Person
    {
        private string name = "Undefined";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public static void Main(string[] args)
    {
        Person person = new Person();

        person.Name = "Artur";

        string personName = person.Name;
        Console.WriteLine(personName);
    }
}
}*/

/*namespace GetSetExample
{
    class Program
    {
        class Person
        {
            private int age = 1;
            public int Age
            {
                set
                {
                    if (value < 1 || value > 120)
                        Console.WriteLine("Введите корректный возраст");
                    else
                        age = value;    
                }
                get { return age; }
            }
        }

        public static void Main(string[] args)
        {
            Person person = new Person();
            //person.Age = int.Parse(Console.ReadLine());
            //Console.ReadLine();
            person.Age = -2;
            Console.WriteLine(person.Age);
        }
    }
}*/

/*namespace AutoProperties
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person tom = new ();
            Console.WriteLine(tom.Name);
            Console.WriteLine(tom.Age);
        }
        class Person
        {
            public string Name { get; set; } = "Tom";
            public int Age { get; set; } = 37;
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}*/

/*namespace GetExamle
{
    class Point
    {
        private int x;

        public void SetX(int x)//accept date, присвоить значение полю X
        {
            this.x = x;
        }

        public int GetX()//получить доступ к полю класса X
        {
            return x;//return X
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(5);
        }
    }
}*/


// Пишем класс Point, в котором диапазон значений, которое может принимать 
// поле X ограничено 1 to 5
/*namespace PointExample
{
    class Program
    {
        class Point
        {
            private int x;

            public void SetX(int x)
            {
                if (x < 1)
                {
                    this.x = 1;
                    return;
                }
                if ( x > 5)
                {
                    this.x = 5;
                    return;
                }
                this.x = x;
            }

            public int GetX()
            {
                return x;
            }

        }
        public static void Main(string[] args)
        {
            Point point = new Point();
            point.SetX(10);

            int x = point.GetX();//can use Brakepoint
            Console.WriteLine(x);
        }
    }
}*/

/*namespace ProverkaGetExample
{
    class Program
    {
        class Point
        {
            private int x;

            public int SetX(int x)// 12 do 20
            {
                if (x < 12)
                {
                    this.x = 12;
                }
                if (x > 20)
                {
                    this.x = 20;
                }
                return x;
            }
            public int GetX()
            {
                return this.x;
            }
        }
        public static void Main()
        {
            Point point = new Point();
            point.SetX(5);
            int x = point.GetX();
            Console.WriteLine(x);
        }
    }
}*/

/*namespace Example
{
    class Program
    {
        class Point
        {
            private int x;

            public void SetC(int x)// 20 to 30
            {
                if(x < 20)
                {
                    this.x = 20;
                }
                if (x > 30)
                {
                    this.x = 30;
                }
                 this.x = x;
            }
            public int GetC()
            {
                return this.x;
            }


            private int y;

            public int Y
            {
                get 
                {
                    return y; 
                }
                set 
                { 
                    if (value < 20) 
                    { 
                        y = 20;
                        return;
                    }
                    if (value > 30)
                    {
                        y = 30;
                        return;
                    }
                    y = value;
                }
            }

            /*private int z = 22;

            public int Z
            {
                get { return z; }
                private set { z = value; }
            }*/

/*public int Z { get; set; }// snippet "prop"


}

public static void Main(string[] args)
{
/*Point point = new Point();
point.SetC(18);
int x = point.GetC();
Console.WriteLine(x);*/

/*Point point = new Point();
point.Y = 10;
int y = point.Y;
Console.WriteLine(y);*/

/*Point point = new Point();
int z = point.Z;
Console.WriteLine(z);*/

/*Point point = new Point();
point.Z = 1;
int z = point.Z;
Console.WriteLine(z);
}
}
}*/


/*namespace staticClassExmaple
{
    class Program
    {
        class MyClass
        {
            public int a;

            public static int b;

            public void SetB(int b)
            {
                MyClass.b = b;
            }

            public void PrintB()
            {
                Console.WriteLine(b);
            }
        }

        public static void Main()
        {
            MyClass myClass1 = new MyClass();
            myClass1.a = 145;

            MyClass myClass3 = new MyClass();
            myClass3.SetB(10);
            myClass3.PrintB();
            //MyClass.b = 6;

            MyClass myClass2 = new MyClass();
            myClass2.a = 22;
        }
    }
}*/

/*namespace ExampleStaticMethod
{
    class Program
    {
        class MyClass
        {
            private static int a;
            private int b;
            public static void Foo()
            {
                Console.WriteLine("Method static");
            }
            public void Bar()
            {
                Console.WriteLine("Simple method");
            }

            private static int c;

            public static int Prop
            {
                get { return c; }
                set { c = value; }
            }

            public static int Z { get; set; }
        }
        public static void Main(string[] args)
        {
            MyClass.Foo();//whithout create instatnce class 

            MyClass myClass = new MyClass();//create link for instance class  
            myClass.Bar();// instatnce acess method

            //MyClass myClass1 = new MyClass();
            //myClass1.Prop = 3;//dont acess because static method Prop!

            MyClass.Prop = 3;//acess

            MyClass.Z = 4;//acess autoproperties(prop + tab + tab)
        }
    }
}*/

/*namespace CounterExample
{
    class Program
    {
        class MyClass
        {
            public MyClass()
            {
                count++;
            }
            private static uint count;

            public static uint Counter
            {
                get { return count; }
                private set { count = value; }
                //or comments////set { count = value; }
            }

            public static uint GetCounter()
            {
                count = 5;
                return count;
            }

            public uint GetCountnoStatic()
            {
                //acess 
                return count;
            }

        }

        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();

            //MyClass.Counter = 1000;

            myClass2.GetCountnoStatic();

            Console.WriteLine(MyClass.Counter);

            Console.WriteLine(MyClass.GetCounter());
        }
    }
}*/

/*namespace StaticConstructor
{

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor");
        }

        static MyClass()// static constructor
        {
            Console.WriteLine("Static Constructor");
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyClass.Foo();

            MyClass myClass = new MyClass();

            new MyClass();
            new MyClass();
            new MyClass();
        }
    }
}*/

/*namespace DbRepository
{
    class DbRepository
    {
        private static string connectionString = "local DB";

        static DbRepository()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            
            configurationManager.GetConnectionString();
        }
        public void GetData()
        {
            Console.WriteLine("Использую " + connectionString);
        }

    }
    class ConfigurationManager
    {
        public string GetConnectionString()
        {
            return "local DB";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            DbRepository dbRepository = new DbRepository();
           
            dbRepository.GetData();
        }
    }
}*/


/*namespace StaticClassExample
{
    static class MyClass
    {
        static MyClass()
        {

        }
        public static void Foo()
        {
            Console.WriteLine("Method Foo");
        }

        public static void Bar()
        {
            Console.WriteLine("Method Bar");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();impossible
            MyClass.Foo();
            //Math.
        }
    }
}*/

//namespace ExtensionMethodExample
/*namespace ExampleDelegateConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            //currentDateTime.Print();

            ///??DayOfWeek Now = new DayOfWeek();
            ///??Now = DayOfWeek.Now;

            //???DateTime dateTime = new DateTime();
            //???dateTime = DateTime.Now;

            if (currentDateTime.IsDayOfWeek(DayOfWeek.Monday))
            {
                Console.WriteLine($"Сегодня понедельник! {(DayOfWeek.Monday)}");
            }
            else
                Console.WriteLine($"Сегодня не понедельник! {DayOfWeek.Monday}");

            DateTime.Now.Print();
        }
    }
}*/



/*namespace PartialExample
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
        /*public void PrintFullName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName);
        }*/

//}

/*class Program
{ 
    public static void Main(string[] args)
    {
        Person person = new Person("Artur", "Yakobyuk");
        person.PrintFullName();
    }
}
}*/

/*namespace PartialExample
{
    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public partial string GetName();//??!!!partial example, strange solved
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Artur", "Vasechkin");
            person.PrintName();
        }
    }
}*/

/*namespace InitializeExample
{
    class Cat
    {
        public int  Age { get; set; }
        public string Name { get; set; }

        public Cat()
        {

        }
        public Cat(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //разные варианты инициализации
            Cat cat1 = new Cat();
            cat1.Name = "Барсик";
            cat1.Age = 3;

            Cat cat2 = new Cat 
            {
                Age = 5,
                Name = "Мурун"
            };

            Cat cat3 = new Cat("Васька")
            {
                Age = 4
            };
        }
    }
}*/

/*namespace ExampleInstatnce
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat("Вася");
            cat1.Age = 5;

            Cat cat2 = new Cat()
            {
                Name = "Мурка",
                Age = 4
            };
        }
    }
}*/
/*namespace Inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /*public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }*/

        /*public void PrintName()
        {
            Console.WriteLine($"Меня зовут {FirstName}");
        }

        public void PrintFullName(Person person)
        {
            Console.WriteLine($"\nИмя: {person.FirstName} \nФамилия: {person.LastName}");
        }
    }

    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine($"Я учусь! {FirstName}");
        }
    }

    class Program
    {

        static void PrintFullName(Person person)
        {
            Console.WriteLine($"\nИмя: {person.FirstName} \nФамилия: {person.LastName}");
        }
        public static void Main(string[] args)
        {
            Teacher teacher = new Teacher { FirstName = "Мартин", LastName = "Дербент" };
            Student student = new Student { FirstName = "Лекс", LastName = "Лютер" };

            Person[] people = { teacher, student };
            PrintPerson(people);

            Person person = new Student //("Артур", "Васечкин");
            {
                FirstName = "Артур",
                LastName = "Васечкин"
            };
            person.PrintName();
            
            PrintFullName(person);

            /*Person person2 = new Person //("Артур", "Васечкин");
            {
                FirstName = "Антон",
                LastName = "Чигур"
            };

            person2.PrintName();*/
            /*Student student = new Student
            {
                FirstName = "Artur",
                LastName = "Vasechkin"
            };
            student.PrintName();
            student.Learn();

            //instance Person IN STUDENT EXAMPLE

            Person person1 = new Student
            {
                FirstName = "OWAWA",
                LastName = "EWEWE"
            };
            person1.PrintName();*/

       /* }
    
        static void PrintPerson(Person[] people)
        {
            foreach (var person in people)
            {
                person.PrintFullName(person);
            }
        }
    }
}*/

/*namespace ConstReadOnlyExample
{
    class MyClass
    {
        public const int MAX_VALUE = 42;

        public const int a = 1;
        public const double PI = 3.14;
        public const string MY_ERROR = "some error!";

        public readonly int _b;
        public readonly int c;
        public static readonly int d = 5;

        public MyClass(int b)
        {
            _b = b;
            c = 4;     
        }

        public static void Foo()
        {
            Console.WriteLine(PI);
            Console.WriteLine(MY_ERROR);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass(3);
            //MyClass.d();
        }
    }
}*/





