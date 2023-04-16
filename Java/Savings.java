//Ashton du Plessis 34202676

/** This is a class to represent savings accounts.
These accounts have an minimum balance for intrest to be paid 
@author Ashton du Plessis
@version 2.2
*/
public class Savings extends Account
{
	private int minBalance;
	
	public Savings()
	{
		this("0000000000","",0,0);
	}
	
	public Savings(String no, String nm, int bal, int minBal)
	{
		super(no, nm, bal);
		setMinBalance(minBal);		
	}
	
	public void setMinBalance(int minBal)
	{
		this.minBalance = minBal;
	}
	
	public int getMinBalance()
	{
		return minBalance;
	}
	public int calculateInterest(int rate)
	{
		if (getBalance()<getMinBalance())
			return 0;
		return getBalance()*rate/100;
	}
	
	public String statement()
	{
		return "Account no: "+getAccNo()+ " of client " + getName() + " has balance of R"+getBalance() + " and minimum balance R"+getMinBalance();
	}
	
}	