namespace OsdbApi.Models.DbSettings
{
	public class OsdbDbSettings : IDbSettings<OsdbCollections>
	{
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
		public EnvironmentVariables EnvironmentVariables { get; set; }
		public OsdbCollections Collections { get; set; }
	}

	public class OsdbCollections
	{
		public string Sports { get; set; }
	}
}