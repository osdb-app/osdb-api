using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsdbApi.Models.DbSettings
{
	public class OsdbSoccerDbSettings : IDbSettings<OsdbSoccerCollections>
	{
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
		public EnvironmentVariables EnvironmentVariables { get; set; }
		public OsdbSoccerCollections Collections { get; set; }
	}

	public class OsdbSoccerCollections
	{
		public string Coaches { get; set; }
		public string Countries { get; set; }
		public string Formations { get; set; }
		public string Leagues { get; set; }
		public string People { get; set; }
		public string Players { get; set; }
		public string Positions { get; set; }
		public string Roles { get; set; }
		public string Rosters { get; set; }
		public string Seasons { get; set; }
		public string Teams { get; set; }
	}
}
