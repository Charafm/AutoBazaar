using AutoBazaar.Common.Application.Interfaces;
using AutoBazaar.Common.Domain.Config;
using AutoBazaar.Common.Domain.Constants;
using AutoBazaar.Common.Infrastructure.Context;
using AutoBazaar.Common.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBazaar.Common.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddContext<TContext, TIContext>(this IServiceCollection services, IConfiguration configuration)
            where TContext : DbContext, TIContext
            where TIContext : class
        {
            var connectionString = configuration.GetConnectionString(typeof(TContext).Name);
            services.AddDbContext<TContext>(options =>
                options.UseSqlServer(
                    connectionString,
                    b => b.MigrationsAssembly(typeof(TContext).Assembly.FullName)).AddInterceptors(new CommandInterceptor()), ServiceLifetime.Transient);

            services.AddScoped<TIContext>(provider => provider.GetService<TContext>()!);

            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<SecurityOptions>(configuration.GetSection(ConfigurationConstants.Sections.Security));
            //services.Configure<EmailOptions>(configuration.GetSection(ConfigurationConstants.Sections.Mail));
            //services.Configure<WebPortalsURLsOprions>(configuration.GetSection(ConfigurationConstants.Sections.WebPortalsURLs));
            //services.Configure<ErrorDetailsOptions>(configuration.GetSection(ConfigurationConstants.Sections.ErrorDetails));
            //services.AddTransient<IServiceHelper, ServiceHelper>();

            services.AddScoped<ITenantAccessor, TenantAccessor>();
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IStorage, LocalStorage>();
            services.AddTransient<ICacheService, CacheService>();
            //services.AddTransient<IMediaService, MediaService>();
            //services.AddScoped<ITemplateToStringRenderer, RazorViewToStringRenderer>();
            //services.AddTransient<ISecurityTokenGenerator, DefaultSecurityTokenGenerator>();
            //services.AddTransient<IPdfGenerationService, PdfGenerationService>();
            //services.AddTransient<IFileScanService, ClamAVService>();
            //services.AddTransient<IEmailSender, EmailSender>();

            return services;
        }

        public static IServiceCollection AddAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var securityOptions = configuration.GetSection(ConfigurationConstants.Sections.Security)
                    .Get<SecurityOptions>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                {
                    options.Authority = securityOptions?.AuthorityUrl;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = false
                    };
                });

            services.AddAuthorization();

            return services;
        }

        public static ILoggingBuilder AddDbLogger(this ILoggingBuilder builder, Action<DbLoggerOptions> configure)
        {
            builder.Services.AddSingleton<IDbLoggerProvider, DbLoggerProvider>();
            builder.Services.Configure(configure);
            return builder;
        }
    }
}
