// <copyright file="UserInformationRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.UsersRepository
{
    using ProtoX.Contracts.Users;
    using ProtoX.DataAccess.Initializer;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Class for User Information Repository.
    /// </summary>
    public class UserInformationRepository : Repository<UserInformation>, IUserInformationRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInformationRepository"/> class.
        /// </summary>
        /// <param name="dataContext">Data Context Injected Object.</param>
        public UserInformationRepository(PROTOXDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}
