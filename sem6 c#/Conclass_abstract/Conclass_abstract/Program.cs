using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conclass_abstract
{
    abstract class shape
    {
        public abstract void calarea();
        public virtual void getval()
        {
            Console.WriteLine("get value in shape");
        }
    }
    class circle : shape
    {
        public static double r;
        public sealed override void calarea()
        {
            Console.WriteLine("area is " + (3.14*r*r));
        }
        public sealed override void getval()
        {
            Console.WriteLine("initializing r");
            r = 3;
        }
    }
    class sphere : circle
    {
        public double calvol()
        {
            Console.WriteLine(" calculating area with r:=" + r);
            return 0;
        }
        public double getval(double a)
        {
            Console.WriteLine("get value in sphere");
            return a;
        }
    }
   


    class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            sphere s = new sphere();
            c.getval();
            c.calarea();
            Console.WriteLine("in sphear"+s.getval(3) );
            Console.WriteLine("in sphear" + s.calvol());
            Console.ReadKey();

        }
    }
}
