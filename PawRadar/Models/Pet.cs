using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace PawRadar.Models
{   
    /// <summary>
    /// The main Pet class
    /// Contains members of the attributes of a 'Pet'
    /// </summary>
    [DataContract]
    public class Pet
    {

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String Name { get; set; }

        /// <summary>
        /// Gets or sets the species.
        /// </summary>
        /// <value>
        /// The species.
        /// </value>
        public String Species { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public String Location { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pet"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="species">The species.</param>
        /// <param name="age">The age.</param>
        /// <param name="location">The location.</param>
        public Pet(string name, string species, int age, string location)
        {
            Name = name;
            Species = species;
            Age = age;
            Location = location;
        }

    }
}