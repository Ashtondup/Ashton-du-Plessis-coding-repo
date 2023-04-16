public class Fireball extends Spell
{
    private int duration;
	
	public int calculateEnergyUsed()
	{
		return duration * 2;
	}
	
    public Fireball()
    {
        this("Magic",0);
    }

    public Fireball(String incantation,int duration)
    {
        super(incantation);
        setDuration(duration);
    }

    public void setDuration(int duration)
    {
        this.duration = duration;
    }

    public int getDuration()
    {
        return duration;
    }

    public String toString()
    {
        return "Fireball: Incantation: " +getIncantation() + " ,Duration " + getDuration() + " seconds";
    }

    public static void main(String args[])
    {
        Fireball fb1 = new Fireball("Blue thunder Fireball",25);
        System.out.println("fb1: "+fb1);
    }
}