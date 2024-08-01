public class Fup15
{
    public static bool IsTriangle(float a, float b, float c)
    {
        if (a < b + c && b < a + c && c < a + b)
        {
            Console.WriteLine("\nOs valores formam um triângulo!");
            return true;
        }
        else
        {
            Console.WriteLine("Os valores não formam um triângulo.\n");
            Console.WriteLine($"Valores lidos: a = {a}, b = {b}, c = {c}\n");
            return false;
        }
    }

    public static void CalcularArea(float baseE, float altura)
    {
        float area = (baseE * altura) / 2;
        Console.WriteLine($"\nA área do triângulo é: {area}\n");
    }
}