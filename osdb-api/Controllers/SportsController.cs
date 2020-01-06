using System;
using Microsoft.AspNetCore.Mvc;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Runtime;

namespace OsdbApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class SportsController : ControllerBase
	{
		private const string TABLE_NAME = "osdb";
		// GET api/sports/getById/1
		[HttpGet("{id}")]
		public ActionResult<Model.Sport> GetById(int id)
		{
			try
			{
				using var client = new AmazonDynamoDBClient(new EnvironmentVariablesAWSCredentials(), Amazon.RegionEndpoint.USEast1);
				var tables = client.ListTablesAsync().Result;
				if (!tables.TableNames.Contains(TABLE_NAME))
				{
					throw new AmazonDynamoDBException("No suitable table found");
				}
				using var dynamoDb = new DynamoDBContext(client);
				return dynamoDb.LoadAsync<Model.Sport>(1).Result;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
