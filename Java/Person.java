public class Person
{

   private String id;
   private Name name;
   private String email;
   private Address address;

   public Person()
   {
      this("00000000","","",new Address());
   }

   public Person(String id, String name, String email, Address address)
   {
      setId(id);
      setName(name);
      setEmail(email);
      setAddress(address);
   }

   public void setName(String newName)
   {
      name = new Name(newName);
   }

   public void setAddress(Address newAddress)
   {
      address = newAddress;
   }

   public Name getName()
   {
      return name;
   }

   public Address getAddress()
   {
      return address;
   }

   public static void main(String[] args)
   {
      Address a1 = new Address("CS Dept,University Place");
      Person s1 = new Person("53456785","Clever,C,Clive","clever.clive@gmail.com",a1);
      System.out.println("s1: "+s1);
      System.out.println("Name of s1 = "+s1.getName());
      System.out.println("and address\n"+s1.getAddress().getAddress());

      System.out.println("After deleting s1:");
      s1 = null;
      System.out.println("Address a1:\n"+a1.getAddress());
      System.out.println("Name of s1 = "+s1);

   }
}