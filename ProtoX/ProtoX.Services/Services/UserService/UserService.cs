// <copyright file="UserService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Services.UserService
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProtoX.Services.Repositories.UsersRepository;

    /// <summary>
    /// Class for User Service.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserInformationRepository userInformationRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        /// <param name="userInformationRepository">User Information Repository Injected Object.</param>
        public UserService(IUserInformationRepository userInformationRepository)
        {
            this.userInformationRepository = userInformationRepository ?? throw new ArgumentNullException(nameof(userInformationRepository));
        }
    }
}
