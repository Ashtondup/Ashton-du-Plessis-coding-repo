public class WeightBasedProduct extends Product
{
	private int weight;
	
	public WeightBasedProduct(String no, String nm, int up, int wt)
	{
		super(no,nm,up);
		setWeight(wt);
	}
	
	public int compareTo(Product other)
	{
		String thisField = getBarcodeNumber().charAt(0) + getName() + getWeight();
		String otherField;
		if(other instanceof ItemBasedProduct)
		{
			otherField = other.getBarcodeNumber().charAt(0) + other.getName();
		}
		else
		{
			otherField = other.getBarcodeNumber().charAt(0) + other.getName() + ((WeightBasedProduct)other).getWeight();
		}
		return  thisField.compareTo(otherField);
	}
	
	public void setWeight(int wt)
	{
		weight = wt;
	}
	
	public int getWeight()
	{
		return weight;
	}
	
	public int calculateTotalCost(int tax)
	{
		int totalPrice = getUnitPrice() * getWeight()/1000;
		return totalPrice + calculateTax(totalPrice, tax);
	}
	
	public String getRecord()
	{
		return "Barcode " + getBarcodeNumber() + " is " + getName() + ", unit price " + getUnitPrice() + "c/Kg, weight " + getWeight() + " grams";
	}
	
	public static void main(String[] args)
	{
		WeightBasedProduct w1 = new WeightBasedProduct("245134342474","Bananas", 4300,450);
		System.out.println(w1.getRecord());
	}
}