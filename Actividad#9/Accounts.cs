using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_9
{
    internal class Accounts
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public static void AgregarCuenta(ref List<Accounts> accountsList)
        {
            Console.Clear();
            Banco();
            Console.Write("\nIngrese el ID de la Cuenta: ");
            string id = Console.ReadLine();
            Console.Write("\nIngrese el Nombre de la Cuenta: ");
            string name = Console.ReadLine();
            Console.Write("\nIngrese el Tipo de Cuenta (Monetaria | Ahorro): ");
            string type = Console.ReadLine();
            Console.Write("\nIngrese el Monto Inicial de la Cuenta: ");
            double amount = double.Parse(Console.ReadLine());
            Accounts addAccount = accountsList.Find(p => p.ID == id);
            if (addAccount == null)
            {
                Console.WriteLine("\nCuenta Añadida Exitosamente");
                Accounts newAccount = new Accounts(id, name, type, amount);
                accountsList.Add(newAccount);
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nLa Cuenta Ya Existe");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
        }
        public static void Depositar(ref List<Accounts> accountsList)
        {
            Console.Clear();
            Banco();
            Console.Write("\nIngrese el ID de la Cuenta: ");
            string id = Console.ReadLine();
            Accounts addAccount = accountsList.Find(p => p.ID == id);
            if (addAccount != null)
            {
                Console.WriteLine("\nCuenta Encontrada");
                Console.Write("\nIngrese la Cantidad a Depositar: ");
                double deposit = double.Parse(Console.ReadLine());
                addAccount.Amount = Math.Round(addAccount.Amount + deposit, 2);
                Console.WriteLine("\nDepósito Realizado con Éxito");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nLa Cuenta No Existe");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
        }
        public static void Retirar(ref List<Accounts> accountsList)
        {
            Console.Clear();
            Banco();
            Console.Write("\nIngrese el ID de la Cuenta: ");
            string id = Console.ReadLine();
            Accounts addAccount = accountsList.Find(p => p.ID == id);
            if (addAccount != null)
            {
                Console.WriteLine("\nCuenta Encontrada");
                Console.Write("\nIngrese la Cantidad a Retirar: ");
                double withdraw = double.Parse(Console.ReadLine());
                if (withdraw <= addAccount.Amount)
                {
                    addAccount.Amount = Math.Round(addAccount.Amount - withdraw, 2);
                    Console.WriteLine("\nRetiro Realizado con Éxito");
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nEl Monto de la Cuenta es Insuficiente");
                    Console.WriteLine("Presione Enter para continuar...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\nLa Cuenta No Existe");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
        }
        public static void Modificar(ref List<Accounts> accountsList)
        {
            Console.Clear();
            Banco();
            Console.Write("\nIngrese el ID de la Cuenta: ");
            string id = Console.ReadLine();
            Accounts addAccount = accountsList.Find(p => p.ID == id);
            if (addAccount != null)
            {
                Console.WriteLine("\nCuenta Encontrada");
                Console.Write("\nIngrese la Nuevo Tipo de Cuenta (Monetaria | Ahorro): ");
                string newType = Console.ReadLine();
                addAccount.Type = newType;
                Console.WriteLine("\nEl Tipo de Cuenta fue Actualizado con Éxito");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nLa Cuenta No Existe");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
        }
        public static void ConsultarSaldo(ref List<Accounts> accountsList)
        {
            Console.Clear();
            Banco();
            Console.Write("\nIngrese el ID de la Cuenta: ");
            string id = Console.ReadLine();
            Accounts addAccount = accountsList.Find(p => p.ID == id);
            if (addAccount != null)
            {
                Console.WriteLine("\nCuenta Encontrada");
                foreach (Accounts accountAdd in accountsList)
                {
                    if (addAccount.ID == id)
                    {
                        Console.WriteLine($"\nEl Saldo de la Cuenta es: Q.{Math.Round(accountAdd.Amount, 2)}");
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.WriteLine("\nLa Cuenta No Existe");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
        }
        public static void MostrarDatos(ref List<Accounts> accountsList)
        {
            Console.Clear();
            Banco();
            if (accountsList.Count == 0)
            {
                Console.WriteLine("\nNo Existen Cuentas Registradas");
                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.Write("\nIngrese el ID de la Cuenta: ");
                string id = Console.ReadLine();
                Accounts addAccount = accountsList.Find(p => p.ID == id);
                if (addAccount != null)
                {
                    foreach (Accounts accountAdd in accountsList)
                    {
                        if (accountAdd.ID == id)
                        {
                            Console.WriteLine($"\nID: {accountAdd.ID}");
                            Console.WriteLine($"\nNombre: {accountAdd.Name}");
                            Console.WriteLine($"\nTipo de Cuenta: {accountAdd.Type}");
                            Console.WriteLine($"\nMonto: Q.{accountAdd.Amount}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nLa Cuenta No Existe");
                }
                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadKey();
            }
        }
        public static void Banco()
        {
            Console.WriteLine("Bienvenido al Banco 'El Patrón'");
        }
        public Accounts(string id, string name, string type, double amount)
        {
            ID = id;
            Name = name;
            Type = type;
            Amount = amount;
        }
    }
}