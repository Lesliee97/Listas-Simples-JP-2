using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA1_02
{
    class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingreese el dato de las edades: ");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if(Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                Ultimo = nuevo;
            }
            Console.WriteLine("\n La Edad ingresada\n");
        }

        public void Mostrarlista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if(Primero !=null)
            {
                while(Actual !=null)
                {
                    Console.WriteLine(" {0} ", Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La lista de edad se encuentra vacia \n");
            }
        }

        public void EliminarNodo()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            bool Encontrado = false;

            Console.Write("Ingrese la edad a buscar para eliminar: ");
            int nodoBuscado = int.Parse(Console.ReadLine());

            if(Primero != null)
            {
                while(Actual !=null && Encontrado !=true)
                {
                    if(Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n La edad ({0}) Encontrado \n", nodoBuscado);
                        //eliminar NODO
                        if(Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if(Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }
                        Console.WriteLine("\n Edad Eliminada!!");
                        Encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if(!Encontrado)
                {
                    Console.WriteLine("\n La edad no Encontrada");
                }
            }
            else
            {
                Console.WriteLine("\n La lista de edades se encuentra Vacia \n");
            }
        }

    }
}
