using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero1 = int.Parse(Console.ReadLine());

		Console.WriteLine("escolha um numero");
		int numero2 = int.Parse(Console.ReadLine());
		
		if (numero1 == numero2)
		{
			Console.WriteLine("o primeiro numero é igual ao segundo");
		}
		else 
		{
			Console.WriteLine("o primeiro numero não é igual ao segundo");
		}
		
		
		
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
		
	}
}
