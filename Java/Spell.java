public abstract class Spell
{
    private String incantation;
	
	public abstract int calculateEnergyUsed(); // n metode wat wil implementeer, maar wil nie implementeer nie.

    public Spell()
    {
        this("Magic");
    }

    public Spell(String incantation)
    {
        setIncantation(incantation);
    }

    public void setIncantation(String incantation)
    {
        this.incantation = incantation;
    }

    public String getIncantation()
    {
        return incantation;
    }

    public String toString()
    {
        return "Spell Incantation: " + getIncantation();
    }

    public static void main(String[] args)
    {
        //Spell s1 = new Spell("Blue thunder Fireball");
        //System.out.println("S1: "+s1);
    }
}
