using Core.Interfaces.Repositories;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace CreditCardTransactions.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICardAccountRepository, CardAccountRepository>();
            services.AddScoped<ICardAccountStatusTypeRepository, CardAccountStatusTypeRepository>();
            services.AddScoped<ICardAccountTransactionRepository, CardAccountTransactionRepository>();
            services.AddScoped<ICardAccountTransactionTypeRepository, CardAccountTransactionTypeRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientStatusTypeRepository, ClientStatusTypeRepository>();

            services.AddDbContext<CardTransactionDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CreditCardTransactions", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CreditCardTransactions v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
