using System;
using System.Collections.Generic;

namespace platzi_course.Models
{
    public class Alumno: ObjectSchoolBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}