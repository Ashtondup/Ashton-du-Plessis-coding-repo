public class Employee
{
	private String id;
	private String name;
	private String email;
	private String office;
	
	public Employee()
	{
		this("00000000", "", "");
	}
	
	public Employee(String id, String name, String email)
	{
		setId(id);
		setName(name);
		setEmail(email);
	}
	
	public void setId(String id)
	{
		this.id = id;
	}
	
	public void setName(String name)
	{
		this.name = name;
	}
	
	public void setEmail(String email)
	{
		this.email = email;
	}
	
	public void setOffice(String office)
	{
		this.office = office;
	}
	
	public String getId()
	{
		return id;
	}
	
	public String getName()
	{
		return name;
	}
	
	public String getEmail()
	{
		return email;
	}
	
	public String getOffice()
	{
		return office;
	}
	
	public String toString()
	{
		return "Employee ID: " + getId() + ", Name: " + getName() + ", Email: " + getEmail() + ", Office: " + getOffice();
	}
	
	public static void main(String args[])
	{
		Employee e1 = new Employee();
		System.out.println("e1: " + e1);
		
		Employee e2 = new Employee("34202676", "Ashton du Plessis", "ashtondup@gmail.com");
		System.out.println("e2: " +e2);
		e2.setOffice("G3, G16");
		System.out.println("e2 after setting office: " + e2);
	}
}