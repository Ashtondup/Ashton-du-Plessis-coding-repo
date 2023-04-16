//Ashton du Plessis 34202676
import java.util.*;

public class SortTest
{
	public static void main(String args[])
	{
		Account aList[] = new Account[7];
		aList[0] = new Savings("1780306403","MacArthur, D",550,550);
		aList[1] = new Cheque("2451348675","Peters, M",430,-450);
		aList[2] = new Savings("1678323452","Doe, J, D",500,250);
		aList[3] = new Cheque("2357964244","Peters, D",230,-50);
		aList[4] = new Savings("1456723452","Doyle, C",340,500);
		aList[5] = new Cheque("2567843428","Greystroke, J",-320,-50);
		aList[6] = new Cheque("2678975425","Shelley, M",-320,-500);

		
		System.out.println("List of statements before sort");
		for (int i = 0;i<7;i++)
		{
			System.out.println(aList[i].statement());
		}
		
		Arrays.sort(aList);
		  
		System.out.println("\nList of statements after sort");
		for (int i = 0; i<7; i++)
		{
			System.out.println(aList[i].statement());
		}
	}
}