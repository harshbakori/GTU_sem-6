using System;

public class cutex : Exception
{
    public cutex(string s)
    {
        Console.WriteLine("error msg" + s);
    }
}

public class box
{
    
    private int l, h, b;
    public box(int x, int y, int z)
    {
        l = x;
        h = y;
        b = z;
    }

    public box() { }

    public static box operator +(box a, box b)
    {
        box b3 = new box();
        b3.l = a.l + b.l;
        b3.h = a.h + b.h;
        b3.b = a.b + b.b;
        return b3;
    }

        public static void Main(String[]args)
        {
            box b1 = new box(1, 2, 3);
            box b2 = new box(1,7,9);
            box b3 = new box();
            b3 = b1 + b2;

            Console.WriteLine("l="+b3.l);
            Console.WriteLine("h="+b3.h);
            Console.WriteLine("b="+b3.b);
        Console.WriteLine("enter age");
        int age = Convert.ToInt32(Console.ReadLine());
        try
        {
            if(age<0)
            {
                throw(new cutex("enter proper age"));
            }
            else
            { Console.WriteLine("okk good!!"); }
        }
        catch(cutex e)
        {
            Console.WriteLine(e.Message);
        }

            Console.ReadKey();
     }
}
