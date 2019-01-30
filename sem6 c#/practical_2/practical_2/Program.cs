using System;

namespace practical_2
{
    class Program
    {

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            //////////////////////////////////celcias to ferenhite//////////////////////////////////////////
            //Console.WriteLine("enter in celcias");
            //double c = Convert.ToDouble((Console.ReadLine()));
            //double f = (c * (9 / 5)) + 32;
            //Console.WriteLine("ferenhite is : " + f );

            /////////////////////////////////ferenhite to celcias//////////////////////////////////////////
            //Console.WriteLine("enter in feranheat");
            //double f1 = Convert.ToDouble((Console.ReadLine()));
            //double c1 = (f1 - 32)*(5/9);
            //Console.WriteLine("ferenhite is : " + f);

            //////////////////////////////////decimal to binary///////////////////////////////////////////////
            Console.WriteLine("enter decimal number");
            int deci = Convert.ToInt32(Console.ReadLine());
            int a;
            String ans = null;
            while (deci != 1)
            {
            a = deci % 2;
            deci = deci / 2;
            ans = ans + Convert.ToString(a);
            }
                ans = ans + Convert.ToString(1);
            Console.WriteLine(practical_2.Program.ReverseString(ans));



            //////////////////////////////////////decimal to octal///////////////////////////////////
            Console.WriteLine("enter decimal number");
            // int deci = Convert.ToInt32(Console.ReadLine());
            // int a;
            //  String ans = null;
            ans = null;
            while (deci != 0)
            {
                a = deci % 8;
                ans = ans + Convert.ToString(a);
                deci = deci / 8;
            }
            ans = ans + Convert.ToString(0);
            Console.WriteLine(practical_2.Program.ReverseString(ans));

            Console.ReadKey();
        }
    }
}
