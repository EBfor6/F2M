using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IFarmerData
    {
        Task<List<FarmerModel>> GetFarmers();
        Task InsertFarmer(FarmerModel farmer);
    }
}