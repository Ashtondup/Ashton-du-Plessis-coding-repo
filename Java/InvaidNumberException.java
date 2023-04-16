public class InvaidNumberException extends RuntimeException
{
	public InvaidNumberException()
	{
		this("The number is invalid");
	}
	
	public InvaidNumberException(String message)
	{
		super(message);
	}
}