// <copyright file="PROTOXDataContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.DataAccess.Initializer
{
    using Microsoft.EntityFrameworkCore;
    using ProtoX.Contracts.Categories;
    using ProtoX.Contracts.Mappings;
    using ProtoX.Contracts.Products;
    using ProtoX.Contracts.Users;

    /// <summary>
    /// Data Context class.
    /// </summary>
    public class PROTOXDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }
        public DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public DbSet<ProductUserMapping> ProductUserMappings { get; set; }

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connection string
            var connectionString = "Server=tcp:adisingtools.database.windows.net,1433;Initial Catalog=protoxpreprod;Persist Security Info=False;User ID=adisingtools;Password=@dm1ntools;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ProtoX");
        }
    }
}
