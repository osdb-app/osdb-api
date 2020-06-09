using System.Collections.Generic;

namespace OsdbApi.Models.Soccer
{
	public class Roster : CollectionEntry
	{
		public string Name { get; set; }
		public List<string> Players { get; set; }
		public List<string> Positions { get; set; }
		public string Formation { get; set; }
	}
}
