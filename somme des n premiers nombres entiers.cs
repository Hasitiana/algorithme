using System;
					
public class Program
{
	public static void Main()
	{
		int n, somme;
		
		Console.WriteLine("Entrer un nombre: ");
		n = Int32.Parse(Console.ReadLine());
		somme = 0;
		
		for(int i=0; i<n; i++)
		{
			somme += (i+1);
		}
		Console.WriteLine("La somme de {0} premiers nombres est: {1}", n, somme );
	}
}
