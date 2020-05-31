using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OsdbApi.Models;
using OsdbApi.Services;

namespace OsdbApi
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
			// requires using Microsoft.Extensions.Options
			services.Configure<MongoDbSettings>(
				Configuration.GetSection(nameof(MongoDbSettings)));

			services.AddSingleton<IMongoDbSettings>(sp =>
				sp.GetRequiredService<IOptions<MongoDbSettings>>().Value);

			// The SportsService class is registered with DI to support constructor injection in consuming classes.
			// The singleton service lifetime is most appropriate because SportsService takes a direct dependency on MongoClient.
			// Per the official Mongo Client reuse guidelines, MongoClient should be registered in DI with a singleton service lifetime.
		   services.AddSingleton<SportsService>();

			services.AddControllers();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseDeveloperExceptionPage();
			//if (env.IsDevelopment())
			//{
			//	app.UseDeveloperExceptionPage();
			//}

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
