using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Net;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

namespace RESTService
{
    public class Mensajes : IMensajes
    {
        string IMensajes.ObtenerSaludo()
        {
            ////////////////// se define el Uri /////////////////////////////
            HttpWebRequest rest = WebRequest.Create("http://localhost:59182/Hobbies.svc/obtenerHobbie") as HttpWebRequest;
            HttpWebResponse response = rest.GetResponse() as HttpWebResponse;
            ////////////////////////////////////////////////////////////////

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string hobbie = reader.ReadToEnd();
            string alias = " ";

            ////////////////////////////////////////////////////////////////

            if (hobbie == "futbol")
            {
                alias = "habla causa";
            }
            else
            {
                alias = "habla Partner";
            }
            var hora = DateTime.Now.Second;
            if (hora < 20)
            {
                return alias + " Buenos Dias";
            }
            else if (hora < 40)
            { 
                return alias + " Buenas Tardes";
            }
            else
                return alias + " Buenas Noches";       
        }
    }
}
