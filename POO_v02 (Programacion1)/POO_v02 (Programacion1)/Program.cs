using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_v02__Programacion1_
{
    class Program
    {
        static void Main(string[] args)
        {
            APARTAMENTO apart = new APARTAMENTO();

            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Eliga una opcion del menu: ");
                Console.WriteLine("INICIAR  [1]");
                Console.WriteLine("VENDER   [2]");
                Console.WriteLine("ALQUILAR [3]");
                Console.WriteLine("SALIR    [4]");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        apart.INICIALIZAR();
                        break;
                    case 2:
                        apart.VENDER();
                        break;
                    case 3:
                        apart.ALQUILAR();
                        break;
                    default:
                        apart.DEFAULT();
                        break;
                }
            } while (opcion != 4);

        }
    }
    public class APARTAMENTO
    {
       public string direccion, color, áreacontruccion, linea;
        public int parqueos, habitaciones, baños;

        public void INICIALIZAR()
        {
            Console.Clear();
            Console.Write("Ingrese la dirrecion: ");
            direccion = Console.ReadLine();
            Console.Write("Introduzca el color: ");
            color = Console.ReadLine();
            Console.Write("Por favor, digite el area de construcion: ");
            áreacontruccion = Console.ReadLine();
            Console.Write("Digite la cantidad de parqueo: ");
            linea = Console.ReadLine();
            parqueos = int.Parse(linea);
            Console.Write("Favor de ingresar el numero de habitaciones: ");
            linea = Console.ReadLine();
            habitaciones = int.Parse(linea);
            Console.Write("Introduzca la cantidad de baños: ");
            linea = Console.ReadLine();
            baños = int.Parse(linea);
            Console.ReadKey();
        }

        public void VENDER()
        {
            Console.Clear();
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Área Construcción: "+áreacontruccion);
            Console.WriteLine("Parqueos: " + parqueos);
            Console.WriteLine("Habitaciones: " + habitaciones);

            Console.ReadKey();

        }

        public void ALQUILAR()
        {
            Console.Clear();
            Console.WriteLine("Dirección: " +direccion);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Parqueos: "+parqueos);
            Console.WriteLine("Habitaciones: "+habitaciones);
            Console.WriteLine("baños: "+baños);

            Console.ReadKey();
        }

        public void DEFAULT()
        {
            Console.Clear();
            Console.WriteLine("GRACIAS POR PREFERIRNOS!!");
            Console.WriteLine("Saliendo del programa...");
            Console.ReadKey();
        }
    }
    
}
