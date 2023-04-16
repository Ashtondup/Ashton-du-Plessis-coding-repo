public class Teleport extends Spell
{
    private int distance;
	
	public int calculateEnergyUsed()
	{
		return distance * 3;
	}
	
    public Teleport()
    {
        this("Magic",0);
    }

    public Teleport(String incantation,int distance)
    {
        super(incantation);
        setDistance(distance);
    }

    public void setDistance(int distance)
    {
        this.distance = distance;
    }

    public int getDistance()
    {
        return distance;
    }

    public String toString()
    {
        return "Teleport: Incantation:" + getIncantation() + ", Distance  " + getDistance() + " meters";
    }

    public static void main(String args[])
    {
        Teleport t1 = new Teleport("Teleport",20);
        System.out.println(t1);
    }
}