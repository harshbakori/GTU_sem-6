using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter contry");
            String contry = Console.ReadLine();
            Console.WriteLine("The name is " + name + "from" + contry);
            Console.ReadKey();
        }
    }
}
