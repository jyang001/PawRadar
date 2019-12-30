using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using PawRadar.Models;
using PawRadar.Infrastructure;

namespace PawRadar.Controllers
{
    public class PetController : ApiController
    {

        private readonly IPet _ipet;

        public PetController(IPet ipet)
        {
            _ipet = ipet;
        }

        // GET: api/Pet
        public IEnumerable<Pet> Get()
        {
            var pets = _ipet.GetAll();
            return pets; 
        }

        // GET: api/Pet/5
        public Pet Get(int id)
        {

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
