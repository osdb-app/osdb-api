using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace OsdbApi.Models
{
	/// <summary> Base class for all MongoDb collection entries. </summary>
	public abstract class CollectionEntry
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }
	}
}
