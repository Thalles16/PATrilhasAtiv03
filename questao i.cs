using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero1 = int.Parse(Console.ReadLine());

		Console.WriteLine("escolha um numero");
		int numero2 = int .Parse(Console.ReadLine());
		
		int diferenca = numero1 - numero2;
		

		
		if ( diferenca <= 10 && diferenca >0 )
		{
			Console.WriteLine("os numeros tem diferença menor ou igual a 10");
		}
		else 
		{
			Console.WriteLine("os numeros tem diferença maior ou igual a 10");
		}
		
		
		
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
	}
	}
	
