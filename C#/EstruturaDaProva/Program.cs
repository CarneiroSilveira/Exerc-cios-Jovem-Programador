namespace exercicios;

class EstruturaDaProva
{
    static void Main(string[] asgs)
    {
        Console.WriteLine("Digite qual a FUP vc quer acessar!");
        int op = Convert.ToInt32(Console.ReadLine());
        do
        {
            switch (op)
            {
                case 1:
                    //Fup 8
                    Console.WriteLine("Digite um numero para ver sua tabuada:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Fup8.Tabuada(num);
                    break;
                case 2:
                    //Fup 15
                    Console.WriteLine("\nDigite o valor de a: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("\nDigite o valor de b: ");
                    float b = float.Parse(Console.ReadLine());
                    Console.WriteLine("\nDigite o valor de c: ");
                    float c = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a base");
                    float baseE = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura");
                    float altura = float.Parse(Console.ReadLine());
                    if (Fup15.IsTriangle(a, b, c))
                    {
                        Fup15.CalcularArea(baseE, altura);
                    }
                    break;
                case 3:
                    //Fup 20
                    Fup20 fup20 = new Fup20();
                    fup20.Compras();
                    break;
                case 4:
                    //Fup 25
                    Fup25 fup25 = new();
                    fup25.CalcMediaAltura();
                    break;
                case 5:
                    //Fup 28
                    Fup28.IsNegative();
                    break;
                case 6:
                    //Desafio
                    Estrelinhas.MakeTheL();
                    break;
                case 7:
                    //Finalizar
                    Console.WriteLine($"-----------Finalizando-----------");
                    break;
                default:
                    Console.WriteLine($"Agora digite qual exercicio quer acessar agora: atual {op}ª");
                    string entrada = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(entrada))
                    {
                        Console.WriteLine($"Dado o resultado nulo o programa ira repetir o novamente o exercicio anterior");
                    }
                    else
                    {
                        op = !string.IsNullOrWhiteSpace(entrada) ?
                        int.Parse(entrada) :
                        0;
                    }
                    break;
            }
        } while (op != 7);
    }
}