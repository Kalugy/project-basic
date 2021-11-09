using System;
using System.Collections.Generic;

namespace platzi_course.Models
{
    public class Curso:ObjectSchoolBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        public string Dirección { get; set; }

    }
}