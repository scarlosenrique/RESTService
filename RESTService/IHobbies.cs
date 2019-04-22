﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el 
    //nombre de interfaz "IHobbies" en el código y en el archivo de configuración a la vez.

    [ServiceContract]
    public interface IHobbies
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string ObtenerHobbie();
    }
}
