import java.io.*;
import java.net.*;

class client2
{ 
    public static void main(String[] args) throws Exception
    {
        Socket s = new Socket("localhost",7777);
        //Scanner sc = new Scanner(System.in);

        PrintStream ps = new PrintStream(s.getOutputStream());
        BufferedReader br = new BufferedReader(new InputStreamReader(s.getInputStream()));
        BufferedReader kbdata = new BufferedReader(new InputStreamReader(System.in));

        String serverstr,kbstr;
        while(true)
        {
            kbstr = kbdata.readLine();
            ps.println(kbstr);
            if (kbstr.equals("exit"))
            {
                break;    
            }
            serverstr = br.readLine();
            System.out.println("message from server:= " + serverstr );
        }
        s.close();
        br.close();
        kbdata.close();
    }
}