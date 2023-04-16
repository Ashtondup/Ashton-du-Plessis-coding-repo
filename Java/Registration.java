public class Registration
{
	private String alphaField;
	private String numericField;
	private String provinceField;
	
	public Registration()
	{
		this("","","");
	}
	
	public Registration(String alphaF , String numericF , String provinceF)
	{		
		setAlphaField(alphaF);
		setNumericField(numericF);
		setProvinceCode(provinceF);
	}
	
	public void setAlphaField(String aplhaf)
	{
		this.alphaField = aplhaf;
	}
	
	public void setNumericField(String numericf)
	{
		this.numericField = numericf;
	}
	
	public void setProvinceCode(String provincef)
	{
		this.provinceField = provincef;
	}
	
	public String getAplhaField()
	{
		return alphaField;
	}
	
	public String getNumericField()
	{
		return numericField;
	}
	
	public String getProvinceCode()
	{
		return provinceField;
	}
	
	public String getRegistration()
	{
		return getAplhaField() + "  " + getNumericField() + "  " + getProvinceCode();
	}
	
	public String toString()
	{
		return getRegistration();
	}
}