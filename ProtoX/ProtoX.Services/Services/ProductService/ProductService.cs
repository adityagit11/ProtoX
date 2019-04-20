// <copyright file="ProductService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Services.ProductService
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ProtoX.Services.Repositories.MappingsRepository;
    using ProtoX.Services.Repositories.ProductsRepository;

    /// <summary>
    /// Class for Product Service
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IProductCategoryMappingRepository productCategoryMappingRepository;
        private readonly IProductUserMappingRepository productUserMappingRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductService"/> class.
        /// </summary>
        /// <param name="productRepository">Product Repository Injected Object.</param>
        /// <param name="productCategoryMappingRepository">Product Category Mapping Repository Injected Object.</param>
        /// <param name="productUserMappingRepository">Product User Mapping Repository Injected Object.</param>
        public ProductService(
            IProductRepository productRepository,
            IProductCategoryMappingRepository productCategoryMappingRepository,
            IProductUserMappingRepository productUserMappingRepository)
        {
            this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            this.productCategoryMappingRepository = productCategoryMappingRepository ?? throw new ArgumentNullException(nameof(productCategoryMappingRepository));
            this.productUserMappingRepository = productUserMappingRepository ?? throw new ArgumentNullException(nameof(productUserMappingRepository));
        }
    }
}
