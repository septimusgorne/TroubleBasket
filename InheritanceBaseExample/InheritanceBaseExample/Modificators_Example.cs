using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBaseExample

    //модификатор доступа protected
{
    public class A
    {
        public int publicFieled;
        private int privateFieled;
        protected int protectedField;

        public A()
        {
            Console.WriteLine(publicFieled);
            Console.WriteLine(protectedField);
            Console.WriteLine(protectedField);
        }

        public void Foo()
        {
            Console.WriteLine(publicFieled);//поле доступно
            Console.WriteLine(protectedField);//поле доступно
            Console.WriteLine(protectedField);//поле доступно
        }

    }

    class B : A
    {
        public B()
        {
            Console.WriteLine(publicFieled);//поле доступно
            //Console.WriteLine(privateFieled);//поле недоступно
            Console.WriteLine(protectedField);//поле доступно
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                A a = new A();
            Console.WriteLine(a.publicFieled);//поле доступно
            //Console.WriteLine(a.privateField);//поле недоступно
            //Console.WriteLine(a.protectedField);//поле недоступно

            a.Foo();

            B b = new B();
            b.Foo();
            }
        }
}
