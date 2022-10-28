using System;

//Реализация интерфейса
//
//Вопрос такой: Может ли класс реализовать 2 интерфейса,
//у которых объявлено 2 одинаковых метода
//реализация ниже:

interface IFirstInterface
{
    void Action();
}

interface ISecondInterface
{
    void Action();
}

class MyClass : IFirstInterface , ISecondInterface
{
    //обязательно реализовывать то же самое, что объявлено в 
    //интерфейсе, в данном случае, необходимо реализовать 
    //метод Action(). Модификатор public, так как в интерфейсах
    //метод public по умолчанию
   public void Action()
    {
        Console.WriteLine("My class Action...");
    }
}

class MyOtherClass : IFirstInterface , ISecondInterface
{
    //явная реализация интерфейсов
    //если необходимо реализовать интерфейс явно, мы должны
    //указать для какого конкретно интерфейса мы должны реализовать
    //метод
    void IFirstInterface.Action()
    {
        Console.WriteLine("MyOtherClass IfirstInterface.Action...");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine("MyOtherClass ISecondInterface.Action...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //MyClass myClass = new MyClass();
        //Foo(myClass);
        //Bar(myClass);

        //Console.WriteLine();

        MyOtherClass myOtherClass = new MyOtherClass();
        //Foo(myOtherClass);
        //Bar(myOtherClass);

        Console.WriteLine();

        //IFirstInterface firstInterface = myOtherClass;
        //firstInterface.Action();
        //создаем ссылку в которой будет тип интерфейса
        //и присвоить экземпляр класса, который этот интерфейс
        //и реализовывает, так же как и с наследованием
        //ссылка у которой тип базового класса может хранить
        //в себе экземпляры наследников и через эту ссылку мы
        //можем вызвать метод который нам нужен

        ((IFirstInterface)myOtherClass).Action();

        //привидение к типу IFirstInterface и вызвали метод Action
        ((ISecondInterface)myOtherClass).Action();

        //object obj = new object();//нельзя приводить явно типы
        //которые не имеют отношения к интерфейсу
        //((IFirstInterface)obj).Action();//

        //object obj2 = new object();

        object obj = new object();
        if(obj is IFirstInterface firstInterface)
        {
           firstInterface.Action();
        }
        else
        {
            Console.WriteLine($"Возможен Exception с типом {obj}");
        }
    }

    static void Foo(IFirstInterface firstInterface)
    //принимает в параметры тип, который реализует IFirstInterface 
    {
        firstInterface.Action();
    }

    static void Bar(ISecondInterface secondInterface)
    {
        secondInterface.Action();
    }
}