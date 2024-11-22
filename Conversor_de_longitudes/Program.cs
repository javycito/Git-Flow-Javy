Console.Clear();// Limpia la consola

//While para volver a empezar
while (true)
{
    Console.WriteLine("---Seleccione la unidad de longitud que desea convertir: ");
    Console.WriteLine("1. Metros");
    Console.WriteLine("2. Pies");
    Console.WriteLine("3. Pulgadas");
    Console.WriteLine("4. Millas");
    Console.WriteLine("5. Centímetros");
    Console.WriteLine("6. Kilómetros");
    Console.WriteLine("0. Salir");
    Console.Write("---> ");

    int inputOption = Convert.ToInt32(Console.ReadLine());

    if (inputOption == 0)
    {
        Console.WriteLine("---Saliendo del programa");
        break;
    }

    Console.WriteLine("---Ingrese la longitud: ");
    Console.Write("---> ");

    double inputLength = Convert.ToDouble(Console.ReadLine());
    double result = 0;

    Console.WriteLine("---Seleccione la unidad de longitud a la que desea convertir:");
    Console.WriteLine("1. Metros");
    Console.WriteLine("2. Pies");
    Console.WriteLine("3. Pulgadas");
    Console.WriteLine("4. Millas");
    Console.WriteLine("5. Centímetros");
    Console.WriteLine("6. Kilómetros");
    Console.Write("---> ");

    int outputOption = Convert.ToInt32(Console.ReadLine());

    switch (inputOption)
    {
        case 1: // Metros
            switch (outputOption)
            {
                case 1: // Metros a Metros
                    Console.WriteLine("--Ya estás en Metros. No es necesario convertir.");
                    break;
                case 2: // Metros a Pies
                    result = inputLength * 3.28084;
                    Console.WriteLine("--{0} metros son {1} pies.", inputLength, result);
                    break;
                case 3: // Metros a Pulgadas
                    result = inputLength * 39.3701;
                    Console.WriteLine("--{0} metros son {1} pulgadas.", inputLength, result);
                    break;
                case 4: // Metros a Millas
                    result = inputLength / 1609.34;
                    Console.WriteLine("--{0} metros son {1} millas.", inputLength, result);
                    break;
                case 5: // Metros a Centímetros
                    result = inputLength * 100;
                    Console.WriteLine("--{0} metros son {1} centímetros.", inputLength, result);
                    break;
                case 6: // Metros a Kilómetros
                    result = inputLength / 1000;
                    Console.WriteLine("{0} metros son {1} kilómetros.", inputLength, result);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
//Para volver a empezar
Console.WriteLine("\n---¿Desea realizar otra conversion? (s/n): ");
    string ContinueOption = Console.ReadLine().ToLower();
    
    if(ContinueOption != "s")
    {
        Console.WriteLine("---Saliendo del Programa");
        break;
    }
}
