using Amazon.DynamoDBv2.DataModel;

namespace OsdbApi.Model
{
	[DynamoDBTable("osdb")]
	public class Sport
	{
		[DynamoDBHashKey]
		public int sportId { get; set; }
		public string name { get; set; }
		public string organizingBody { get; set; }
	}
}
