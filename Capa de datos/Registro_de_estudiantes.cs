using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFina_PrograII.Capa_de_datos
{
    public class Registro_de_estudiantes
    {
        public int numero_cedula_estudiante { get; set; }  
        public string nombre_estudiante { get; set;}
        public string primer_apellido_estudiante { get; set; }
        public string segundo_apellido_estudiante { get; set; }
        public DateTime fecha_nacimiento_estudiante { get; set; }
        public string direccion_estudiante { get; set; }
        public int grado_a_matricular { get; set; }
        public int adjuntos { get; set; }
    }
}