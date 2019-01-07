import java.io.*;
import java.net.*;
import java.util.*;
class client
{ 
    public static void main(String[] args) throws Exception
    {
        Socket s = new Socket("localhost",7777);
        Scanner sc = new Scanner(System.in);
        InputStream objin = s.getInputStream();
        BufferedReader br = new BufferedReader(new InputStreamReader(objin));
        OutputStream objout = s.getOutputStream();
        PrintStream ps = new PrintStream(objout);

        String str;
        while((str = br.readLine())!="exit")
        {
            System.out.println("from server: " + str);
            if (str.equals("done"))
            { 
                while(str!="exit")
                {    
                   System.out.println("type somithing");
                   str = sc.nextLine();
                   ps.println(str);
                }
            }
            
        }
//////////////////////////////////////////////////////////////
        br.close();
        s.close();
        sc.close();
    }

}