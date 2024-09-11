using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_herencia
{
    // Clase Curso
    public class Curso
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
        {
            Nombre = nombre;
            RecuentoClases = recuentoClases;
            RecuentoEjercicios = recuentoEjercicios;
        }

        public string ObtenerDetalles()
        {
            return $"Curso: {Nombre}, Clases: {RecuentoClases}, Ejercicios: {RecuentoEjercicios}";
        }
    }
}
