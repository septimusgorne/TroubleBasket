using System;

namespace Abstract_Example
{

   /* interface IHasInfo
    {
        void ShowInfo();
    }*/

    interface IWeapon
    {
        abstract int Damage { get; }
        //также указываем свойства(по умолчанию public)
        void Fire();
        // указываем метод Fire
    }

    //реализуем интерфейс с сигнатурой ShowInfo
    abstract class Weapon :  IWeapon//, IhasInfo
        //abstract weapon
    {
        public abstract int Damage { get; }

        public abstract void Fire();
        //!!!! abstract method this is than!
        public void ShowInfo()
        {
            //Fire();//for example
            Console.WriteLine($"Тип оружия: {GetType().Name} Урон: { Damage}");
            //name of type data(base method GetType -- base object "Object"
        }
    }
    class Gun : Weapon
    {
        //public override int Damage { get { return 5; } }

        //------------------OR-------------------------//

        public override int Damage => 5;

        //lyambda - function
        public override void Fire()
        {
            Console.WriteLine("Пысчщь!");
            //throw new NotImplementedException();
        }
    }
    class LaserGun : Weapon
    {
        public override int Damage => 2;

        public override void Fire()
        {
            Console.WriteLine("Liu-Liu");
            //throw new NotImplementedException();
        }
    }
    class Bazooke : Weapon
    {
        public override int Damage => 10;

        public override void Fire()
        {
            Console.WriteLine("Buuuhwgrh");
            //throw new NotImplementedException();
        }
    }
    class Player 
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();//StrikeS
        }

        /*public void CheckInfo(Weapon weapon)
         * смотрит только то, что унаследовано от класса
         * Weapon
        {
            weapon.ShowInfo();
        }*///реализация без интерфейса


        public void CheckInfo(Weapon weapon)
            //(IhasInfo hasinfo)
            //принимает ссылку на интерфейс и
            //таким образом получает информацию
            // о любом объекте, который реализовывает
            //этот интерфейс
            // в параметрах указываем ссылку на любой объект
            // которую указывает HasInfo
        {
            weapon.ShowInfo();
            //hasinfo.ShowInfo();
        }
    }

    /*class Box : IHasInfo
    {
        void IHasInfo.ShowInfo()
        {
            Console.WriteLine("Йа коробко!");
        }
    }*/
    class Program
    {
        public static void Main(string[] args)
        {
            //Player player = new Player();
            /*Player player = new Player();
            Gun gun = new Gun();
            player.Fire(gun);

            Console.WriteLine();
            LaserGun laser = new LaserGun();
            player.Fire(laser);

            Console.WriteLine();
            Bazooke bazooke = new Bazooke();    
            player.Fire(bazooke);*/


            Player player = new Player();

            Weapon[] inventory = {new Gun(), new LaserGun(), new Bazooke()};


            foreach (var item in inventory)
            {
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
            //player.CheckInfo(new Box());
            //передаем экземпляру player метода CheckInfo,
            //в который передаем Box, сокращенная запись для
            //создания экземпляра и передачи ему метода
        }
    }
}
