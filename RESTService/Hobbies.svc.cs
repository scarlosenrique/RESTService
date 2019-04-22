using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Hobbies" 
    // en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Hobbies.svc o 
    // Hobbies.svc.cs en el Explorador de soluciones e inicie la depuración.

    public class Hobbies : IHobbies
    {
        public string ObtenerHobbie()
        {
            if (DateTime.Now.Second % 2 == 0)
            {
                Console.Write("tenis");
                return "Tenis";
            }
            else
            {
                Console.Write("futbol");
                return "futbol";
            }
        }
    }
}
