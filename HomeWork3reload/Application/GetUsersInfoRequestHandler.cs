using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork3reload.Services;
using HomeWork3reload.Models;


namespace HomeWork3reload.Application
{
    public class GetUsersInfoRequestHandler
    {
        private readonly IUserInfoService _userInfoService;

        public GetUsersInfoRequestHandler(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public Task<User> Handle(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Некорректный идентификатор пользователя", nameof(id));
            }

            return _userInfoService.GetById(id);
        }

    }
}
