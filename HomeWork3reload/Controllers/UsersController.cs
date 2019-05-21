using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HomeWork3reload.Models;
using HomeWork3reload.Application;

namespace HomeWork3reload.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly GetUsersInfoRequestHandler _getUsersInfoRequestHandler;

        public UsersController(GetUsersInfoRequestHandler getUsersInfoRequestHandler)
        {
            _getUsersInfoRequestHandler = getUsersInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<User> GetUserInfo(Guid id)
        {
            return _getUsersInfoRequestHandler.Handle(id);
        }
    }

}