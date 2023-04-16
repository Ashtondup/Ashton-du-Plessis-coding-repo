//Ashton du Plessis 34202676
public class TestLinkedList
{
    public static void main(String[] args) 
    {
        MyLinkedList<Integer> list = new MyLinkedList<Integer>();
        MyLinkedList<Integer> parameterList = new MyLinkedList<Integer>();

        list.append(new Integer(1));
        list.append(new Integer(4));
        list.append(new Integer(2));

        parameterList.append(new Integer(3));
        parameterList.append(new Integer(2));
        parameterList.append(new Integer(7));
        parameterList.append(new Integer(1));

        System.out.println("Calling list: " + list.toString());
        System.out.println("Parameter list: " + parameterList.toString());
        System.out.println("Returning list: " + list.getUnique(parameterList));
    }
}