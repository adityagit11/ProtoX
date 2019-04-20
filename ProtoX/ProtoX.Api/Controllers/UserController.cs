// <copyright file="UserController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProtoX.Api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using ProtoX.Services.Services.UserService;

    /// <summary>
    /// User Controller for CRUD Operations.
    /// </summary>
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="userService">User Service</param>
        public UserController(IUserService userService)
        {
            this.userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }
    }
}