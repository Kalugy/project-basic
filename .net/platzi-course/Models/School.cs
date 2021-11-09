using System;
using System.Collections.Generic;

namespace platzi_course.Models
{
    public class School:ObjectSchoolBase
    {
        public int CreationDate { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        public string Address { get; set; }

        public TiposEscuela SchoolType { get; set; }
        public List<Curso> Course { get; set; }

        public School(string name, int year) => (Name, CreationDate) = (Name, CreationDate);

        public School(string name, int year, 
                       TiposEscuela type, 
                       string country = "", string city = "") : base()
        {
            (Name, CreationDate) = (name, year);
            Country = country;
            City = city;
        }

        public School() 
        {
           
        }


        public override string ToString()
        {
            return $"Name: \"{Name}\", Tipo: {SchoolType} {System.Environment.NewLine} Pais: {City}, Ciudad:{Country}";
        }

    }
}
