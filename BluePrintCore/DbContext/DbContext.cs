using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
namespace BluePrintCore.DbContext
{


	public class DbContext<T> : IDbContext<T>
	{

		private readonly IMongoCollection<T> _users;

		public DbContext(IMongoClient client)
		{
			var database = client.GetDatabase("BluePrint");
			var collection = database.GetCollection<T>(nameof(T));

			_users = collection;
		}

        public IMongoCollection<T> Collection()
        {
			return _users;
        }
    }
}

