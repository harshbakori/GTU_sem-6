using System;

namespace Consoleapphelper.cs
{
    class b
    {
        public virtual void show()
        //public void show()     hiding
        {
            Console.WriteLine("base show");
        }
    }
    class c : b
    {
        public override void show()
        //public new void show()     hiding
        {
            //base.show();
            Console.WriteLine("derived show");
        }
    }


    class Program
    {
        void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        abstract class ab
        {
            public int i = 10;
            public abstract void show1();
            public void display() {
                Console.WriteLine("abstract display");
            }
        }
        class a : ab
        {
            public override void show1()
            {
                Console.WriteLine("overridden abstract class");
            }
        }
        static void Main()
        {
            Program p = new Program();
            p.Sum(7, 7);
            b ab = new c();
            ab.show();
            Console.WriteLine("now using abstrac class");
            a a = new a(); 
            a.show1();
            a.display();
            Console.ReadKey();
        }
    }
}