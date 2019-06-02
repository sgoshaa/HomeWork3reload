using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWork3reload.Commands;
using HomeWork3reload.Services;
using MassTransit;

namespace HomeWork3reload.Consumers
{
    public class AppendUserConsumer : IConsumer<AppendUserCommand>
    {
        private readonly IUserInfoService _userInfoService;

        public AppendUserConsumer(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public async Task Consume(ConsumeContext<AppendUserCommand> context)
        {
           await _userInfoService.AppendUser(context.Message.User);
        }
    }
}
