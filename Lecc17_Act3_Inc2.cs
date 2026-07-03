internal class Program
{
    private static void Main(string[] args)
    {

        int fila, columna, x, yy, mayorr;
        int[,] tabla = new int[5, 5];

        for (fila = 1; fila <= 4; fila++)
        {
            for (columna = 1; columna <= 4; columna++)
            {
                Console.WriteLine("Ingrese un numero: ");
                tabla[fila, columna] = Convert.ToInt32(Console.ReadLine());
            }
        }

        mayorr = tabla[1, 1];
        x = 1;
        yy = 1;

        for (fila = 1; fila <= 4; fila++)
        {
            for (columna = 1; columna <= 4; columna++)
            {
                if (tabla[fila, columna] > mayorr)
                {
                    mayorr = tabla[fila, columna];
                    x = fila;
                    yy = columna;
                }
            }
        }

        Console.WriteLine("El numero mayor es: " + mayorr);
        Console.WriteLine("Esta en la fila " + x);
        Console.WriteLine("Y En la columna: " + yy);
    }
}