using MongoDB.Driver;
using OsdbApi.Models;
using OsdbApi.Models.Soccer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OsdbApi.Services.Soccer
{
	public class CountriesService
	{
		private readonly IMongoCollection<Country> _countries;

		public CountriesService(Models.DbSettings.OsdbSoccerDbSettings settings)
		{
			var connectionStr = settings.ConnectionString.Replace("<" + settings.EnvironmentVariables.MongoDbUser + ">", Environment.GetEnvironmentVariable(settings.EnvironmentVariables.MongoDbUser));
			connectionStr = connectionStr.Replace("<" + settings.EnvironmentVariables.MongoDbPassword + ">", Environment.GetEnvironmentVariable(settings.EnvironmentVariables.MongoDbPassword));
			var client = new MongoClient(connectionStr);
			var database = client.GetDatabase(settings.DatabaseName);

			_countries = database.GetCollection<Country>(settings.Collections.Countries);
		}

		public List<Country> Get() =>
			_countries.Find(s => true).ToList();

		public Country Get(string id) =>
			_countries.Find(s => s.Id == id).FirstOrDefault();

		public Country Create(Country sport)
		{
			_countries.InsertOne(sport);
			return sport;
		}

		public void Update(string id, Country newSport) =>
			_countries.ReplaceOne(book => book.Id == id, newSport);

		public void Remove(Country sportToDelete) =>
			_countries.DeleteOne(book => book.Id == sportToDelete.Id);

		public void Remove(string id) =>
			_countries.DeleteOne(s => s.Id == id);

	}
}
