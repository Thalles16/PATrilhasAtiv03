using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		float numero = float.Parse(Console.ReadLine());
 		
		
		if (numero != 0)
		{
		
			Console.WriteLine("o numero é diferente de zero");
			

		}
		else
		{
			Console.WriteLine("o numero é igual a zero");
		}
		
		
		
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
	}
	}
