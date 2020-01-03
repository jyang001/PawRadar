using PawRadar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PawRadar.Infrastructure
{
    public interface IPetRepo
    {
        List<Pet> GetAll();
        Pet GetById(int id);
        void insert(Pet pet);
        void Update(Pet pet);
        void Delete(Pet pet);
        void Save();
     }
}
