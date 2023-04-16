////Ashton du Plessis 34202676
import java.util.*;
import java.io.*;
public class AccountList
{
	public static final int LIST_COUNT = 7;
	static ObjectOutputStream output;
	
	public static void openFile()
	{
		try 
		{
			output = new ObjectOutputStream(new FileOutputStream("accountlist.ser")); //.ser- remind me that this is a serilaized file
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
			System.out.println("Could not close file ");
		}
	}
	
	public static void main(String args[])
	{
		Account aList[] = new Account[LIST_COUNT];
		int num = 0;
		aList[num++] = new Savings("1780306403","MacArthur, D",550,550);
		aList[num++] = new Cheque("2451348675","Peters, M",430,-450);
		aList[num++] = new Savings("1678323452","Doe, J, D",500,250);
		aList[num++] = new Cheque("2357964244","Peters, D",230,-50);
		aList[num++] = new Savings("1456723452","Doyle, C",340,500);
		aList[num++] = new Cheque("2567843428","Greystroke, J",-320,-50);
		aList[num++] = new Cheque("2678975425","Shelley, M",-320,-500);
		
		System.out.println("List of statements");
		for (int i = 0;i<LIST_COUNT;i++)
		{
			System.out.println(aList[i].statement());
		}
		System.out.println("\nInterest earned(payable)");
		
		for (int i = 0; i < LIST_COUNT; i++)
		{
			System.out.println("Account number: " + aList[i].getAccNo() + " interest earned(payble) R" + aList[i].calculateInterest(10));
		}
		
		System.out.println("Cheque accounts with overdraft balances greater than overdraftlimit");
		for (int i = 0; i < LIST_COUNT; i++)
		{
			if (aList[i] instanceof Cheque)
			{
				if (aList[i].getBalance() < ((Cheque)aList[i]).getOverdraftLim())
				{
					System.out.println(aList[i].statement());
				}
			}
		}
		
		openFile();
		try
		{
			for (int i = 0; i < LIST_COUNT; i++)
			{
				output.writeObject(aList[i]);
			}
		}
		catch(IOException e)
		{
			System.out.println("Problem writing object" + e);
		}
		closeFile();
	}
}