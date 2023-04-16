//Ashton du Plessis 34202676
import java.util.*;
public class Test
{
  

  public static void main(String arg[])
  {
    MyArrayList<Character> list = new MyArrayList<>();
    
    String s1 = "admin";
    String s2 = "atlas";

    list = list.checkChar(s1, s2);
    System.out.println(list);
    System.out.println(list.checkWin());
  }
}