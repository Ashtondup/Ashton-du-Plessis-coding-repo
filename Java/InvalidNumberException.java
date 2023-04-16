//Ashton du Plessis 34202676
public class InvalidNumberException extends RuntimeException
{
	public InvalidNumberException()
	{
		this("Invalid account number");
	}
	
	public InvalidNumberException(String message)
	{
		super(message);
	}
}