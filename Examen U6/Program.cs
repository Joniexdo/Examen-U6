using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Examen_U6
{
    class Program
    {
        //Clase de inventarios de amazon
        class InventariosAmazon
        {

            public void RegistrarProducto()
            {
                StreamWriter sw = new StreamWriter("Productos.txt", true);
                try
                {
                    Console.Clear();
                    Console.Write("\nIngrese el producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese la descripcion: ");
                    string descripcion = Console.ReadLine();
                    Console.Write("Ingrese el precio: ");
                    float P = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la cantidad en Stock: ");
                    int cStock = int.Parse(Console.ReadLine());
                    Console.Clear();

                    sw.WriteLine("\nNombre del producto: " + nombre);
                    sw.WriteLine("Descripcion: " + descripcion);
                    sw.WriteLine("Precio: {0:C}", P);
                    sw.WriteLine("Cantidad en Stock: " + cStock);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.Clear();
                    Console.WriteLine("El roducto fue agregado en el inventario");
                    Console.Write("\n Presione Enter para regresar ");
                    sw.Close();
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            public void LI()
            {
                Console.Clear();
                StreamReader sr = new StreamReader("Productos.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
                Console.WriteLine();
                Console.WriteLine("Presione Enter para regresar ");
                Console.ReadKey();
                Console.Clear();
            }
            public void LimpiarI ()
            {
                Console.Clear();
                StreamWriter sw = new StreamWriter("Productos.txt", false);
                Console.WriteLine("Inventario limpio");
                Console.WriteLine("Presione Enter para regresar ");
                Console.ReadKey();
            }
    }
        static void Main(string[] args)
        {
            int opcion;

            InventariosAmazon inv = new InventariosAmazon();
            do
            {
                Console.Write("\nExamen Unidad 6 - Inventarios para amazon ");

                Console.Write("\n\n¿Qué opción desea? ");

                Console.WriteLine("\n\n1. Ingresar producto de amazon ");
                Console.WriteLine("2. Ver inventario de amazon ");
                Console.WriteLine("3. Limpiar inventario de amazon ");
                Console.WriteLine("4. Salir del programa ");
                opcion = Int16.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        inv.RegistrarProducto();
                        break;
                    case 2:
                        inv.LI();
                        break;
                    case 3:
                        inv.LimpiarI();
                        break;
                    case 4:
                        Console.WriteLine("Precione Enter para salir");
                        break;
                    default:
                        Console.Write("no hay opcion");
                        Console.Write("Presione Enter para Continuar ");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 3);

        }
    }
} 
