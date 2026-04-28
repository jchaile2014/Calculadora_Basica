using System;
using System.IO;

class Calculadora
{
    static readonly string ArchivoHistorial = "historial_operaciones.txt";

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Title = "Calculadora C#";

        while (true)
        {
            Console.Clear();
            MostrarMenu();

            string opcion = Console.ReadLine()?.Trim() ?? "";

            if (opcion == "0")
            {
                Console.WriteLine("\nSaliendo... ¡Hasta luego!");
                break;
            }

            if (opcion == "6")
            {
                MostrarHistorial();
                continue;
            }

            if (!int.TryParse(opcion, out int op) || op < 1 || op > 5)
            {
                Console.WriteLine("\nOpcion invalida. Presione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            double num1 = LeerNumero("Ingrese el primer numero: ");
            double num2 = LeerNumero("Ingrese el segundo numero: ");

            double resultado;
            string simbolo;

            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    simbolo = "+";
                    break;
                case 2:
                    resultado = num1 - num2;
                    simbolo = "-";
                    break;
                case 3:
                    resultado = num1 * num2;
                    simbolo = "*";
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nError: No se puede dividir por cero.");
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                        continue;
                    }
                    resultado = num1 / num2;
                    simbolo = "/";
                    break;
                case 5:
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nError: No se puede calcular el modulo por cero.");
                        Console.WriteLine("Presione Enter para continuar...");
                        Console.ReadLine();
                        continue;
                    }
                    resultado = num1 % num2;
                    simbolo = "%";
                    break;
                default:
                    continue;
            }

            string expresion = $"{num1} {simbolo} {num2} = {resultado}";
            Console.WriteLine($"\nResultado: {expresion}");
            GuardarEnHistorial(expresion);

            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║       CALCULADORA C#         ║");
        Console.WriteLine("╠══════════════════════════════╣");
        Console.WriteLine("║  1. Suma                     ║");
        Console.WriteLine("║  2. Resta                    ║");
        Console.WriteLine("║  3. Multiplicacion           ║");
        Console.WriteLine("║  4. Division                 ║");
        Console.WriteLine("║  5. Modulo (resto)           ║");
        Console.WriteLine("║  6. Ver historial            ║");
        Console.WriteLine("║  0. Salir                    ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.Write("Seleccione una opcion: ");
    }

    static double LeerNumero(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine()?.Replace(",", ".") ?? "";
            if (double.TryParse(input, System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out numero))
                return numero;
            Console.WriteLine("Entrada invalida. Ingrese un numero valido.");
        }
    }

    static void GuardarEnHistorial(string expresion)
    {
        string linea = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]  {expresion}";
        File.AppendAllText(ArchivoHistorial, linea + Environment.NewLine);
        Console.WriteLine($"Operacion guardada en '{ArchivoHistorial}'");
    }

    static void MostrarHistorial()
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║       HISTORIAL              ║");
        Console.WriteLine("╚══════════════════════════════╝");

        if (!File.Exists(ArchivoHistorial))
        {
            Console.WriteLine("No hay operaciones guardadas aun.");
        }
        else
        {
            string[] lineas = File.ReadAllLines(ArchivoHistorial);
            if (lineas.Length == 0)
                Console.WriteLine("El historial esta vacio.");
            else
                foreach (string linea in lineas)
                    Console.WriteLine(linea);
        }

        Console.WriteLine("\nPresione Enter para volver al menu...");
        Console.ReadLine();
    }
}
