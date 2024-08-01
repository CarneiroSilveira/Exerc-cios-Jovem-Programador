public class Fup20
{
    readonly double ipi = 0.13;
    double valorTotal;
    public void Compras()
    {

        Console.WriteLine("Digite quantas pessas com codigos diferentes serão calculadas");
        int c = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= c; i++)
        {
            Console.WriteLine("Digite o codigo dessa peça!");
            string codigo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o valor unitario de cada peça!");
            double valorUnitario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas peças serão compradas!");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            double valorCalculo = (valorUnitario * quantidade) * this.ipi + 1;
            Console.WriteLine($"O valor da compra das peças com o codigo individual ");


            this.valorTotal += valorCalculo;
        }
        Console.WriteLine($"o valor final da compra das peças foi igual a{this.valorTotal}");
    }
}