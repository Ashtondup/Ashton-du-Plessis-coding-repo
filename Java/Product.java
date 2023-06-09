import java.io.*;

public abstract class Product implements Taxable, Serializable, Comparable<Product>
{
	private String barcodeNumber;
	private String name;
	private int unitPrice;
	
	public Product(String no, String nm, int up)
	{
		setBarcodeNumber(no);
		setName(nm);
		setUnitPrice(up);
	}
	
	public abstract String getRecord();
	
	public abstract int calculateTotalCost(int tax);
	
	public int calculateTax(int price, int tax)
	{
		return (int)(price*tax/100.0);
	}
	
	public void setBarcodeNumber(String no)
	{
		barcodeNumber = no;
	}
	
	public void setName(String nm)
	{
		name = nm;
	}
	
	public void setUnitPrice(int up)
	{
		unitPrice = up;
	}
	
	public String getBarcodeNumber()
	{
		return barcodeNumber;
	}
	
	public String getName()
	{
		return name;
	}
	
	public int getUnitPrice()
	{
		return unitPrice;
	}
}