using System.Collections.Generic;

namespace OsdbApi.Models.Soccer
{
	public class Team : CollectionEntry
	{
		public string Name { get; set; }
		public List<string> Roster { get; set; }
	}
}
