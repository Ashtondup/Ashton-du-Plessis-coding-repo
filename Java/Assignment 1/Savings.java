//Ashton du Plessis 34202676

public class Savings extends Account
{
	private int minBalance;
	
	public Savings()
	{
	}
	
	public Savings(String AccNo, int Balance, int minBalance)
	{
		super(AccNo, Balance);
		setminBalance(minBalance);
	}
	
	public void setminBalance(int minBalance)
	{
		this.minBalance = minBalance;
	}
	
	public int getminbalance()
	{
		return minBalance;
	}
	
	public int calculateInterest(int rate)
	{
		if(getBalance() < minBalance)
		{
			return getBalance() * 0;
		}
		else
		{
			return getBalance() * rate / 100;
		}
	}
	
	public String toString()
	{
		return "AccNo: " + getAccNo() + " Balance: " + getBalance() + " minBalance: " + getminbalance();
	}
	
	/*public static void main(String args[])
	{
		Savings s1 = new Savings("12345678", 123, 124);
		System.out.println("s1: " + s1);
	}*/
}