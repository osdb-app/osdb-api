using OsdbApi.Models;
using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services
{
	public abstract class SoccerServiceBase<Model> : ServiceBase<OsdbSoccerDbSettings, OsdbSoccerCollections, Model> where Model : CollectionEntry
	{
		public SoccerServiceBase(OsdbSoccerDbSettings settings, string collectionName) : base(settings, collectionName)
		{
		}
	}
}
