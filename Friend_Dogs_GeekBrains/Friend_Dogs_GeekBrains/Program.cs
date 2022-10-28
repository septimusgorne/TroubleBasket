using System;

namespace Friend_Dog
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int distance = 10000;
            int firstFriendSpeed = 1;
            int secondFriendSpeed = 2;
            int dogSpeed = 5;
            int friend = 2;
            int time  = 1;

            while (distance > 10)
            {  
                if(friend == 1)
                {
                    time = distance/(firstFriendSpeed + dogSpeed);
                }
                if(friend == 2)
                {
                    time = distance /(secondFriendSpeed + dogSpeed);
                }
                distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
                count = count + 1;
            }
            Console.WriteLine(count);
        }
    }
}