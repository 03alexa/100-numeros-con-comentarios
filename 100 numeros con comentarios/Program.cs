using System;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            // Crear una cola original
            Queue original = new Queue();
            // Crear un generador de números aleatorios
            Random rnd = new Random();
            // Generar 100 números aleatorios en el rango -25 .. +25 y añadirlos a la cola original
            for (int i = 0; i < 100; i++)
            {
                int num = rnd.Next(-25, 26);
                original.Enqueue(num);
            }
            // Mostrar el contenido de la cola original
            Console.WriteLine("Cola original:");
            PrintQueue(original);

            // Crear una cola para los números negativos
            Queue negativos = new Queue();
            // Recorrer la cola original y extraer los números negativos
            foreach (int num in original)
            {
                if (num < 0)
                {
                    negativos.Enqueue(num);
                }
            }
            // Mostrar el contenido de la cola de números negativos
            Console.WriteLine("Cola negativos:");
            PrintQueue(negativos);
        }

        // Método para imprimir el contenido de una cola
        static void PrintQueue(Queue q)
        {
            foreach (object obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

