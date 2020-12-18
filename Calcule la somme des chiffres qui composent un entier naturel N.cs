using System;
					
public class Program
{
	public static void Main()
	{
		int n, s, r;
		Console.WriteLine("Ecrire un entier naturel N: ");
		n = Int32.Parse(Console.ReadLine());
		while(n<=0){
			Console.WriteLine("Ecrire un entier naturel N: ");
			n = Int32.Parse(Console.ReadLine());
		}
		
		s=0;
		r=0;
		
		while(r>0){
			s = (s+r) % 10;
			r = r / 10 ;
		}
		
		Console.WriteLine("La somme des chiffres qui compose {0} est {1}", n, s);
	}

	
}
