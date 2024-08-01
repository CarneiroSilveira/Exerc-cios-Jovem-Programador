namespace Fup36
{
    public class Calculadora
    {

        static void Main()
        {
            Console.Write("Carregando ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("*");
                Thread.Sleep(500);
            }
            Console.WriteLine("\nDigite a operação a ser realizada (1 = Adição, 2 = Subitração, 3 = Multiplicação, 4 = Divisão, 5 = Finalizar Calculadora)");
            int op = 0;
            do
            {
                Console.WriteLine("\nDigite a operação a ser realizada (1 = Adição, 2 = Subitração, 3 = Multiplicação, 4 = Divisão, 5 = Finalizar Calculadora)");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite os numeros usados na operação! seperados por espeço Ex: (1 2 3 4 5)");
                float[] nums = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();

                switch (op)
                {
                    case 1:
                        Operaçoes.Somar(nums);
                        break;
                    case 2:
                        Operaçoes.Subtrair(nums);
                        break;
                    case 3:
                        Operaçoes.Multiplicar(nums);
                        break;
                    case 4:
                        Operaçoes.Dividir(nums);
                        break;
                    case 5:
                        Console.WriteLine("\n------------Finalizando------------\n");
                        break;
                    default:
                        Console.WriteLine($"\nOperação não encontrada digite novamente\n");
                        break;

                }
            } while (op != 5);
        }
    }
}