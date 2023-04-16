public class Test 
{
    public static void main (String args[])
    {
        StackAsMyArrayList<Character> List2 = new StackAsMyArrayList<Character>();
        
        System.out.println("The tower " + List2.toString());
        System.out.println("The size: " + List2.getStackSize());
        if((List2.checkStackUniform() == false) || (List2.getStackSize() < 5))
        {
            System.out.println("The tower is not full");
        }
        else
        {
            System.out.println("Corect? " + List2.checkStackUniform());
        }

        List2.push('r');
        List2.push('r');
        List2.push('r');
        List2.push('b');
        List2.push('b');

        System.out.println("\nThe tower " + List2.toString());
        System.out.println("The size: " + List2.getStackSize());
        if(List2.getStackSize() < 5)
        {
            System.out.println("The tower is not full");
        }
        else
        {
            System.out.println("Corect? " + List2.checkStackUniform());
        }

        List2.pop();
        List2.pop();

        System.out.println("\nThe tower " + List2.toString());
        System.out.println("The size: " + List2.getStackSize());
        if(List2.getStackSize() < 5)
        {
            System.out.println("The tower is not full");
        }
        else
        {
            System.out.println("Corect? " + List2.checkStackUniform());
        }

        List2.push('r');
        List2.push('r');

        System.out.println("\nThe tower " + List2.toString());
        System.out.println("The size: " + List2.getStackSize());
        if(List2.getStackSize() < 5)
        {
            System.out.println("The tower is not full");
        }
        else
        {
            System.out.println("Corect? " + List2.checkStackUniform());
        }
    }
}
