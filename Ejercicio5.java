import java.util.Scanner;

public class Ejercicio5 {
    public static void main(String[] args) {
        int[] Arreglo = {100, 200, 300, 400, 500};
        char Continuar = 'S';
        int Valor_a_Buscar;
        boolean encontrado;

        Scanner scanner = new Scanner(System.in);

        do {
            System.out.println("Ingrese valor a buscar: ");
            Valor_a_Buscar = scanner.nextInt();

            encontrado = false;

            for (int i = 0; i < Arreglo.length; i++) {
                if (Arreglo[i] == Valor_a_Buscar) {
                    System.out.println("El valor ingresado se encuentra en la posición: " + i);
                    encontrado = true;
                }
            }

            if (!encontrado) {
                System.out.println("El valor ingresado no se encuentra en el arreglo.");
            }

            System.out.print("¿Desea probar con otro valor? (S/N): ");
            Continuar = scanner.next().toUpperCase().charAt(0);

        } while (Continuar == 'S');

        scanner.close();
    }
}
