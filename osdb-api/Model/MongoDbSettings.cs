namespace OsdbApi.Models
{
	public class MongoDbSettings : IMongoDbSettings
	{
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
		public EnvironmentVariables EnvironmentVariables { get; set; }
		public OsdbCollections Collections { get; set; }
	}

	public class EnvironmentVariables : IEnvironmentVariables
	{
		public string MongoDbUser { get; set; }
		public string MongoDbPassword { get; set; }
	}

	public class OsdbCollections : IOsdbCollections
	{
		public string Sports { get; set; }
	}

	public interface IMongoDbSettings
	{
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
		EnvironmentVariables EnvironmentVariables { get; set; }
		OsdbCollections Collections { get; set; }
	}

	public interface IOsdbCollections
	{
		string Sports { get; set; }
	}

	public interface IEnvironmentVariables
	{
		string MongoDbUser { get; set; }
		string MongoDbPassword { get; set; }
	}
}