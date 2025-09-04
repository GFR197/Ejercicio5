// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        int[] Arreglo = { 100, 200, 300, 400, 500 };
        char Continuar = 'S';
        int Valor_a_Buscar;
        bool encontrado;

        do
        {
            Console.WriteLine("Ingrese valor a buscar:");
            Valor_a_Buscar = int.Parse(Console.ReadLine());

            encontrado = false;

            for (int i = 0; i < Arreglo.Length; i++)
            {
                if (Arreglo[i] == Valor_a_Buscar)
                {
                    Console.WriteLine($"El valor ingresado se encuentra en la posición: {i}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El valor ingresado no se encuentra en el arreglo.");
            }

            Console.Write("¿Desea probar con otro valor? (S/N): ");
            Continuar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

        } while (Continuar == 'S');
    }
}
