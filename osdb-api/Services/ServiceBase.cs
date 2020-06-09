using MongoDB.Driver;
using OsdbApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OsdbApi.Services
{
	public abstract class ServiceBase<DbSettingsType, CollectionsClass, Model> where DbSettingsType: Models.DbSettings.IDbSettings<CollectionsClass> where Model : CollectionEntry
	{
		private readonly IMongoCollection<Model> _collection;

		public ServiceBase(DbSettingsType settings, string collectionName)
		{
			var connectionStr = settings.ConnectionString.Replace("<" + settings.EnvironmentVariables.MongoDbUser + ">", Environment.GetEnvironmentVariable(settings.EnvironmentVariables.MongoDbUser));
			connectionStr = connectionStr.Replace("<" + settings.EnvironmentVariables.MongoDbPassword + ">", Environment.GetEnvironmentVariable(settings.EnvironmentVariables.MongoDbPassword));
			var client = new MongoClient(connectionStr);
			var database = client.GetDatabase(settings.DatabaseName);

			_collection = database.GetCollection<Model>(collectionName);
		}

		public List<Model> Get() =>
			_collection.Find(s => true).ToList();

		public Model Get(string id) =>
			_collection.Find(s => s.Id == id).FirstOrDefault();

		public Model Create(Model sport)
		{
			_collection.InsertOne(sport);
			return sport;
		}

		public void Update(string id, Model newSport) =>
			_collection.ReplaceOne(book => book.Id == id, newSport);

		public void Remove(Model sportToDelete) =>
			_collection.DeleteOne(book => book.Id == sportToDelete.Id);

		public void Remove(string id) =>
			_collection.DeleteOne(s => s.Id == id);
	}
}
