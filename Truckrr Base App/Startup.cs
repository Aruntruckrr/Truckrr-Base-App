using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace Truckrr_Base_App
{
    public class Startup : StartupBase
    {
        public Startup(IConfiguration configuration)
        {
            IConfiguration = configuration;
        }
        private readonly object env;
        private IConfiguration IConfiguration;

        

    }

    internal class PermissionPolicyProvider
    {
    }
}
