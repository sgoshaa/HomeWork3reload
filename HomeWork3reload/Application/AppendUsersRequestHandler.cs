using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork3reload.Services;
using HomeWork3reload.Models;
using MassTransit;
using HomeWork3reload.Commands;

namespace HomeWork3reload.Application
{
    public class AppendUsersRequestHandler
    {
        //private readonly IUserInfoService _userInfoServive;
        private readonly IBus _bus;

        public AppendUsersRequestHandler(IBus bus)
        {
            _bus = bus;
        }

        public Task<User>Handle(User user)
        {
            Guid guid = Guid.NewGuid();
            user.Id = guid;

            _bus.Send(new AppendUserCommand()
            {
                User = user
            });

            return Task.FromResult<User>(user);
        }
    }
}
