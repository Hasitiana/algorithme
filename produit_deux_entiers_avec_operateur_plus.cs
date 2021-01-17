using System;
					
public class Program
{
	public static void Main()
	{
		int a, b, p, i;
		Console.WriteLine("Ecrire deux entiers A et B: ");
		Console.WriteLine("A: ");
		a = Int32.Parse(Console.ReadLine());
		Console.WriteLine("B: ");
		b = Int32.Parse(Console.ReadLine());
		
		if(a==0 || b==0)
			p=0;
		else{
			p=0;
			for(i=1; i<=b; i++){
				p = p + a;
			}
		}
		Console.WriteLine("Le produit A*B est: {0}", p);
		
		
	}

	
}
