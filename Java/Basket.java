import java.io.*;
import java.util.*;

public class Basket
{
	public static final int MAX_PRODUCT = 25;
	static ObjectOutputStream output;
	
	public static void openFile()
	{
		try
		{
			output = new ObjectOutputStream(new FileOutputStream("basket.ser"));
		}
		catch(IOException e)
		{
			System.out.println("Cannot open file " + e);
		}
	}
	
	public static void closeFile()
	{
		try
		{
			output.close();
		}
		catch(IOException e)
		{
			System.out.println("Cannot close file " + e);
		}
	}
	
	public static void main(String[] args)
	{
		Product aList[] = new Product[MAX_PRODUCT];
		String inLine;
		String code;
		char type;
		String name;
		String man;
		int price;
		int weight;
		int count = 0;
		
		try
		{
			Scanner input = new Scanner(new File("productdata.txt"));
			while(input.hasNext())
			{
				inLine = input.nextLine();
				String[] fields = inLine.split("#");
				code = fields[0];
				name = fields[1];
				type = code.charAt(0);
				if(type == '1')
				{
					man = fields[2];
					price = Integer.parseInt(fields[3]);
					aList[count++] = new ItemBasedProduct(code, name, price, man);
				}
				else if(type == '2')
				{
					price = Integer.parseInt(fields[2]);
					weight = Integer.parseInt(fields[3]);
					aList[count++] = new WeightBasedProduct(code, name, price, weight);
				}
				else
				{
					System.out.println("Illegal input " + inLine);
				}
			}
		}
		catch(FileNotFoundException e)
		{
			System.out.println("Could not open file " + e);
		}
		
		System.out.println("\nList of products");
		for(int i = 0; i < count; i++)
		{
			System.out.println(aList[i].getRecord());
		}
		
		openFile();
		
		try
		{
			for(int i = 0; i < count; i++)
			{
				output.writeObject(aList[i]); //gaan check exception gooi as nie in n try catch is nie.
			}
		}
		catch(IOException e)
		{
			System.out.println("Problem writing object: " + e);
		}
		
		System.out.println("Items are serializable");
		
		closeFile();
	}
}