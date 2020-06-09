using System.Collections.Generic;

namespace OsdbApi.Models.Soccer
{
	public class Season : CollectionEntry
	{
		public string Name { get; set; }
		public List<string> Teams { get; set; }
	}
}
