using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Gestion_de_Matricula
    {
        static List<Estudiante> estudiantes = new List<Estudiante>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hola, bienvenido al menu de Gestion de Matricula de Estudiantes - Liceo Regional de Flores");
                Console.WriteLine("1- Crear Matricula de Estudiante");
                Console.WriteLine("2- Consultar Matricula de Estudiante");
                Console.WriteLine("3- Modificar datos de Matricula de Estudiante");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Por favor selecciona una de las siguientes opciones");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Crear();
                        break;
                    case "2":
                        Consultar();
                        break;
                    case "3":
                        Modificar();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opcion no valida, digite del 1 al 4");
                        break;
                }
            }
        }

        static void Crear()
        {
            Console.WriteLine("Creacion de Matricula de Estudiante");

            Console.WriteLine("Digite nombre y apellidos del estudiante");
            string nombre_y_apellidos_estudiante = Console.ReadLine();

            Console.WriteLine("Digite el numero de cedula del estudiante");
            string numero_cedula_estudiante = Console.ReadLine();

            Console.WriteLine("Digite fecha de nacimiento del estudiante");
            string fecha_nacimiento = Console.ReadLine();

            Console.WriteLine("Digite nombre y apellidos del encargado legal");
            string nombre_y_apellidos_encargado_legal = Console.ReadLine();

            Console.WriteLine("Digite numero de cedula del encargado legal");
            string numero_cedula_encargado_legal = Console.ReadLine();

            Console.WriteLine("Digite la direccion de residencia");
            string direccion_estudiante = Console.ReadLine();

            Console.WriteLine("Digite el Numero de Telefono");
            string numero_telefonico = Console.ReadLine();

            Console.WriteLine("Digite los datos del lugar de trabajo del encargado legal");
            string datos_trabjo_encargado = Console.ReadLine();

            Console.WriteLine("Digite el Grado lectivo por matricular (numero del 7 al 11)");
            int grado_a_matricular = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Adjunta Documento: Notas o certificación de último curso lectivo aprobado? (S/N)");
            string adjuntosInput = Console.ReadLine();
            bool adjuntos = adjuntosInput.ToUpper() == "S";

            Console.WriteLine("¿Solicita beca de comedor? (S/N)");
            string becaComedorInput = Console.ReadLine();
            bool beca_de_comedor = becaComedorInput.ToUpper() == "S";

            Console.WriteLine("Seleccione el estado de matricula (Activa/Inactiva)");
            string estadomatriculaInput = Console.ReadLine();
            bool estado_matricula = estadomatriculaInput.ToUpper() == "Activa";

            Estudiante estudiante = new Estudiante
            {
                NombreEstudiante = nombre_y_apellidos_estudiante,
                CedulaEstudiante = numero_cedula_estudiante,
                FechaNacimiento = fecha_nacimiento,
                NombreEncargado = nombre_y_apellidos_encargado_legal,
                CedulaEncargado = numero_cedula_encargado_legal,
                Direccion = direccion_estudiante,
                Telefono = numero_telefonico,
                TrabajoEncargado = datos_trabjo_encargado,
                Grado = grado_a_matricular,
                NotasAdjuntas = adjuntos,
                BecaComedor = beca_de_comedor,
                EstadoMatricula = estado_matricula,
            };

            estudiantes.Add(estudiante);

            GuardarDatos(estudiante);

            Console.WriteLine($"Resumen de datos de matricula: {nombre_y_apellidos_estudiante}, {numero_cedula_estudiante}, {nombre_y_apellidos_encargado_legal},{numero_cedula_encargado_legal}, {direccion_estudiante}, {numero_telefonico}, {datos_trabjo_encargado}, {grado_a_matricular}, {adjuntos}, {beca_de_comedor}");
            Console.WriteLine("Registro creado con exito");
            Console.ReadKey();
        }

        static void GuardarDatos(Estudiante estudiante)
        {
            using (StreamWriter sw = new StreamWriter("matriculas.txt", true))
            {
                sw.WriteLine($"Nombre del Estudiante: {estudiante.NombreEstudiante}");
                sw.WriteLine($"Cedula del Estudiante: {estudiante.CedulaEstudiante}");
                sw.WriteLine($"Fecha de nacimiento del estudiante: {estudiante.FechaNacimiento}");
                sw.WriteLine($"Nombre del Encargado: {estudiante.NombreEncargado}");
                sw.WriteLine($"Cedula del Encargado: {estudiante.CedulaEncargado}");
                sw.WriteLine($"Direccion: {estudiante.Direccion}");
                sw.WriteLine($"Telefono: {estudiante.Telefono}");
                sw.WriteLine($"Trabajo del Encargado: {estudiante.TrabajoEncargado}");
                sw.WriteLine($"Grado: {estudiante.Grado}");
                sw.WriteLine($"Notas Adjuntas: {estudiante.NotasAdjuntas}");
                sw.WriteLine($"Beca de Comedor: {estudiante.BecaComedor}");
                sw.WriteLine($"Estado de Matricula: {estudiante.EstadoMatricula}");
            }
        }

        static void Consultar()
        {
            Console.WriteLine("Consultar Matricula de Estudiante");
            Console.WriteLine("Digite el numero de cedula del estudiante para buscar su registro:");
            string cedulaEstudiante = Console.ReadLine();

            Estudiante estudiante = estudiantes.Find(e => e.CedulaEstudiante == cedulaEstudiante);

            if (estudiante != null)
            {
                Console.WriteLine($"Nombre del Estudiante: {estudiante.NombreEstudiante}");
                Console.WriteLine($"Cedula del Estudiante: {estudiante.CedulaEstudiante}");
                Console.WriteLine($"Fecha de nacimiento del Estudiante: {estudiante.FechaNacimiento}");
                Console.WriteLine($"Nombre del Encargado: {estudiante.NombreEncargado}");
                Console.WriteLine($"Cedula del Encargado: {estudiante.CedulaEncargado}");
                Console.WriteLine($"Direccion: {estudiante.Direccion}");
                Console.WriteLine($"Telefono: {estudiante.Telefono}");
                Console.WriteLine($"Trabajo del Encargado: {estudiante.TrabajoEncargado}");
                Console.WriteLine($"Grado: {estudiante.Grado}");
                Console.WriteLine($"Notas Adjuntas: {estudiante.NotasAdjuntas}");
                Console.WriteLine($"Beca de Comedor: {estudiante.BecaComedor}");
                Console.WriteLine($"Estado de Matricula: {estudiante.EstadoMatricula}");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }

            Console.ReadKey();
        }

        static void Modificar()
        {
            Console.WriteLine("Modificar datos de Matricula de Estudiante");
            Console.WriteLine("Digite el numero de cedula del estudiante para buscar su registro:");
            string cedulaEstudiante = Console.ReadLine();

            Estudiante estudiante = estudiantes.Find(e => e.CedulaEstudiante == cedulaEstudiante);

            if (estudiante != null)
            {
                Console.WriteLine("Digite el nuevo nombre y apellidos del estudiante (deje en blanco para no cambiar):");
                string nuevoNombre = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoNombre))
                {
                    estudiante.NombreEstudiante = nuevoNombre;
                }

                Console.WriteLine("Digite el nuevo numero de cedula del estudiante (deje en blanco para no cambiar):");
                string nuevaCedula = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevaCedula))
                {
                    estudiante.CedulaEstudiante = nuevaCedula;
                }

                Console.WriteLine("Digite la nueva fecha de nacimiento del estudiante (deje en blanco para no cambiar):");
                string nuevaFechaNacimiento = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevaFechaNacimiento))
                {
                    estudiante.FechaNacimiento = nuevaFechaNacimiento;
                }

                Console.WriteLine("Digite el nuevo nombre y apellidos del encargado legal (deje en blanco para no cambiar):");
                string nuevoEncargado = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoEncargado))
                {
                    estudiante.NombreEncargado = nuevoEncargado;
                }

                Console.WriteLine("Digite el nuevo numero de cedula del encargado legal (deje en blanco para no cambiar):");
                string nuevaCedulaEncargado = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevaCedulaEncargado))
                {
                    estudiante.CedulaEncargado = nuevaCedulaEncargado;
                }

                Console.WriteLine("Digite la nueva direccion de residencia (deje en blanco para no cambiar):");
                string nuevaDireccion = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevaDireccion))
                {
                    estudiante.Direccion = nuevaDireccion;
                }

                Console.WriteLine("Digite el nuevo numero de telefono (deje en blanco para no cambiar):");
                string nuevoTelefono = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoTelefono))
                {
                    estudiante.Telefono = nuevoTelefono;
                }

                Console.WriteLine("Digite los nuevos datos del lugar de trabajo del encargado legal (deje en blanco para no cambiar):");
                string nuevoTrabajo = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoTrabajo))
                {
                    estudiante.TrabajoEncargado = nuevoTrabajo;
                }

                Console.WriteLine("Digite el nuevo grado lectivo por matricular (numero del 7 al 11, deje en blanco para no cambiar):");
                string nuevoGradoInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoGradoInput))
                {
                    estudiante.Grado = Convert.ToInt32(nuevoGradoInput);
                }

                Console.WriteLine("¿Adjunta nuevo Documento: Notas o certificación de último curso lectivo aprobado? (S/N, deje en blanco para no cambiar):");
                string nuevoAdjuntosInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoAdjuntosInput))
                {
                    estudiante.NotasAdjuntas = nuevoAdjuntosInput.ToUpper() == "S";
                }

                Console.WriteLine("¿Solicita nueva beca de comedor? (S/N, deje en blanco para no cambiar):");
                string nuevaBecaComedorInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevaBecaComedorInput))
                {
                    estudiante.BecaComedor = nuevaBecaComedorInput.ToUpper() == "S";
                }

                Console.WriteLine("¿Desea modificar el estado de matricula del estudiante? (S/N, deje en blanco para no cambiar):");
                string nuevoEstadoMatriculaInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(nuevoEstadoMatriculaInput))
                {
                    estudiante.EstadoMatricula = nuevoEstadoMatriculaInput.ToUpper() == "S";
                }


                Console.WriteLine("Registro modificado con exito");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }

            Console.ReadKey();
        }

        class Estudiante
        {
            public string NombreEstudiante { get; set; }
            public string CedulaEstudiante { get; set; }
            public string FechaNacimiento { get; set; }
            public string NombreEncargado { get; set; }
            public string CedulaEncargado { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string TrabajoEncargado { get; set; }
            public int Grado { get; set; }
            public bool NotasAdjuntas { get; set; }
            public bool BecaComedor { get; set; }
            public bool EstadoMatricula { get; set; }
        }
    }
}
