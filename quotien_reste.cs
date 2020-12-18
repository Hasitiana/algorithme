using System;
					
public class Program
{
	public static void Main()
	{
		int a, b, q, r ;
		Console.WriteLine("Ecrire deux entiers A et B");
		a = Int32.Parse(Console.ReadLine());
		b = Int32.Parse(Console.ReadLine());
		
		q = 0;
		r = a;
		
		while(r>b){
			q = q + 1;
			r = r - b;
		}
		
		Console.WriteLine("Le Quotient de A/B est : {0} Le reste de A/Best : {1}", q, r);

	}
}
