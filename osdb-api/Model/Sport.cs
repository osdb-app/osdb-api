using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OsdbApi.Models
{
	public class Sport
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
		public string Name { get; set; }
		public string OrganizingBody { get; set; }
	}
}
