internal class Program
{
    private static void Main(string[] args)
    {

        int fila, columna, num, suma;
        int[,] tabla = new int[5, 4];

        for (fila = 1; fila <= 4; fila++)
        {
            suma = 0;
            for (columna = 1; columna <= 3; columna++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                tabla[fila, columna] = num;
                suma = suma + num;
            }
            Console.WriteLine("La suma de la fila " + fila + " Es: " + suma);
        }
    }
}