using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork3reload.Models;
using HomeWork3reload.Services;
using Npgsql;
using Dapper;

namespace HomeWork3reload.Infrastructure
{
    public class UserInfoService:IUserInfoService
    {
       
         private const string ConnectionString =
            "host=localhost;port=5432;database=homework3;username=postgres;password=1";

         public async Task<User> GetById(Guid id)
         {
             using (var connection = new NpgsqlConnection(ConnectionString))
             {
                 return await connection.QuerySingleAsync<User>(
                     "SELECT * FROM Users WHERE Id = @id", new { id });
             }
         }

    }
}
