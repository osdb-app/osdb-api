using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OsdbApi.Models.DbSettings;
using OsdbApi.Services;

using Soccer = OsdbApi.Services.Soccer;

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
			services.Configure<OsdbDbSettings>(Configuration.GetSection(nameof(OsdbDbSettings)));
			services.AddSingleton(sp => sp.GetRequiredService<IOptions<OsdbDbSettings>>().Value);

			services.Configure<OsdbSoccerDbSettings>(Configuration.GetSection(nameof(OsdbSoccerDbSettings)));
			services.AddSingleton(sp => sp.GetRequiredService<IOptions<OsdbSoccerDbSettings>>().Value);

			// https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-3.1&tabs=visual-studio
			// The SportsService class is registered with DI to support constructor injection in consuming classes.
			// The singleton service lifetime is most appropriate because SportsService takes a direct dependency on MongoClient.
			// Per the official Mongo Client reuse guidelines, MongoClient should be registered in DI with a singleton service lifetime.
			services.AddSingleton<SportsService>();
			services.AddSingleton<Soccer.CoachesService>();
			services.AddSingleton<Soccer.CountriesService>();
			services.AddSingleton<Soccer.FormationsService>();
			services.AddSingleton<Soccer.LeaguesService>();
			services.AddSingleton<Soccer.PeopleService>();

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

			app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
		}
	}
}
