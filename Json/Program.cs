using Json.Modelo;
using System;
using System.Collections.Generic;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iniciando parser");

            /* El path esta escrito asi por un tema de que al compilar 
             * Visual Studio pone el ejecutable en /bin/debug/
             * */

            var path = "../../../Personas.json";
            List<Persona> listaPersonas = Parser.parsearJson(path);

            foreach (Persona p in listaPersonas){

                Console.WriteLine("Apellido:" + p.apellido);
                Console.WriteLine("Edad:" + p.edad);
                Console.WriteLine("Peso:" + p.peso);
                Console.WriteLine("Calle:" + p.direccion.calle);
                Console.WriteLine("Numero:" + p.direccion.numero);

                Console.WriteLine("--------------------------------");

            }

            Console.ReadLine();

        }
    }
}
