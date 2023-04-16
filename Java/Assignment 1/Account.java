//Ashton du Plessis 34202676

public abstract class Account implements Comparable <Account>
{
	private String AccNo;
	private int Balance;
	
	public abstract int calculateInterest(int rate);
	
	public Account()
	{
	}
	
	public Account(String AccNo, int Balance)
	{
		setAccNo(AccNo);
		setBalance(Balance);
	}
	
	@Override public int compareTo(Account g) 
	{
		Account c = (Account)g;   
		if (this.getBalance() == c.getBalance())
			return 0;
		else if (this.getBalance() < c.getBalance())
			return -1;
		else
			return 1;
	}
	
	public void setAccNo(String AccNo)
	{
		this.AccNo = AccNo;
	}
	
	public void setBalance(int Balance)
	{
		this.Balance = Balance;
	}
	
	public String getAccNo()
	{
		return AccNo;
	}
	
	public int getBalance()
	{
		return Balance;
	}
	
	public String toString()
	{
		return "Account number: " + getAccNo() + "Balance of: R" + getBalance();
	}
}