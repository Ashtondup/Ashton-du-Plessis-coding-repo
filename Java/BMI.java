import java.awt.GridLayout;
import java.awt.event.*;
import javax.swing.*;

public class BMI extends JFrame
{
	private JLabel weightL;
	private JTextField weightTF;
	private JLabel heightL;
	private JTextField heightTF;
	private JRadioButton maleSelect;
	private JRadioButton femaleSelect;
	private ButtonGroup genderSelect;
	private int genderValue;//0-male, 1-female
	private JButton calculate;
	private JLabel bmiL;
	private JLabel displayL;
	private GridLayout layout;
	
	public BMI()
	{
		super("BMI Calculayer");
		layout = new GridLayout(5,2);
		setLayout(layout);
		weightL = new JLabel("Enter weight (in kg):");
		weightTF = new JTextField("");
		heightL = new JLabel("Enter height (in meters):");
		heightTF = new JTextField("");
		maleSelect = new JRadioButton("Male");
		femaleSelect = new JRadioButton("Female");
		genderSelect = new ButtonGroup();
		genderSelect.add(maleSelect);
		genderSelect.add(femaleSelect);
		calculate = new JButton("Calculate BMI");
		bmiL = new JLabel("");
		displayL = new JLabel("");
		
		add(weightL);
		add(weightTF);
		add(heightL);
		add(heightTF);
		add(maleSelect);
		add(femaleSelect);
		add(calculate);
		add(bmiL);
		add(displayL);
		
		maleSelect.addItemListener(new RadioButtonHandler(0));
		femaleSelect.addItemListener(new RadioButtonHandler(1));
		
		CalculateHandeler handeler = new CalculateHandeler();
		calculate.addActionListener(handeler);
	}
	
	private class RadioButtonHandler implements ItemListener
	{
		private int gender;
		
		public RadioButtonHandler(int sel)
		{
			gender = sel;
		}
		
		public void itemStateChanged(ItemEvent e)
		{
			genderValue = gender;
			System.out.println(genderValue);
		}
	}
	
	private class CalculateHandeler implements ActionListener
	{
		
		public void actionPerformed(ActionEvent e)
		{
			double weight = Double.parseDouble(weightTF.getText());
			double height = Double.parseDouble(heightTF.getText());
			double bmi = weight / (height * height);
			bmiL.setText(String.format("Your BMI is: %4.1f", bmi));
			
			if(genderValue == 0)
			{
				if(bmi < 22.5)
				{
					displayL.setText("M You are underweight");
				}
				else if(bmi < 29.5)
				{
					displayL.setText("M You are at an ideal weight");
				}
				else
				{
					displayL.setText("M You are overweight");
				}
			}
			else
			{
				if(bmi < 18.5)
				{
					displayL.setText("F You are underweight");
				}
				else if(bmi < 24.5)
				{
					displayL.setText("F You are at an ideal weight");
				}
				else
				{
					displayL.setText("F You are overweight");
				}
			}
		}
	}
	
	public static void main(String args[])
	{
		BMI bmi = new BMI();
		bmi.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		bmi.setSize(500,250);
		bmi.setVisible(true);
	}
}