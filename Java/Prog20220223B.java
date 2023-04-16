import java.util.Scanner;

public class Prog20220223B
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);
		System.out.print("Please give an int value: ");
		int val = input.nextInt();
		System.out.println("The value is: " + val);
		System.out.println("The square of the value is: " + Math.pow(val,2));
		System.out.println("The square root of the value is: " + Math.sqrt(val));
	}
}