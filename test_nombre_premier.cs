using System;
					
public class Program
{
	public static void Main()
	{
		  int reste, x, i;
		  bool flag = true;
		
			Console.WriteLine("Donner un entier X: ");
			x = Int32.Parse(Console.ReadLine());

		  for (i=2; i <= x/2; i++)
		  {
			 reste = x%i;
			  
			 if(reste == 0)
			 {
				flag = false;
				break;
			 }
		  }
			  if(flag)
				 Console.WriteLine(x + " est un nombre premier");
			  else
				 Console.WriteLine(x + " n'est pas un nombre premier");
		  }

	
}
