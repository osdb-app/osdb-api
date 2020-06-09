using System.Collections.Generic;

namespace OsdbApi.Models.Soccer
{
	public class Role : CollectionEntry
	{
		public string Name { get; set; }
		public List<string> Leagues { get; set; }
		public string Stats { get; set; }
	}
}
