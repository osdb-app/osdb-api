using MongoDB.Driver;
using OsdbApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OsdbApi.Services
{
	public class SoccerService
	{
		private readonly IMongoCollection<Sport> _sports;

		public SoccerService(Models.DbSettings.OsdbSoccerDbSettings settings)
		{
			var connectionStr = settings.ConnectionString.Replace("<" + settings.EnvironmentVariables.MongoDbUser + ">", Environment.GetEnvironmentVariable(settings.EnvironmentVariables.MongoDbUser));
			connectionStr = connectionStr.Replace("<" + settings.EnvironmentVariables.MongoDbPassword + ">", Environment.GetEnvironmentVariable(settings.EnvironmentVariables.MongoDbPassword));
			var client = new MongoClient(connectionStr);
			var database = client.GetDatabase(settings.DatabaseName);

			//_sports = database.GetCollection<Sport>(settings.Collections.Sports);
		}

		public List<Sport> Get() =>
			_sports.Find(s => true).ToList();

		public Sport Get(string id) =>
			_sports.Find(s => s.Id == id).FirstOrDefault();

		public Sport Create(Sport sport)
		{
			_sports.InsertOne(sport);
			return sport;
		}

		public void Update(string id, Sport newSport) =>
			_sports.ReplaceOne(book => book.Id == id, newSport);

		public void Remove(Sport sportToDelete) =>
			_sports.DeleteOne(book => book.Id == sportToDelete.Id);

		public void Remove(string id) =>
			_sports.DeleteOne(s => s.Id == id);

	}
}
