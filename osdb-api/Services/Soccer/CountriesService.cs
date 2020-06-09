using MongoDB.Driver;
using OsdbApi.Models.DbSettings;
using OsdbApi.Models.Soccer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OsdbApi.Services.Soccer
{
	public class CountriesService : SoccerServiceBase<Country>
	{
		public CountriesService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Countries)
		{
		}
	}
}
