using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork3reload.Models;
using HomeWork3reload.Services;
namespace HomeWork3reload.Infrastructure
{
    public class UserInfoService:IUserInfoService
    {
        public async Task<User> GetById(Guid id)
        {
            User user = new User
            {
                Email = "test@test.ru",
                Id = id,
                Nickname = "test",
                Phone = "+7 987 654 32 10"
            };

            return await Task.FromResult<User>(user);
        }
        /* private const string ConnectionString =
            "host=localhost;port=5432;database=postgres;username=postgres;password=1";

         public async Task<User> GetById(Guid id)
         {
             using (var connection = new NpgsqlConnection(ConnectionString))
             {
                 return await connection.QuerySingleAsync<User>(
                     "SELECT * FROM Users WHERE Id = @id", new { id });
             }
         }*/

    }
}
