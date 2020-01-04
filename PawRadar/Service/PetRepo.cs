using Dapper;
using Microsoft.Data.SqlClient;
using PawRadar.Infrastructure;
using PawRadar.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace PawRadar.Service
{
    public class PetRepo : IPetRepo
    {
        private static IDbConnection db;

        public PetRepo()
        {
            db = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

        public void Delete(Pet pet)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetAll()
        {
            string query = "select * from PetsDB.dbo.Pets";
            List<Pet> pets = new List<Pet>();

            using (db)
            {
                pets = db.Query<Pet>(query).ToList();
            }
            return pets;
        }

        public Pet GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void insert(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}