using System.Collections.Generic;

namespace OsdbApi.Models.Soccer
{
	public class Formation : CollectionEntry
	{
		public string Name { get; set; }
		public List<string> Positions { get; set; }
	}
}
