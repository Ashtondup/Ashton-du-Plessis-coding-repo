public class Faculty extends Employee
{
	private String rank;
	
	public Faculty()
	{
		this("00000000", "", "", "");
	}
	
	public Faculty(String id, String name, String email, String rank)
	{
		super(id, name, email);
		setRank(rank);
	}
	
	public void setRank(String rank)
	{
		this.rank = rank;
	}
	
	public String getRank()
	{
		return rank;
	}
	
	public String toString()
	{
		return super.toString() + ", Rank: " + getRank();
	}
	
	public static void main(String args[])
	{
		Faculty f1 = new Faculty();
		System.out.println("f1: " + f1);
		
		Faculty f2 = new Faculty("34202676", "Ashton du Plessis", "ashtondup@gmail.com", "Student");
		System.out.println("f2: " +f2);
		f2.setOffice("G3, G16");
		System.out.println("f2 after setting office: " + f2);
	}
}