namespace Fup36
{
    public class Operaçoes
    {

        public static void Somar(float[] nums)
        {
            float result = 0;
            foreach (var item in nums)
            {
                result += item;
            }
            Console.WriteLine($"O Resultado do calculo é: {result}");
        }
        public static void Subtrair(float[] nums)
        {
            float result = 0;
            foreach (var item in nums)
            {
                result -= item;
            }
            Console.WriteLine($"O Resultado do calculo é: {result}");

        }
        public static void Multiplicar(float[] nums)
        {
            float result = 0;
            foreach (var item in nums)
            {
                result *= item;
            }
            Console.WriteLine($"O Resultado do calculo é: {result}");

        }
        public static void Dividir(float[] nums)
        {
            float result = 0;
            foreach (var item in nums)
            {
                result /= item;
            }
            Console.WriteLine($"O Resultado do calculo é: {result}");
        }
    }
}
