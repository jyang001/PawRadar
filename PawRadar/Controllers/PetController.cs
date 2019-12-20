using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PawRadar.Models;

namespace PawRadar.Controllers
{
    public class PetController : ApiController
    {
        public static List<Pet> pets = new List<Pet>();
        
        PetController()
        {
            pets.Add(new Pet(1, "Globber", "Maltese", 10, "Upper West Side"));
            pets.Add(new Pet(2, "Nana", "Poodle", 9, "Upper West Side"));
        }

        // GET: api/Pet
        public IEnumerable<Pet> Get()
        {
            return pets;
        }

        // GET: api/Pet/5
        public Pet Get(int id)
        {
            foreach(Pet pet in pets) {
                if (pet.Id == id)
                {
                    return pet;
                }
            }
            return null;
        }

        // POST: api/Pet
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pet/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pet/5
        public void Delete(int id)
        {
        }
    }
}
