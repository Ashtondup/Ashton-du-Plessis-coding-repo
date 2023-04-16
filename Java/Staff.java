public class Staff extends Employee
{
	private String title;
	
	public Staff()
	{
		this("00000000", "", "", "");
	}
	
	public Staff(String id, String name, String email, String title)
	{
		super(id, name, email);
		setTitle(title);
	}
	
	public void setTitle(String title)
	{
		this.title = title;
	}
	
	public String getTitle()
	{
		return title;
	}
	
	public String toString()
	{
		return super.toString() + ", Title: " + getTitle();
	}
	
	public static void main(String args[])
	{
		Staff s1 = new Staff();
		System.out.println("s1: " + s1);
		
		Staff s2 = new Staff("34202676", "Ashton du Plessis", "ashtondup@gmail.com", "Mr");
		System.out.println("s2: " +s2);
		s2.setOffice("G3, G16");
		System.out.println("s2 after setting office: " + s2);
	}
}