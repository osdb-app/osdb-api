using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class PeopleService : SoccerServiceBase<Models.Soccer.Person>
	{
		public PeopleService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.People)
		{
		}
	}
}
