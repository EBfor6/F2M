﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CrateData : ICrateData
    {
        private readonly ISqlDataAccess _db;

        public CrateData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CrateModel>> GetCrates()
        {
            string sql = "select * from crates";

            return _db.LoadData<CrateModel, dynamic>(sql, new { });
        }


        public Task InsertCrates(CrateModel crate)
        {
            string sql = @"insert into crates (idFarmer, produce, weight, grade )
                        values (@idFarmer, @produce, @weight, @grade);";

            return _db.SaveData(sql, crate);
        }
    }
}
