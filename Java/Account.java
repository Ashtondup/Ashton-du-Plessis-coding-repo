//Ashton du Plessis 34202676
import java.io.*;
import java.util.*;
/** This is a class to represent bank accounts. 
@author Ashton du Plessis
@version 2.2
*/
public abstract class Account implements Serializable, Comparable<Account>
{
	
	private String accNo;
	private String name;
	private int balance;
	
	public abstract String statement();
	
	/** Creats a defailt of Account object. */
	public Account()
	{		
	}
	
	/** Creats an Account object
	@param no Number of the account Checkin in doen as follows...
	@param nm Name of account holder
	@param bal Opening balance of account when account is created...
	*/
	public Account(String no, String nm, int bal)
	{
		setAccNo(no);
		setName(nm);
		setBalance(bal);
	}
	
	public abstract int calculateInterest(int rate);
	
	/** Method to set account number. Validation is doen as follows...
	@param no Value assigned to accNo.
	@exception InvalidNumberException is thrown for account number that is invalid.
	*/
	public void setAccNo(String no)
	{
		if (no.length() != 10)
			throw new InvalidNumberException("Account number " + no + " is invalid: Must be 10 digits in length!");
		int sum = 0;
		for (int i = 0; i < 10; i = i+2)
			if ((no.charAt(i) < '0')||(no.charAt(i)> '9'))
				throw new InvalidNumberException("Account number "+ no + " is invalid: Must contain only digits!");
			else
				sum += (no.charAt(i)-'0')*2;
		for (int i =1; i < 10; i = i+2)
			if ((no.charAt(i)<'0')||(no.charAt(i)>'9'))
				throw new InvalidNumberException("Account number " + no + " is invalid: Must contain only digits!");
			else
				sum += (no.charAt(i)-'0');
		if (sum%10>0)
		{
			throw new InvalidNumberException("Account number " + no + " is invalid: Check sum is invalid!");
		}	
		accNo = no;
		
		/*
		int s = 0;
		if(no.length()==10)
			accNo = no;
		else
			throw new InvalidNumberException("Must be 10 digits in length!");
		
		for (int i = 0; i < 10; i++)
		{
			if (i%2 == 0)
			{
				s = s + ((no.charAt(i)-'0')*2);
			}
			else
			{
				s = s + ((no.charAt(i)- '0')*1);
			}
		}
		if (s%10 != 0)
		{
			throw new InvalidNumberException("Check sum is invalid!");
		}
		else
		{
			accNo = no;
		}*/
		
		
	}
	
	public void setBalance(int bal)
	{
		this.balance = bal;
	}
	
	public void setName(String nm)
	{
		this.name = nm;
	}
	
	/** Method return the value of account number
	@return Returns number as a String
	*/
	public String getAccNo()
	{
		return accNo;
	}
	
		public String getName()
	{
		return name;
	}
	
	public int getBalance()
	{
		return balance;
	}
	
	public int compareTo(Account other)
	{
		String thisField = getAccNo().charAt(0)+getName();
		String otherField = other.getAccNo().charAt(0)+other.getName();
		return thisField.compareTo(otherField);
	}
}