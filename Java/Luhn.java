import java.util.Scanner;

public class Luhn
{
	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);
		String num;
		int sum, mod;
		//while(input.hasNext())
		{
			System.out.print("Plesase give student number: ");
			num = input.nextLine();
			sum = 0;
			for(int i = 0; i < 8; i++)
			{
				sum += (num.charAt(i) - '0') * (8-i);				
			}
			mod = sum % 11;
			if(mod == 0)
				System.out.println("Number is correct");
			else
				System.out.println("Number is invalid");
		}
	}
}