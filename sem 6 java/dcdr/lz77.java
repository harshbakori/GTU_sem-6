import java.util.*;

class lz77
{
    public static void main(String[]args)
    {
    
        int i =0;
        char a[] = {'a','b','a','a','b','a','b','a','b','b','a'};
        char sb[] = new char[5];
        char lb[] = new char[3];
        
        for(i=0;i<2;i++)
        {

            
            for(i=0;i<a.length;i++) 
            {
                if(i<lb.length)
                lb[i]=a[i];//first initialization into lb
                if(i<a.length-1)
                a[i]=a[i+1];//shift the a
            }
            System.out.println("lb 2= ");
        System.out.println(lb);

       // char x[] = new char[0];char temp=x[0];
        //for(i=0;i<lb.length;i++)
        //{
        //    x[i]=x[i+1];
        //}
        //x[i] =temp;

            System.out.println("<0,0,"+sb[0]+">");
            System.out.println(a);
            
            
            for(i=0;i<2;i++)//shift one value
            {
                lb[i]=lb[i+1];
                if(sb[i+1]!='\0')
                {
                    sb[i+1]=sb[i];///sb shifted
                }
            }
            System.out.println(lb);
            System.out.println(sb);
        }
        
             
       
            
            //search sb
            //enter into output
            // transfer to sb
        }
    }