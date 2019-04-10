using Json.Modelo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Json
{
    public static class Parser
    {

        public static List<Persona> parsearJson(string path)
        {
            
            // LEE ARCHIVO .JSON
            string json = System.IO.File.ReadAllText(path);

            /* Aca faltan catchear excepciones lo dejo asi aproposito para que
             * vean que a diferencia de Java, a .NET no le importa si catcheas excepciones o no
             * como asi tampoco te avisa si algun metodo tira alguna, para saber eso lo tenes 
             * que consultar poniendo el mouse sobre el metodo a usar para que te las enliste
             * */

            // PARSER MAGICO
            List<Persona> listaPersonas = JsonConvert.DeserializeObject<JObject>(json).Value<JArray>("personas").ToObject<List<Persona>>();

            /* - Value<JArray>("personas"): Indica al converter que para convertir los objetos se 
             *                            pare sobre la key "personas" que corresponde a un Array de Json
             * - ToObject<List<Persona>: Indica que ese JArray debe ser convertido a una lista de personas
             * */

            return listaPersonas;

        }

    }
}
