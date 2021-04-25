// // <copyright file="ControllerBase.cs" company="Order Dynamics www.orderdynamics.com">
// // Copyright (c) 2021 All Right Reserved
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WingtipToys.Web.Controllers {
    public abstract class ControllerBase : Controller {
        protected ControllerBase(ILogger<ControllerBase> logger, IConfiguration configuration) {
            Configuration = configuration;
            Logger = logger;

            // ToDo RequireHttps
            // ToDo Authorization
            // ToDo Exception Handling
        }

        protected ILogger<ControllerBase> Logger { get; }

        protected IConfiguration Configuration { get; }
    }
}