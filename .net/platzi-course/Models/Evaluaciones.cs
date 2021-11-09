using System;

namespace platzi_course.Models
{
    public class Evaluaciones
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura  { get; set; }

        public float Nota { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}