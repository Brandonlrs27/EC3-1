using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC3_1
{
    class Program
        //Lares Dominguez Brandon
    {
        static void Main(string[] args)
        {
            var Pila = new Stack();
            Pila.Push("Brandon");
            Pila.Push("Jonatan");
            Pila.Push("Issac");
            Pila.Push(444);
            //Muestra los datos de la pila.

            Console.WriteLine("La pila contiene :");
            foreach(var valor in Pila)
            {
                Console.WriteLine(valor);
            }

            //Revisa si existe la cadena Issac.
            Console.WriteLine("La pila contiene a Issac: ");
            bool tiene = Pila.Contains("Issac");

            Console.WriteLine(tiene); 

            Console.WriteLine(Pila.Pop().GetType()); //Nos dice tipo de instancia actual.

            Console.WriteLine(Pila.ToString()); //Devuelve los datos en un String.
            Console.WriteLine(Pila.ToArray()); //Copia los datos de la pila a una nueva matriz.
            Console.WriteLine(Pila.GetEnumerator()); //Utiliza enumeradores para recorrer la pila.
            Console.ReadKey(); 
                    
                   
        }
    }
}
