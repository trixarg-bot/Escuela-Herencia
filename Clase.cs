using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_herencia
{
    // Clase 'Clase' (grupo de estudiantes y profesores)
    public class Clase
    {
        public string IdClase { get; set; }
        public List<Profesor> Profesores { get; set; } = new List<Profesor>();
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        public Clase(string idClase)
        {
            IdClase = idClase;
        }

        public void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
        }

        public void RemoverProfesor(Profesor profesor)
        {
            Profesores.Remove(profesor);
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void RemoverEstudiante(Estudiante estudiante)
        {
            Estudiantes.Remove(estudiante);
        }
    }
}
