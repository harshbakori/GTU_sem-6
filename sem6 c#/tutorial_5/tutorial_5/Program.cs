using System;

namespace tutorial_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }

            Console.ReadKey();

            using System;
            using System.Collections.Generic;
            using System.Text;

//namespace tutorial_5
  //  {
    //    class Tut_2
      //  {
            public void Main()
            {
                Console.WriteLine("Enter name");
                String name = Console.ReadLine();
                Console.WriteLine("Enter contry");
                String contry = Console.ReadLine();
                Console.WriteLine("The name is " + name + "from" + contry);
                Console.ReadKey();
            }
        //}
    //}
//
//}
    }
}
