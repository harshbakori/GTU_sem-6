using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class tut3
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the total rupee");
            string rs = Console.ReadLine();
        Console.WriteLine("Enter the USD price");
            string usd = Console.ReadLine();
        Console.WriteLine("Enter the EURO price");
            string euro = Console.ReadLine();
        Console.WriteLine("Enter the Frank price");
            string frank = Console.ReadLine();

            float res;
            if (float.TryParse(usd,out res) && float.TryParse(rs,out res) )
            {
                res = float.Parse(rs)/float.Parse(usd);

                Console.WriteLine("you have " + res +" in USD");
            }
            else
            {
                Console.WriteLine("Enter valid rupies");
            }
            if (float.TryParse(euro, out res) && float.TryParse(rs, out res))
            {
                res = float.Parse(rs) / float.Parse(euro);

                Console.WriteLine("you have " + res + " in euro");
            }
            else
            {
                Console.WriteLine("Enter valid rupies");
            }
            if (float.TryParse(frank, out res) && float.TryParse(rs, out res))
            {
                res = float.Parse(rs) / float.Parse(frank);

                Console.WriteLine("you have " + res + " in frank");
            }
            else
            {
                Console.WriteLine("Enter valid rupies");
            }
            Console.ReadKey();
        }
    }
}
