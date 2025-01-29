using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		float numero1 = float.Parse(Console.ReadLine());

		
		
		if (numero1 % 2 == 0)
		{
			Console.WriteLine("o numero é par");
		}
		else 
		{
			Console.WriteLine("o numero é impar");
		}
		
		
		
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
	}
	}
	
