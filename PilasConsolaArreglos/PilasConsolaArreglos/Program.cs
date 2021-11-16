using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PilasConsolaArreglos
{
    class Program
    {
        static OperacionesPila Pila = new OperacionesPila(3);   // Declaración del objeto de la Pila

        static void Main(string[] args)
        {

            Int16 opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("P I L A S");
                Console.WriteLine("\n1.- Insertar dato (PUSH)");
                Console.WriteLine("2.- Eliminar dato (POP)");
                Console.WriteLine("3.- Mostrar datos de la Pila");
                Console.WriteLine("4.- Eliminar todos los datos de la Pila (VACIAR)");
                Console.WriteLine("0.- Salir");
                Console.Write("\n\nOpcion ? ");
                opcion = Int16.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: InsertarEnPila(); break;
                    case 2: EliminarEnPila(); break;
                    case 3: MostrarDatos(); break;
                    case 4: VaciarPila(); break;
                }
            } while (opcion != 0);
        }

        public static void InsertarEnPila()
        {
            int Dato = 0;
            Console.Clear(); //borra la pantalla de texto
            Console.WriteLine("INSERTAR DATO EN LA PILA");
            Console.Write("\nNúmero entero ? ");
            Dato = int.Parse(Console.ReadLine()); // Se captura el número que se desea insertar

            // Se ejecuta el método Push del objeto Pila
            if (Pila.Push(Dato))
            {
                Console.WriteLine("\nDato insertado en la pila !!!");
            }
            else
            {
                Console.WriteLine("\nPila llena ...");
            }

            Console.ReadKey();
        }

        public static void EliminarEnPila()
        {
            Console.Clear();
            Console.WriteLine("ELIMINAR El ÚLTIMO DATO ALMACENADO EN LA PILA");

            // Se ejecuta el método Push del objeto Pila
            if (Pila.Pop())
            {
                Console.WriteLine("\nDato eliminado de la pila !!!");
            }
            else
            {
                Console.WriteLine("\nPila vacía ...");
            }

            Console.ReadKey();
        }

        public static void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine("DATOS ALMACENADOS EN LA PILA");

            // Se ejecuta el método para mostrar los datos de la pila
            Console.WriteLine(Pila.Mostrar());

            Console.ReadKey();
        }

        public static void VaciarPila()
        {
            char sn;
            Console.Clear();
            Console.WriteLine("ELIMINAR TODOS LOS ELEMENTOS DE LA PILA (VACIAR)\n");

            // Solicita al usuario que confirme la operación
            do
            {
                Console.Write("¿Está seguro que desea vaciar la pila [S/N] ?");
                sn = char.Parse(Console.ReadLine());
                sn = Char.ToUpper(sn);  // Convierte a mayúsculas el caracter capturado
            } while (sn != 'S' && sn != 'N');

            if (sn == 'S')
            {
                Pila.Vaciar();  // Invoca el método correspondiente
                Console.WriteLine("\n\nSe eliminaron todos los elementos de la pila !!!");
                Console.ReadKey();
            }
            //    int tamaño;
            //    Console.WriteLine("capture el tamañoo de la pila");
            //    tamaño = int.Parse(Console.ReadLine());
            //    DatosPila[] pila = new DatosPila[tamaño];
            //    string Elemento = "";
            //    string res= "";

            //    do
            //    {
            //       Console.Write("\n\nMenú  \n 1)Ingrear elemento a la pila  \n 2)Muestra pila \n 3)Quitar elemento de la cima\n 4)Guardar pila \n 0)Salir \n\n");

            //        res= Console.ReadLine();

            //        switch (res)
            //        {
            //            case "1":
            //                Console.Write("INGRESAR VALORES A LA PILA \n");
            //                Console.Write("Escriba el dato a ingresar a la pila:");
            //                Elemento = Console.ReadLine();

            //                while (Elemento == null)
            //                {
            //                    Console.Write("Ingrese un valor válido a la pila:");
            //                    Elemento = Console.ReadLine();
            //                }

            //                if (estaLlena(pila) )
            //                {
            //                    Console.Write("La pila está llena, imposible agregar nuevo valor \n");
            //                }
            //                else
            //                {
            //                    Push(pila, Elemento);
            //                }

            //                break;

            //            case "2":
            //                Console.Write("MOSTRAR PILA \n");

            //                if (esVacia(pila))
            //                {
            //                    Console.Write("La pila está vacia \n");
            //                }
            //                else
            //                {
            //                    Mostrar(pila);
            //                }
            //                break;


            //            case "3":
            //                Console.Write("QUITAR ELEMENTO DE LA PILA \n");

            //                if (esVacia(pila))
            //                {
            //                    Console.Write("La pila tiene espacio en la disponible \n");
            //                }
            //                else
            //                {
            //                    Pop(pila);
            //                    Console.Write("El elemento de la cima suprimido");
            //                }

            //                break;

            //            case "4":
            //                string fecha = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            //                string path = @"C:\arreglosConsola\" + fecha + ".txt";
            //                using (StreamWriter sw = File.CreateText(path))
            //                {
            //                    for (int i = 0; i < pila.Length; i++)
            //                    {
            //                        sw.WriteLine(pila[i].ToString() + "");
            //                    }

            //                }
            //                break;

            //            default:
            //                Console.Write("saliendo");
            //                break;
            //        }
            //    } while (!res.Equals("0"));
            //}
            ////string fecha =DateTime.Now.ToString("yyyyMMdd_hhmmss");
            ////lc.Guardar("ListaCircular"+fecha);

            ////public void Guardar(string[] pila)
            ////{

            ////    using (StreamWriter writer = new StreamWriter("prueba.txt", false))
            ////    {
            ////        for (int i = 0; i < pila.Length; i++)
            ////        { 
            ////            writer.WriteLine(pila[i].ToString() +  "");
            ////        }
            ////    }
            ////}

            //static public bool esVacia(DatosPila[] pila)
            //{
            //    bool fl = true;

            //    for (int i = pila.Length - 1; i >= 0; i--)
            //    {
            //        if (pila[i] != null)
            //        {
            //            fl = false;
            //            break;
            //        }
            //    }
            //    return fl;
            //}

            //static public bool estaLlena(DatosPila[] pila)
            //{
            //    bool fl = false;
            //    int count = 0;

            //    for (int i = pila.Length - 1; i >= 0; i--)
            //    {
            //        if (pila[i] != null)
            //        {
            //            count += 1; 
            //        }
            //    }

            //    if (count == pila.Length)
            //    { 
            //        fl = true; 
            //    }

            //    return fl;
            //}
            //static public bool Pop(DatosPila[] pila)
            //{
            //    bool fl = false;

            //    for (int i = pila.Length - 1; i >= 0; i--)
            //    {
            //        if (pila[i] != null)
            //        {
            //            pila[i] = null;
            //            fl = true;
            //            break;
            //        }
            //    }

            //    return fl;
            //}
            //static public bool Push(DatosPila[] pila, string elemento)
            //{
            //    bool fl = false;

            //    for (int i = pila.Length - 1; i >= 0; i--)
            //    {
            //        if (pila[i] != null)
            //        {
            //            pila[i + 1] = elemento;
            //            fl = true;
            //            break;
            //        }
            //        else if (pila[i] == null && i == 0)
            //        {
            //            pila[i] = elemento;
            //            fl = true;
            //            break;
            //        }
            //    }
            //    return fl;
            //}
            //static public void Mostrar(DatosPila[] pila)
            //{
            //    for (int i = pila.Length - 1; i >= 0; i--)
            //    {
            //        if (pila[i] != null)
            //        {
            //            Console.Write(pila[i] + "\n");
            //        }
            //    }

        }
    }
    
}
