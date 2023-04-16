public class Engine
{
	private int numCylinders;
	private double displacement;
	
	public Engine()
	{
		this(0 , 0.0);
	}
	
	public Engine(int noCylinders , double displacementval )
	{
		setDisplacement(displacementval);
		setNumCylinders(noCylinders);
	}
	
	public void setNumCylinders(int noCylinders)
	{
		this.numCylinders = noCylinders;
	}
	
	public void setDisplacement(double displacementval)
	{
		this.displacement = displacementval;
	}
	
	public int getNumCylinders()
	{
		return numCylinders;
	}
	
	public double getDisplacement()
	{
		return displacement;
	}
	
	public String toString()
	{
		return getNumCylinders() + "  " + getDisplacement();
	}
}