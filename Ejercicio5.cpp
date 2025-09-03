#include <iostream>
using namespace std;
 
int main(){
    int Arreglo[] = {100, 200, 300, 400, 500};
    char Continuar;
    int Valor_a_Buscar;

    Continuar = 'S';
    bool encontrado;

    do{
        cout<< "Ingrese Valor a buscar" << endl;
        cin >> Valor_a_Buscar;

        encontrado = false;

        for(int i = 0; i < 5; i++){
            if(Arreglo[i] == Valor_a_Buscar){
                cout << "El Valor Se ingresado se encuentra en la posicion: " << i << endl;
               encontrado = true;
            }
        }
        
        if (!encontrado) {
            cout << "El valor ingresado no se encuentra en el arreglo." << endl;
        }   

        cout << "Desea probar con otro valor? ";
        cin >> Continuar;


    } while (Continuar == 'S');

}