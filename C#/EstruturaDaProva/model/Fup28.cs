namespace exercicios
{
    public class Fup28
    {
        public static void IsNegative()
        {
            int negativos = 0;
            Console.WriteLine("Digite a lista de 10 numeros a ser verificada. Siga esté padrão: -1 -2 -3 -4 -5 1 2 3 4 5");
            float[] nums = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            for (int i = 0; i < 10; i++)
            {
                if (nums[i] >= 0)
                {
                    Console.WriteLine($"O numero {i} é positivo!");
                }
                else
                {
                    Console.WriteLine($"O numero {i} é negativo");
                    negativos += 1;
                }
            }
            Console.WriteLine($"Da lista recebida {negativos} são negativos!");
        }
    }
}