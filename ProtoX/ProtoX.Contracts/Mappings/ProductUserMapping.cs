// <copyright file="ProductUserMapping.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Contracts.Mappings
{
    using ProtoX.Contracts.Products;
    using ProtoX.Contracts.Users;

    /// <summary>
    /// Contract class for Product User Mapping
    /// </summary>
    public class ProductUserMapping : DbContractBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public UserInformation UserInformation { get; set; }
    }
}
