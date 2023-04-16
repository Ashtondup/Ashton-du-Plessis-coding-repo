import java.util.List;

//Ashton du Plessis 34202676

public class TestAccounts
{
	public static void main(String[] args) 
	{
		MyArrayList<Account> list = new MyArrayList<>();
		Account accS1 = new Savings("12345678",500,450);
		Account accS2 = new Savings("39909476", 1000, 984);
		Account accS3 = new Savings("34202676", 654, 50);
		Account accS4 = new Savings("98462186", 350,600);

		Account accC1 = new Cheque("12345679",-500,-10000);
		Account accC2 = new Cheque("35560517", 336, -100);
		Account accC3 = new Cheque("65126753", 10, 50);
		Account accC4 = new Cheque("95134862", -400,-10);

		list.add(0, accS1);
		list.add(1, accC1);
		list.add(2, accS2);
		list.add(3, accS3);
		list.add(4, accC2);
		list.add(5, accC3);
		list.add(6,accS4);
		list.add(7,accC4);

		System.out.print("The list before sorting: \n");
		System.out.println(list.toString());

		System.out.print("The list after sorting: \n");
		if(list.sortList())
		{
			System.out.println(list.toString());
		}
		//System.out.println("accS1 = " + accS1);
		//System.out.println("The interest for " + accS1.getAccNo() + " is: " + accS1.calculateInterest(10));
		//System.out.println("accC1 = " + accC1);
		//System.out.println("The interest for " + accC1.getAccNo() + " is: " + accC1.calculateInterest(10));
	}
}