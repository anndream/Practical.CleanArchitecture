﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassifiedAds.Infrastructure.IdentityProviders;

public interface IUserManager
{
    Task<IList<IUser>> GetUsersAsync();

    Task<IUser> GetUserById(string userId);

    Task<IUser> GetUserByUsernameAsync(string username);

    Task CreateUserAsync(IUser user);

    Task UpdateUserAsync(string userId, IUser user);

    Task DeleteUserAsync(string userId);
}
