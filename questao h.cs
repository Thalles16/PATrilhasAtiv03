using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero1 = int.Parse(Console.ReadLine());
		
		if (numero1 <= 0)
		{
			Console.WriteLine("o numero é negativo");
		}
		else 
		{
			Console.WriteLine("o numero é positivo");
		}
		
		
		
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
	}
	}
	
