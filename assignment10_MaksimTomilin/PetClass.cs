using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment10_MaksimTomilin
{
    internal class PetClass
    {
        public PetClass(string name, string type, decimal age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Age { get; set; }


    }
}
