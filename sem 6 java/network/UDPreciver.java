import java.net.*;
import java.util.Scanner;

public class UDPreciver {
	public static void main(String[] args) throws Exception 
	{
		DatagramSocket mysocket = new DatagramSocket(7785);
		byte mybuffer[] = new byte [2000];
		byte mybuffer1[];
		while(true)
		{
			DatagramPacket mypack = new DatagramPacket(mybuffer,mybuffer.length,InetAddress.getByName("localhost"),1337);
			mysocket.receive(mypack);
			String msg = new String(mypack.getData(),0,mypack.getLength());
			String string = " :- \n \t \t";
            System.out.println("Message from " + InetAddress.getByName("localhost") + string + msg);
            
            
            Scanner Sc = new Scanner(System.in);
			System.out.println("Enter the message by typing send");
            String msg1 =Sc.nextLine();

			    mybuffer1 = msg1.getBytes();
			    mysocket.send(mypack);
            
            
            if(msg.equals("exit"))
			{
				break;
			}
			
		}

	}

}
