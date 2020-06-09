using System.Collections.Generic;

namespace OsdbApi.Models.Soccer
{
	public class League: CollectionEntry
	{
		public string Name { get; set; }
		public List<string> Seasons { get; set; }
	}
}
