import java.net.*;

public class lab1 
{

	public static void main(String[] args) throws Exception
	{
		// TODO Auto-generated method stub

		URL OBJ = new URL ("https://192.168.15.91/auth.html?cid=-2");
		System.out.println("Protocall:- " + OBJ.getProtocol());
		System.out.println("host:- " + OBJ.getHost());
		System.out.println("file:- " + OBJ.getFile());
		System.out.println("path:- " + OBJ.getPath());
		System.out.println("External form:- " + OBJ.toExternalForm());
	}

}
