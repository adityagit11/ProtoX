// <copyright file="DbContractBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Contracts
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Contract class for Db.
    /// </summary>
    public class DbContractBase
    {
        /// <summary>
        /// Gets or sets CreatedOn.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? CreatedOn { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets UpdatedOn.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedOn { get; set; }
    }
}
