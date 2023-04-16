//Ashton du Plessis 34202676
import java.io.*;

public class ReadData
{
	ObjectInputStream input;
	
	public void openFile()
	{
		try 
		{
			input = new ObjectInputStream(new FileInputStream("accountlist.ser")); //.ser- remind me that this is a serilaized file
		}
		catch(IOException e)
		{
			System.out.println("Cannot open file ");
		}
	}
	
	public void readFile()
	{
		Account record; 
		try
		{
			System.out.println("\n List of statements");
			while(true)
			{
				record = (Account) input.readObject();
				System.out.println(record.statement());
			}
		}
		
		catch(EOFException e)
		{
			System.out.println("End of file reached."); //will get out of the endless loop when it is the end of the file.
		} 
		
		catch(IOException e)
		{
			System.out.println("Error reading record: " + e); //will get out of the endless loop when it is the end of the file.
		} 
		
		catch (Exception e)
		{
			System.out.println("ERROR!!: " + e);
		}
	}
	
	public void closeFile()
	{
		try
		{
			input.close();
		}
		catch(IOException e)
		{
			System.out.println("Cannot close file.");
		}
	}
	
	public static void main(String args[])
	{
		ReadData test = new ReadData();
		test.openFile();
		test.readFile();
		test.closeFile();
	}
}