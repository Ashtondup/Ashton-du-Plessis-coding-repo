import java.util.Scanner;

public class Prog20220223A
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);
		System.out.print("Please enter your name: ");
		String name = input.nextLine();
		System.out.println("Goodday " + name);
		System.out.printf("I hope you enjoy your day, %s\n", name);
	}
}