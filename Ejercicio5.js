const prompt = require('prompt-sync')(); 


let Arreglo = [1500, 2500, 3500, 4500, 5500]
Continuar = "S";

let Valor_A_Encontrar

Encontrado = null

while(Continuar.toUpperCase() === "S"){
    let Valor_A_Encontrar = parseInt(prompt("Ingrese Valor a buscar "));
    Encontrado = false

    for(let i = 0; i < Arreglo.length; i++){
        if(Arreglo[i] == Valor_A_Encontrar){
            console.log("El Valor Se ingresado se encuentra en la posicion: "+ i);
            Encontrado = true;
        }
        
    }
    if(!Encontrado){
        console.log("El valor ingresado no se encuentra en el arreglo.");
    }

    Continuar = prompt("Desea probar con otro valor? (S/N ");
}

