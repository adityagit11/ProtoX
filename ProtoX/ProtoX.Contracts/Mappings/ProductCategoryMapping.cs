// <copyright file="ProductCategoryMapping.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Contracts.Mappings
{
    using ProtoX.Contracts.Categories;
    using ProtoX.Contracts.Products;

    /// <summary>
    /// Contract class for Product Category Mapping
    /// </summary>
    public class ProductCategoryMapping : DbContractBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
