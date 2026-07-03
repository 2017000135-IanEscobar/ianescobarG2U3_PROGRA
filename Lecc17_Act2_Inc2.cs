internal class Program
{
    private static void Main(string[] args)
    {

        int numeroFila, numeroColumna;
        int[,] matrizColumnas = new int[5, 5];

        for (numeroFila = 1; numeroFila <= 4; numeroFila++)
        {
            for (numeroColumna = 1; numeroColumna <= 4; numeroColumna++)
            {
                matrizColumnas[numeroFila, numeroColumna] = numeroColumna;
            }
        }

        Console.WriteLine("Matriz Columnas");
        for (numeroFila = 1; numeroFila <= 4; numeroFila++)
        {
            for (numeroColumna = 1; numeroColumna <= 4; numeroColumna++)
            {
                Console.Write(matrizColumnas[numeroFila, numeroColumna] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}