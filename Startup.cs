using Chorch.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Chorch
{
	public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

			//var connString = Configuration["App::ConnectionString:ChorchConnection"];
			var connString = Configuration.GetConnectionString("ChorchConnection");
			//services.AddDbContext<ChorchDbContext>(options =>
													//options.UseMySql(connectionString: connstring, mySqlOptionsAction: b => b.MigrationsAssembly("Chorch")));
			services.AddDbContext<ChorchDbContext>(options =>
			                                       options.UseMySql(connString, b => b.MigrationsAssembly("Chorch")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
