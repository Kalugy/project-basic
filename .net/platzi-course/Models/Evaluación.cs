using System;

namespace platzi_course.Models
{
    public class Evaluación:ObjectSchoolBase
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura  { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Name}, {Asignatura.Name}";
        }
    }
}