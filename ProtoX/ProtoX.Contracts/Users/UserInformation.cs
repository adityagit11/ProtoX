// <copyright file="UserInformation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Contracts.Users
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Contract class for User Information
    /// </summary>
    public class UserInformation : DbContractBase
    {
        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [MaxLength(200)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [MaxLength(200)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [Required]
        [MaxLength(254)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [MaxLength(189)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [MaxLength(90)]
        public string Country { get; set; }
    }
}
