// <copyright file="CategoryService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Services.CategoryService
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProtoX.Services.Repositories.CategoriesRepository;

    /// <summary>
    /// Class for Category Service.
    /// </summary>
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryService"/> class.
        /// </summary>
        /// <param name="categoryRepository">Category Repository Injected Object</param>
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }
    }
}
