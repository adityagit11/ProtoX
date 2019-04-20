// <copyright file="Product.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Contracts.Products
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Contract class for Product.
    /// </summary>
    public class Product : DbContractBase
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime? BidStartTime { get; set; }
        public DateTime? BidEndTime { get; set; }
        public float InitialBidPrice { get; set; }
        public float CurrentBidPrice { get; set; }
        public float PreviousBidPrice { get; set; }
        [Required]
        public string Location { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
