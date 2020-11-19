using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class FarmerData : IFarmerData
    {
        private readonly ISqlDataAccess _db;

        public FarmerData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<FarmerModel>> GetFarmers()
        {
            string sql = "select * from farmers";

            return _db.LoadData<FarmerModel, dynamic>(sql, new { });
        }

        public Task InsertFarmer(FarmerModel farmer)
        {
            string sql = @"insert into farmers (firstName, lastName, phoneNumber)
                        values (@firstName, @lastName, @phoneNumber);";

            return _db.SaveData(sql, farmer);
        }
    }
}
