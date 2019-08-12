using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domotica_mysql.Data.CustomIdentity;

namespace Domotica_mysql.Data
{
    public class Usuarios
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //lo he puesto en mayusculas el DNI por convención 
        public string DNI { get; set; }
        /* Esta sera la cadena donde esta almacenada la imagen dentro de nuestra propia aplicación, esto conlleva que si 
         * borro la imagen, tengo que dejar la cadena esta vacia
         */
        public string Imagen { get; set; }
        public string Role { get; set; }
        public int ApplicationUserId { get; set; }
        //foreign key de la tabla aspnetusers
        public virtual ApplicationUser ApplicationUser { get; set; }
        
    }
}
