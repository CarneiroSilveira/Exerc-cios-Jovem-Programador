
public class Fup8
{
	public static void Tabuada(int num)
	{
		Console.WriteLine("\nTabuada de Multiplicação");
		for (int i = 0; i <= 10; i += 1)
		{
			Console.WriteLine($"{num} x {i} = {num * i}");
		}

		Console.WriteLine("\nTabuada de Adição");
		for (int i = 0; i <= 10; i += 1)
		{
			Console.WriteLine($"{num} x {i} = {num + i}");
		}

		Console.WriteLine("\nTabuada de Subtração");
		for (int i = 0; i <= 10; i += 1)
		{
			Console.WriteLine($"{num} x {i} = {num - i}");
		}

		Console.WriteLine("\nTabuada de Divisão");
		for (int i = 1; i <= 10; i += 1)
		{
			Console.WriteLine($"{num} x {i} = {num / i}");
		}
	}
}