import javax.swing.JOptionPane;

public class Addition
{
	public static void main(String[] args)
	{
		String num1 = JOptionPane.showInputDialog("Enter an integer:");
		String num2 = JOptionPane.showInputDialog("Enter anotjer integer:");
		
		int n1 = Integer.parseInt(num1);
		int n2 = Integer.parseInt(num2);
		int sum = n1 + n2;
		JOptionPane.showMessageDialog(null, "The sum = " + sum, "The sum of 2 integers", JOptionPane.PLAIN_MESSAGE);
	}
}