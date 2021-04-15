using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [Serializable]
    public class Person
    {
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        public string Apellido { get; set; }
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
        [DisplayName("Teléfono Personal")]
        public string Telefono_Personal { get; set; }
        [DisplayName("Teléfono Trabajo")]
        public string Telefono_Trabajo { get; set; }
    }
}
