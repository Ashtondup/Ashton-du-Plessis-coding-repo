public class DoSomething
{
	public static void main(String[] args)
	{
		int i1, i2, i3;
		int error = 0;
		int count = 0;
		double fp1, fp2, fp3, sum;
		
		for(i1 = 1; i1 <= 50; i1++)
			for(i2 = 1;(i1 + i2) <= 50; i2++)
			{
				count++;
				i3 = 50 - (i1 + i2);
				fp1 = i1 / 10.0;
				fp2 = i2 / 10.0;
				fp3 = i3 / 10.0;
				sum = fp1 + fp2 + fp3;
				if((5 - sum) != 0.0)
					error++;
			}
		if(error == 0)
			System.out.println("There were no errors");
		else
			System.out.println("There were " + error + " errors in " + count + " calculations!");
	}
}