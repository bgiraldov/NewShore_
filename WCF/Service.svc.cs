using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service.svc o Service.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service : IService
    {
        public bool EsCliente(string contenido, string nombre)
        {
            bool respuesta = true;

            char[] letras = contenido.ToLower().ToCharArray();
            foreach (char subNombre in nombre.ToLower().ToCharArray())
                if (!letras.Contains(subNombre))
                    respuesta = false;

            return respuesta;
        }
    }
}
