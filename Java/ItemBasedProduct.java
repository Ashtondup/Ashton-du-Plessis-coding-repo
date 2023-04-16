public class ItemBasedProduct extends Product
{
	private String manufacturer;
	
	public ItemBasedProduct(String no, String nm, int up, String man)
	{
		super(no, nm, up);
		setManufacturer(man);
	}
	
	public int compareTo(Product other)
	{
		String thisField = getBarcodeNumber().charAt(0) + getName();
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
	
	public int calculateTotalCost(int tax)
	{
		return getUnitPrice() + calculateTax(getUnitPrice(), tax);
	}
	
	public String getRecord()
	{
		return "Barcode " + getBarcodeNumber() + " is " + getName() + " from " + getManufacturer() + ", unit price " + getUnitPrice() + "c";
	}
	
	public void setManufacturer(String man)
	{
		manufacturer = man;
	}
	
	public String getManufacturer()
	{
		return manufacturer;
	}
		
	public static void main(String args[])
	{
		ItemBasedProduct i1 = new ItemBasedProduct("167832345047","Tuna",1500,"I&J");
		System.out.println(i1.getRecord());
	}
}