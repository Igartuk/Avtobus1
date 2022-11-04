using Avtobus1BLL.Interfaces;
using Avtobus1BLL.Services;
using Avtobus1DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1BLL
{
    public static class BLLDIExtention
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.RegisterDalDependencies();
            services.AddScoped<IUrlService, UrlService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
