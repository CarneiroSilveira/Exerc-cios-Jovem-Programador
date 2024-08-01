namespace exercicios
{
    public class Estrelinhas
    {
        public static void MakeTheL()
        {
            Console.WriteLine("Digite um numero");
            int L = int.Parse(Console.ReadLine());
            for (int i = 0; i <= L; i++)
            {
                string fila1 = new('*', L+i);
                string fila2 = new('*', L+ i+ 1);
                string fila3 = new('*', L+i);
                Console.WriteLine(fila1);
                Console.WriteLine(fila2);
                Console.WriteLine(fila3);
                
            }
            Console.WriteLine("Sim a piada é pq são asteriscos 'estrelinhas'");
        }
    }
}