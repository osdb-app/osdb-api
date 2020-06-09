using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsdbApi.Models.DbSettings
{
	public interface IDbSettings<CollectionsClass>
	{
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
		EnvironmentVariables EnvironmentVariables { get; set; }
		CollectionsClass Collections { get; set; }
	}

	public class EnvironmentVariables : IEnvironmentVariables
	{
		public string MongoDbUser { get; set; }
		public string MongoDbPassword { get; set; }
	}

	public interface IEnvironmentVariables
	{
		string MongoDbUser { get; set; }
		string MongoDbPassword { get; set; }
	}

}
