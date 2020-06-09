using OsdbApi.Models.DbSettings;

namespace OsdbApi.Services.Soccer
{
	public class FormationsService : SoccerServiceBase<Models.Soccer.Formation>
	{
		public FormationsService(OsdbSoccerDbSettings settings) : base(settings, settings.Collections.Formations)
		{
		}
	}
}
