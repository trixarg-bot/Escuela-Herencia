using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_herencia
{
    // Clase Profesor
    public class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; } = new List<Curso>();

        public Profesor(string nombre) : base(nombre) { }

        public void AgregarCurso(Curso curso)
        {
            Cursos.Add(curso);
        }

        public void QuitarCurso(Curso curso)
        {
            Cursos.Remove(curso);
        }
    }
}
