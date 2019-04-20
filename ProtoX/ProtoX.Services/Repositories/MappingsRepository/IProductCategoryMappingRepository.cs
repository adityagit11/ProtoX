// <copyright file="IProductCategoryRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.MappingsRepository
{
    using ProtoX.Contracts.Mappings;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Interface Product Category Repository.
    /// </summary>
    public interface IProductCategoryMappingRepository : IRepository<ProductCategoryMapping>
    {
    }
}
