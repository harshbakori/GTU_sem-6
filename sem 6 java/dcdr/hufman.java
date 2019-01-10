import java.util.*;


class node
{
    int data;
    char node_c;
    node left;
    node right;
    
}
class hfcomparater implements Comparator<node>
{
    public int compare(node x,node y)
    {
        return x.data-y.data;
    }
}

class hufman
{

    public static void printcode(node root,String s)
    {
        if(root.left==null && root.right==null && Character.isLetter(root.node_c))
        {
            System.out.println(root.node_c + ":" + s);
        }
        printcode(root.left, s + "0");
        printcode(root.right, s + "1");

    }

    public static void main(String[] args) 
    {
            System.out.println("enter the number of elements");
            Scanner Sc = new Scanner(System.in);
            int n = Sc.nextInt();
            PriorityQueue<node> qu = new PriorityQueue<node>(n,new hfcomparater());
            for (int i = 0; i < n; i++) 
            {
                node hn = new node ();
                System.out.println("enter the character for ["+ i +"]");
                hn.node_c = Sc.next().charAt(0);
                System.out.println("enter probablitiy for : " + hn.node_c);
                hn.data=Sc.nextInt();
                hn.left = null;
                hn.right = null;

                qu.add(hn);
            }
            node root = null;

            while(qu.size()>1)
            {
                node x= qu.peek();
                qu.poll();

                node y= qu.peek();
                qu.poll();

                node f = new node();
                f.data = x.data-y.data;
                f.node_c = '-';

                f.left = x;
                f.right=y;
                root = f;
                qu.add(f);
            }

            printcode(root, " ");
            Sc.close();
    }
}