using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFina_PrograII.Capa_de_datos
{
    public class Registro_de_padres_o_encargados
    {
        public int numero_cedula_encargado_legal { get; set; }
        public string nombre_encargado_legal { get; set; }
        public string primer_apellido_encargado_legal { get; set; }
        public string segundo_apellido_encargado_legal { get; set; }
        public string datos_trabajo_encargado_legal { get; set; }
        public int numero_telefonico { get; set; }
        public int numero_cedula_estudiante { get; set; }

    }
}