// <copyright file="IProductUserMappingRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.MappingsRepository
{
    using ProtoX.Contracts.Mappings;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Interface for IProductUserMapping Repository.
    /// </summary>
    public interface IProductUserMappingRepository : IRepository<ProductUserMapping>
    {
    }
}
