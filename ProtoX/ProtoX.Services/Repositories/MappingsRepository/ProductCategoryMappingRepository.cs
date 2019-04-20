// <copyright file="ProductCategoryRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.MappingsRepository
{
    using ProtoX.Contracts.Mappings;
    using ProtoX.DataAccess.Initializer;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Class Product Category Repository Class.
    /// </summary>
    public class ProductCategoryMappingRepository : Repository<ProductCategoryMapping>, IProductCategoryMappingRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryMappingRepository"/> class.
        /// </summary>
        /// <param name="dataContext">Data Context.</param>
        public ProductCategoryMappingRepository(PROTOXDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}
