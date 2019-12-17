using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace PawRadar.Models
{   

    [DataContract]
    public class Pet
    {

        public String Name { get; set; }
        
        public String Species { get; set; }

        public int Age { get; set; }

        public String Location { get; set; }

        public Pet(string name, string species, int age, string location)
        {
            Name = name;
            Species = species;
            Age = age;
            Location = location;
        }

    }
}