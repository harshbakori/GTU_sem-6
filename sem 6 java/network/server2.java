
import  java.io.*;
import java.net.*;

class server2
{
    public static void main(String[] args) throws Exception
    {
        ServerSocket ss = new ServerSocket(7777);
        Socket s = ss.accept();

        System.out.println("connected");
        PrintStream ps = new PrintStream(s.getOutputStream());
        BufferedReader br = new BufferedReader(new InputStreamReader(s.getInputStream()));
        BufferedReader kbdata = new BufferedReader(new InputStreamReader(System.in));

        String clientstr,kbstr;
        while (!((clientstr = br.readLine()).equals("exit"))) 
        {
            System.out.println("Message from client:=" + clientstr);
            kbstr = kbdata.readLine();
            ps.println(kbstr);
        }
        //ss.close();
        //ps.close();
       // kbdata.close();
    }
}