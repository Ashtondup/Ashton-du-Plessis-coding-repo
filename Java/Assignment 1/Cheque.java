//Ashton du Plessis 34202676

public class Cheque extends Account
{
	private int overdraftLimit;
	
	public Cheque()
	{
	}
	
	public Cheque(String AccNo, int Balance, int overdraftLimit)
	{
		super(AccNo, Balance);
		setoverdraftLimit(overdraftLimit);
	}
	
	public void setoverdraftLimit(int overdraftLimit)
	{
		this.overdraftLimit = overdraftLimit;
	}
	
	public int getoverdraftLimit()
	{
		return overdraftLimit;
	}
	
	public int calculateInterest(int rate)
	{
		if(getBalance() < overdraftLimit)
		{
			return getBalance() * 4 * rate / 100;
		}
		else if(getBalance() < 0 && getBalance() >= overdraftLimit)
		{
			return getBalance() * 2 * rate / 100;
		}
		else
		{
			return getBalance();
		}
	}
	
	public String toString()
	{
		return "AccNo: " + getAccNo() + " Balance: " + getBalance() + " OverdraftLimit: " + getoverdraftLimit();
	}
	
	/*public static void main(String args[])
	{
		Cheque c1 = new Cheque("123456789",123, 125);
		System.out.println("c1: " + c1);
	}*/
}