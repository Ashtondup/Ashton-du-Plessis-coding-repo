//Ashton du Plessis 34202676
public class TestExceptions
{
	public static void main(String args[])
	{
		try
		{
			Account a1 = new Savings("059600928","",0,0);
		}
		catch(InvalidNumberException e)
		{
			System.out.println(e);
		}
		
		try
		{
			Account a2 = new Cheque("1234030645","",0,0);
		}
		catch(InvalidNumberException e)
		{
			System.out.println(e);
		}
		
		try
		{
			Account a3 = new Savings("1234a3X645","",0,0);
		}
		catch(InvalidNumberException e)
		{
			System.out.println(e);
		}
	}
}
