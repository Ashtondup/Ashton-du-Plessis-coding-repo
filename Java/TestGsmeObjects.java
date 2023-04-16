public class TestGsmeObjects
{
	public static void main(String args[])
	{
		Spell f1 = new Fireball("Thunder", 25);
		Spell t1 = new Teleport("GETAWAY", 35);
		System.out.println(f1 + "Energy used = "+f1.calculateEnergyUsed());
		System.out.println(t1 + "Energy used = "+t1.calculateEnergyUsed());
	}
}