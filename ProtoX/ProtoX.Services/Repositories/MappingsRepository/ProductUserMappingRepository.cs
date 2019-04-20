// <copyright file="ProductUserMappingRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.MappingsRepository
{
    using ProtoX.Contracts.Mappings;
    using ProtoX.DataAccess.Initializer;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Class for Product User Mapping Repository.
    /// </summary>
    public class ProductUserMappingRepository : Repository<ProductUserMapping>, IProductUserMappingRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUserMappingRepository"/> class.
        /// </summary>
        /// <param name="dataContext">Data context injected object.</param>
        public ProductUserMappingRepository(PROTOXDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}
