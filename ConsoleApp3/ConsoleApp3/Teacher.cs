using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    class Teacher : Employee
    {
        public void Teach()
        {
            Console.WriteLine("Я Учитель!");
        }
    }
}
