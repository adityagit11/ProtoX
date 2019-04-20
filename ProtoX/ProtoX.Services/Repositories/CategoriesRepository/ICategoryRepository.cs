// <copyright file="ICategoryRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.CategoriesRepository
{
    using ProtoX.Contracts.Categories;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Interface for Category Repository.
    /// </summary>
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
