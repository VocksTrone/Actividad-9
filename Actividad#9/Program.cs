using Actividad_9;

bool generalContinue = true;
List <Accounts> accountsList = new List <Accounts> ();
while (generalContinue)
{
    try
    {
        MostrarSwitch(ref accountsList, ref generalContinue);
    }
    catch (FormatException)
    {
        Console.WriteLine("\nError!, Datos Incorrectos");
        Console.ReadKey();
    }
}
static int MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("1. Agregar Cuenta");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Retirar");
    Console.WriteLine("4. Modificar Tipo de Cuenta");
    Console.WriteLine("5. Consultar Saldo");
    Console.WriteLine("6. Mostrar Datos");
    Console.WriteLine("7. Salir");
    int menuOption = int.Parse(Console.ReadLine());
    return menuOption;
}
static bool Salir(ref bool generalContinue)
{
    Console.Clear();
    Console.WriteLine("Usted está Saliendo del Programa");
    generalContinue = false;
    return generalContinue;
}
static void MostrarSwitch(ref List<Accounts> accountsList, ref bool generalContinue)
{
    switch (MostrarMenu())
    {
        case 1:
            Accounts.AgregarCuenta(ref accountsList);
            break;
        case 2:
            Accounts.Depositar(ref accountsList);
            break;
        case 3:
            Accounts.Retirar(ref accountsList);
            break;
        case 4:
            Accounts.Modificar(ref accountsList);
            break;
        case 5:
            Accounts.ConsultarSaldo(ref accountsList);
            break;
        case 6:
            Accounts.MostrarDatos(ref accountsList);
            break;
        case 7:
            Salir(ref generalContinue);
            break;
        default:
            Console.WriteLine("Ingrese una Opción Válida (1 - 7)");
            Console.ReadKey();
            break;
    }
}
