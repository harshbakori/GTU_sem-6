using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conclass_abstract
{
    class newa
    {
        private String name1;
        private String name2;
        private double name3;

        public String Name1
        {
            set
            {
                this.name1 = value;
            }
            get
            {
                return name1;
            }
        }
        public String Name2
        {
            set
            {
                this.name2 = value;
            }
            get
            {
                return name2;
            }
        }
        public double Name3
        {
            set
            {

                if (value.ToString().Length < 5)
                {
                    Console.WriteLine("invalid enroll ");
                    this.name3 = 00;
                }
                else
                {
                this.name3 = value;
                }
            }
            get
            {
                return name3;
            }
        }
    }

    class employee
    {
        public static void Main(string[] args)
        {
        newa n = new newa();
            n.Name1 = "harsh";
            n.Name2 = "harsh2";
            n.Name3 = 12345;

            Console.WriteLine("name1 is : "+ n.Name1);
            Console.WriteLine("name2 is : "+ n.Name2);
            Console.WriteLine("name3 is : "+ n.Name3);

            Console.ReadKey();

        }
    }
}
