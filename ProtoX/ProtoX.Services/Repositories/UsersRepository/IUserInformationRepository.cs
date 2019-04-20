// <copyright file="IUserInformationRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.UsersRepository
{
    using ProtoX.Contracts.Users;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Interface for User Information Repository.
    /// </summary>
    public interface IUserInformationRepository : IRepository<UserInformation>
    {
    }
}
