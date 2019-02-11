using System;

public class box
{
	public box()
	{
        private int l, h, b;
            public   box(int x,int y,int z)
           {
               l= x;
               h = y;
               b = z;
           }

            public box() { }

        public static box operator + (box a,box b)
        {
            box b3 = new box();
            b3.l = a.l + b.l; 
            b3.h = a.h + b.h; 
            b3.b = a.b + b.b;
            return b3;
        }
	}
    public static void main()
{

}
}
