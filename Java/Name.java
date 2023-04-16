public class Name
{
   private String firstName;
   private String initials;
   private String surname;

   public Name()
   {
      this("");
   }

   public Name(String newName)
   {
      String[] nameParts = newName.split(",");
      if (nameParts.length==3)
      {
         setFirstName(nameParts[0]);
         setInitials(nameParts[1]);
         setSurname(nameParts[2]);
      }
      else
      {
         setFirstName("");
         setInitials("");
         setSurname("");
      }

   }
   public void setFirstName(String firstName)
   {
      this.firstName = firstName;
   }

   public void setInitials(String initials)
   {
      this.initials = initials;
   }

   public void setSurname(String surname)
   {
      this.surname = surname;
   }

   public String getFirstName()
   {
      return firstName;
   }

   public String getInitials()
   {
      return initials;
   }

   public String getSurname()
   {
      return surname;
   }

   public String getFullName()
   {
      return getFirstName() + " " + getInitials() + " " + getSurname();
   }

   public String toString()
   {
      return getFullName();
   }


   public static void main(String[] args)
   {
      Name billy = new Name("William,WH,Bonney");
      System.out.println("billy = " + billy.getFullName());

      Name none = new Name();
      System.out.println("none = " + none.getFullName());
   }
}
