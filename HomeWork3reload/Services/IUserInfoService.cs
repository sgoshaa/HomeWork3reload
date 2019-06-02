using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork3reload.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork3reload.Services
{
    public interface IUserInfoService
    {
        Task<User> GetById(Guid id);
        Task<IActionResult> AppendUser(User user);
    }
}
