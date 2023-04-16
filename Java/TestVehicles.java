public class TestVehicles
{
	public static void main(String[] args)
	{
		Registration r1 = new Registration("BND", "007", "GP");
		Vehicle v1 = new Vehicle("Ford", 4, 2.3, r1);
		System.out.println(v1);
		
		System.out.println("Assign new registration to vehicle:");
		Registration r2 = new Registration("XYZ", "123", "NW");
		v1.setRegistration(r2);
		System.out.println(v1);
		
		System.out.println("Terminate vehicle - registrations still exist!");
		v1 = null;
		System.out.println("r1 = " + r1);
		System.out.println("r2 = " + r2);
		System.out.println("But vehicle does not exist...:");
		System.out.println("v1 = " + v1);
	}		
}