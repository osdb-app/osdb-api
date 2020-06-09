using System.Collections.Generic;

namespace OsdbApi.Models.Soccer
{
	public class Country: CollectionEntry
	{
		public string Name { get; set; }
		public List<string> Leagues { get; set; }
	}
}
