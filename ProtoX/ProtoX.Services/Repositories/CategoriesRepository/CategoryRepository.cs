// <copyright file="CategoryRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.CategoriesRepository
{
    using ProtoX.Contracts.Categories;
    using ProtoX.DataAccess.Initializer;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Class for category repository.
    /// </summary>
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRepository"/> class.
        /// </summary>
        /// <param name="dataContext">ProtoX Data Context.</param>
        public CategoryRepository(PROTOXDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}
