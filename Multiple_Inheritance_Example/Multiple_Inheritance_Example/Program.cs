using System;
using System.Collections.Generic;

namespace Multiplie_Inheritance
{
    interface IWeapon
    {
        void Fire();
    }

    interface IThrowingWeapon : IWeapon
        //реализуем интерфейс IWeapon, чтобы не потерять
        //возможность использовать оружие с методом Fire();
        //интерфейс для метания оружия
    {
        void Throw();
    }
    class Gun : IWeapon
    //напоминаю, что класс может реализовывать
    //множество интерфейсов
    //
    //
    //

    {

        void IWeapon.Fire()
        {
            Console.WriteLine($"{GetType().Name}: Пыщ!");
        }
    }

    class LaserGun : IWeapon
    {
        void IWeapon.Fire()
        {
            Console.WriteLine($"{GetType().Name} : Лазер-Пиу");
        }
    }

    class Bazooke : IWeapon
    {
        void IWeapon.Fire()
        {
            Console.WriteLine($"{GetType().Name} :Бабах базука!");
        }
    }

    class Knife : IWeapon, IThrowingWeapon
    {
        void IWeapon.Fire()
        {
            Console.WriteLine($"{GetType().Name}: Вжик ножом, режем" );
        }

        void IThrowingWeapon.Throw()
        {
            Console.WriteLine($"{GetType().Name} : метание ножом, Фьють!");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon throwingWeapon)
         //метод метания принимает любой объект, который 
         //реализует интерфейс IThrowingWeapon
        {
            throwingWeapon.Throw();
            //и у этого объекта мы будем вызывать метод Throw
            //т.е все что попадет в этот объект мы можем метнуть
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //IInterface interface1;
            //объявление переменной у которой тип этого
            //интерфейса, соответственно в эту ссылку можно
            //присвоить класс, который реализовывает этот
            //интерфейс, далее обращаемся к переменной
            //
            //interface.Fire();
            Player player = new Player();

            IWeapon[] weapons = {new Gun(), new LaserGun(), new Bazooke(), new Knife()};

            foreach (var item in weapons)
            {
                player.Fire(item);
                Console.WriteLine();
            }

            player.Throw(new Knife());
            //обратимся к экземпляру класса Player
            //вызовем метод Throw
            //передадим туда Knife(нож)
            //ПРИМЕР РЕАЛИЗАЦИИ НОВОГО ФУНКЦИОНАЛА
        }
    }
}