public class Vehicle
{
	private String manufacturer;
	private Engine engine;
	private Registration registration;
	
	public Vehicle()
	{
		this( "" , 0 , 0.0 , new Registration());
	}
	
	public Vehicle(String manufacturer , int numCylinders , double displacement , Registration registration )
	{
		setManufacturer(manufacturer);
		setEngine(numCylinders , displacement); 
		setRegistration(registration);
	}
	
	public void setManufacturer(String manufact)
	{
		manufacturer = manufact;
	}
	
	public void setEngine(int noCylinders , double displacem)
	{
		engine = new Engine(noCylinders , displacem);
	}
	
	public void setRegistration(Registration registr)
	{
		registration = registr;
	}
	
	public String getManufacturer()
	{
		return manufacturer;
	}
	
	public Engine getEngine()
	{
		return engine;
	}
	
	public Registration getRegistration()
	{
		return registration;
	}
	
	public String toString()
	{
		return getManufacturer() + "  " + getEngine() + "  " + getRegistration();
	}
}