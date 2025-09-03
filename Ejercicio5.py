Arreglo = [150, 250, 350, 450, 550]
Continuar = "S"

Valor_Encontrar = None

Encontrado = None

while Continuar.upper() == "S":
    Valor_Encontrar = int(input("Ingrese Valor a buscar "))
    Encontrado = False

    for i in range(len(Arreglo)):
        if Arreglo[i] == Valor_Encontrar:
            print("El Valor Se ingresado se encuentra en la posicion: ", i)
            Encontrado = True

    if not Encontrado:
     print( "El valor ingresado no se encuentra en el arreglo.")

    Continuar = input("Desea probar con otro valor? (S/N)")
