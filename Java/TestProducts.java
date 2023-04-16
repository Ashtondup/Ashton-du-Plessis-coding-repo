import java.util.*;

public class TestProducts
{
   public static final int MAX_PRODUCTS = 25;  
   
   public static void main(String args[])
   {

      Product aList[] =new Product[MAX_PRODUCTS];
      int count = 0;
      
      aList[count++] = new WeightBasedProduct("267897542561","Rump steak",12500,250);
      aList[count++] = new WeightBasedProduct("245134342474","Bananas",4300,450);
      aList[count++] = new ItemBasedProduct("178030640224","Milk 1L",1550,"Clover");
      aList[count++] = new ItemBasedProduct("167832345047","Tuna",1500,"I&J");
      aList[count++] = new WeightBasedProduct("251336424031","Apples",3350,135);
      aList[count++] = new ItemBasedProduct("145672345754","Oros Orange Squash",3400,"Brookes");
      aList[count++] = new WeightBasedProduct("245134867531","Bananas",4300,540);
   
      System.out.println("List of products");
      for (int i=0;i<count;i++)
         System.out.println(aList[i].getRecord());
         
         
      System.out.println("\nTotal cost of each item");
      for (int i=0;i<count;i++)
         System.out.printf("Barcode: %s: %s: R%1.2f \n",aList[i].getBarcodeNumber(), aList[i].getName(), aList[i].calculateTotalCost(15)/100.0);
         
      Product[] tempPList = Arrays.copyOf(aList,count);
      Arrays.sort(tempPList);
      
	  System.out.println("\nList of products after sort");
      for (int i=0;i<count;i++)
         System.out.println(tempPList[i].getRecord());
   }
}
   