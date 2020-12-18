using System;
					
public class Program
{
	public static void Main()
	{
		int n, i, j, maximum, minimum;
		
		Console.WriteLine("Entrer un nombre supérieur à 0: ");
		n = Int32.Parse(Console.ReadLine());
		maximum = n;
		minimum = n;
		
		while(n<=0){
			Console.WriteLine("Entrer un nombre supérieur à 0: ");
			n = Int32.Parse(Console.ReadLine());
		}
		
		for(i=0; i<n; i++) {
			if(i > maximum) {
				maximum = i+1;
			}
			if(i < minimum) {
				minimum = i+1;
			}
		}
		Console.Write("Maximum  = {0}\n", maximum);
		Console.Write("Minimum  = {0}\n\n", minimum);

	}
}
