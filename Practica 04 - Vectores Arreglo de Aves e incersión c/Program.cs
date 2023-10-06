using System;

class program
{
    const int maxf = 3;
    const int maxc = 5;

    static void Main(string[] args)
    {

        float[,] a = new float[maxf, maxc];
        int f, c;
        Console.Write("Asigna los numeros para rellenar la matriz  3x5:");
        Console.Write("\n");
        for (f = 0; f < maxf; f++)
        {
            for (c = 0; c < maxc; c++)
            {
                a[f, c] = float.Parse(Console.ReadLine());
            }
        }
        Console.Write("La matriz resultante de 3x5 es:");
        Console.Write("\n\n");
        for (f = 0; f < maxf; f++)
        {
            for (c = 0; c < maxc; c++)
            {
                Console.Write(a[f, c] + "    ");
            }
            Console.Write("\n");
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}