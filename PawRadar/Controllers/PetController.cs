using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using PawRadar.Models;


namespace PawRadar.Controllers
{
    public class PetController : ApiController
    {
        private static IDbConnection db;

        public PetController()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

        // GET: api/Pet
        public IEnumerable<Pet> Get()
        {
            string query = "select * from PetsDB.dbo.Pets";
            List<Pet> pets = new List<Pet>();

            using (db)
            {
                pets = db.Query<Pet>(query).ToList();
            }
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
