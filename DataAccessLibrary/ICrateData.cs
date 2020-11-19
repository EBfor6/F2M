using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ICrateData
    {
        Task<List<CrateModel>> GetCrates();
        Task InsertCrates(CrateModel crate);
    }
}