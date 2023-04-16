import java.util.*;

public class TestAccounts
{
	public static void main(String[] args) 
	{
		Account accs[] = new Account[20];
		char type;
		String no;
		int val1, val2;
		int num = 0;
		
		Scanner input = new Scanner(System.in);
		
		while(input.hasNext())
		{
			type = input.next().charAt(0);
			no = input.next();
			val1 = input.nextInt();
			val2 = input.nextInt();
			
			if(type == 'S')
				accs[num++] = new Savings(no, val1, val2);
			else
				accs[num++] = new Cheque(no, val1, val2);
		}
		
		/*accs[0] = new Savings("12345679", 500, 450);
		accs[1] = new Cheque("12345678", -500, -10000);
		accs[2] = new Cheque("34567875", 5500, -1100);
		accs[3] = new Savings("45679123", 2500, 420);
		accs[4] = new Savings("32145679", 1500, 470);
		accs[5] = new Cheque("41325678", -5310, -20000);
		accs[6] = new Cheque("34567876", 670, -41000);*/
		
		for(int i = 0; i < num; i++)
			System.out.printf("accs[%d] = %s\n", i, accs[i]);
		
		//Arrays.sort(accs, 0, 7);
		Account temp[] = Arrays.copyOf(accs, num);
		accs = temp;
		Arrays.sort(accs);
		
		System.out.println("After sorting");
		
		for(int i = 0; i < num; i++)
			System.out.printf("accs[%d] = %s\n", i, accs[i]);
		
		/*Account accS1 = new Savings("12345679",500,450);		
		System.out.println("accS1 = "+accS1);
		System.out.println("The interest for "+accS1.getAccNo()+" is: "+accS1.calculateInterest(10));
		try
		{
			Account accC1 = new Cheque("1234567",-500,-1000);
			System.out.println("accC1 = "+accC1);
			System.out.println("The interest for "+accC1.getAccNo()+" is: "+accC1.calculateInterest(10));
			int a = 0;
			int b = 5;
			int c = b/a;
		}
		catch(InvaidNumberException e)
		{
			System.out.println("There was an exception. Message = " + e);
		}
		catch(Exception e)
		{
			System.out.println("There is a MOERSE problem " + e);
		}*/
	}
}