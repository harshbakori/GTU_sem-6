using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conclass_abstract

{

    class emp
    {
        String name;
        String address;
        double salary;
        int eid;
        string[] role = new string[2];


        public object this[int i]
        {
           
            set {
                if (i == 0)
                { name = (String) value; }
                else if(i == 1)
                { address = (String)value; }
                else if (i == 2)
                { salary = (double)value; }
                else if (i == 3)
                { eid = (int)value; }
                else if (i > 4)
                { role[i-3] = (string)value; }
            get
                {

                }
            }
        }
    }
    class indexer
    {
        static void Main(string[] args)
        {
            emp obj = new emp();
            obj[0] = "harsh";
            obj[1] = "bilimora";
            obj[2] = 1500000;
            obj[3] = 007;
            obj[4] = "one";
            obj[5] = "two";
            
                for(int i=0;i<6;i++)
            {
                Console.WriteLine(obj[i]);
            }

            Console.ReadKey();
        }
    }
}
