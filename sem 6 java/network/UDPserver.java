import java.net.*;
import java.util.Scanner;
public class UDPserver {

	public static void main(String[] args) throws Exception	
	{
		DatagramSocket mysocket = new DatagramSocket(8881);
		byte mybuffer[];
		
		while(true)
		{
			Scanner Sc = new Scanner(System.in);
			System.out.println("Enter the message");
			String msg =Sc.nextLine();
			mybuffer = msg.getBytes();
			DatagramPacket mypack = new DatagramPacket(mybuffer,mybuffer.length,InetAddress.getByName("localhost"),7785);
			mysocket.send(mypack);
			
			if(msg.equals("exit"))
			{   
				break;
			}
			
		}

	}

}
