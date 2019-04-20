// <copyright file="IProductRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.ProductsRepository
{
    using ProtoX.Contracts.Products;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Interface class for product repository.
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
    }
}
