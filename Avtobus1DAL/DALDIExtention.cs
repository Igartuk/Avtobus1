using Avtobus1DAL.Interfaces;
using Avtobus1DAL.Models;
using Avtobus1DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtobus1DAL
{
    public static class DALDIExtention
    {
        public static void RegisterDalDependencies(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>();
            services.AddScoped<IUrlRepository,UrlRepository>();
        }
    }
}
