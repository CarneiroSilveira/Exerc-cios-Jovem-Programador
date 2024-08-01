namespace exercicios;

public class Fup25
{
    public int Quantidade { get; set; }
    public float AlturaTotal { get; set; }
    public float Resultado { get; set; }


    public void CalcMediaAltura()
    {
        Console.WriteLine("Digite a quantidade de usuários");
        Quantidade = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= Quantidade; i++)
        {
            Console.WriteLine($"Digite a altura do {i}ª usuario");
            float usuarioAtual = float.Parse(Console.ReadLine());
            AlturaTotal += usuarioAtual;
        }
        Resultado = AlturaTotal / Quantidade;
        Console.WriteLine($"A media da altura dos usuários é {Resultado}");

    }
}