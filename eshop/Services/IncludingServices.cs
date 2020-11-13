using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshop.Services.Account;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace eshop.Services
{
    public static class IncludingServices
    {
        public static void AddEmailService(this IServiceCollection services)
        {
            services.AddTransient<IEmailSender, EmailSender>();
        }
    }
}
