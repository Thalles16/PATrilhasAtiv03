using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		float numero1 = float.Parse(Console.ReadLine());

		Console.WriteLine("escolha um numero");
		float numero2 = float.Parse(Console.ReadLine());
		
		if (numero1 >= numero2)
		{
			Console.WriteLine("o primeiro numero é maior ou igual ao segundo");
		}
		else 
		{
			Console.WriteLine("o primeiro numero não é maior ou igual ao segundo");
		}
		
		
		
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
	}
	}
