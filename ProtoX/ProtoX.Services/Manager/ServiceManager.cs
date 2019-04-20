// <copyright file="ServiceManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Services.Manager
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using ProtoX.DataAccess.Initializer;
    using ProtoX.Services.Repositories.CategoriesRepository;
    using ProtoX.Services.Repositories.MappingsRepository;
    using ProtoX.Services.Repositories.ProductsRepository;
    using ProtoX.Services.Repositories.UsersRepository;
    using ProtoX.Services.Services.CategoryService;
    using ProtoX.Services.Services.ProductService;
    using ProtoX.Services.Services.UserService;
    using ProtoX.Services.UnitOfWork;

    /// <summary>
    /// Class for the Service Manager.
    /// </summary>
    public class ServiceManager
    {
        /// <summary>
        /// Register Services for the service manager.
        /// </summary>
        /// <param name="services">IServiceCollection Injected object.</param>
        /// <param name="configuration">IConfiguration Injected object.</param>
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            // Helps in providing the Prototype Data Context to whole application as a single object
            services.AddDbContext<PROTOXDataContext>(ServiceLifetime.Transient);

            // Initialize the repository objects
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductCategoryMappingRepository, ProductCategoryMappingRepository>();
            services.AddScoped<IProductUserMappingRepository, ProductUserMappingRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserInformationRepository, UserInformationRepository>();

            // Initialize the service objects
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
