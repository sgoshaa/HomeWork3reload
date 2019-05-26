using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork3reload.Services;
using HomeWork3reload.Models;

namespace HomeWork3reload.Application
{
    public class AppendUsersRequestHandler
    {
        private readonly IUserInfoService _userInfoServive;

        public AppendUsersRequestHandler(IUserInfoService userInfoServive)
        {
            _userInfoServive = userInfoServive;
        }

        public void Handle(User user)
        {
            _userInfoServive.AppendUser(user);
        }
    }
}
