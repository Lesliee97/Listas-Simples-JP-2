using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int opcionmenu = 0;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine(" |---------------------------------|");
                Console.WriteLine(" |        * LISTA    SIMPLE *      |");
                Console.WriteLine(" |-----------------|---------------|");
                Console.WriteLine(" | 1.-Insertar     | 2. Eliminar   |");
                Console.WriteLine(" | 3.-Mostrar      | 4. Salir      |");
                Console.WriteLine(" |-----------------|---------------|");
                Console.Write("\n Escoja una opción: ");
                opcionmenu = int.Parse(Console.ReadLine());
                switch (opcionmenu)
                {
                    case 1:
                        Console.WriteLine("\n\n INSERTAR LA EDAD \n");
                        l.InsertarNodo();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n\n ELIMINAR LA EDAD \n");
                        l.EliminarNodo();
                        break;
                    case 3:
                        Console.WriteLine("\n\n MOSTRAR LA EDAD \n");
                        l.Mostrarlista();
                        break;
                    case 4:
                        Console.WriteLine("\n\n Programa finalizado... \n");
                        break;
                    default:
                        Console.WriteLine("\n\n Opción No Valida \n");
                        break;
                }
            } while (opcionmenu != 4);
        }
    }
}
