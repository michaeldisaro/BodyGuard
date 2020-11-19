﻿using System.Threading.Tasks;
using Michaelsoft.BodyGuard.Client.Models;
using Michaelsoft.BodyGuard.Client.Models.Lists;
using Michaelsoft.BodyGuard.Common.HttpModels.Authentication;
using Michaelsoft.BodyGuard.Common.Interfaces;
using Michaelsoft.BodyGuard.Common.Models;

namespace Michaelsoft.BodyGuard.Client.Interfaces
{
    public interface IBodyGuardUserApiService
    {

        public Task<UserList> GetUsers();

        public Task<User> GetUser(string id);

        public Task<UserUpdateResponse> UpdateUser(IUser user);

        public Task<UserDeleteResponse> DeleteUser(string id);

    }
}