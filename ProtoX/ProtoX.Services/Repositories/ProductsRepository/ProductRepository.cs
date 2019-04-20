// <copyright file="ProductRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Repositories.ProductsRepository
{
    using ProtoX.Contracts.Products;
    using ProtoX.DataAccess.Initializer;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Class for Product Repository.
    /// </summary>
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="dataContext">Data context injected object.</param>
        public ProductRepository(PROTOXDataContext dataContext)
            : base(dataContext)
        {
        }
    }
}