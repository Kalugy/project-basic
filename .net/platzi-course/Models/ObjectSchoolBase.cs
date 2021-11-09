using System;

namespace platzi_course.Models
{
    public abstract class ObjectSchoolBase
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }

        public ObjectSchoolBase()
        {
           
        }

        public override string ToString()
        {
            return $"{Name},{UniqueId}";
        }
    }
}