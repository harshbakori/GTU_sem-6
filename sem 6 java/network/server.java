import  java.io.*;
import java.net.*;
import java.util.*;
class server{
    public static void main(String[] args) throws Exception{
        ServerSocket ss = new ServerSocket(7777);

        Socket s = ss.accept();
        System.out.println("connected");

        OutputStream objout = s.getOutputStream(); 
        PrintStream ps = new PrintStream(objout);
        InputStream objin = s.getInputStream();
        BufferedReader br = new BufferedReader(new InputStreamReader(objin));

        String str = "hii harsh";
        ps.println(str);

            Scanner sc = new Scanner(System.in);
        while(str!="exit")
        {
            System.out.println("type something");
            str = sc.nextLine();
            ps.println(str); 
            if(str.equals("done"))
            {
                while(str!="exit")
                {    
                    System.out.println(br.readLine());
                    if(br.readLine().equals("done"))
                    {break;}
                }
            }
            if (str.equals("exit"))
            {break;}
        }
        ps.close();
        ss.close();
        s.close();
        sc.close();

    }
}