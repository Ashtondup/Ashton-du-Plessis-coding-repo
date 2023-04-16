import java.util.Scanner;

public class Prog20220223D
{
	public static void main(String args[])
	{
		Scanner input = new Scanner(System.in);
		System.out.print("Please enter a name: ");
		String name1 = input.nextLine();
		System.out.print("Please enter second name: ");
		String name2 = input.nextLine();
		if(name1.compareTo(name2)<0)
			System.out.println(name1 + " is smaller than " + name2);
		else if(name1.compareTo(name2)>0)
			System.out.println(name1 + " is larger than " + name2);
	}
}