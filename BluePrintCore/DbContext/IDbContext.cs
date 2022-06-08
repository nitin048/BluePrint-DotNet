using System;
using MongoDB.Driver;
namespace BluePrintCore.DbContext
{
	public interface IDbContext<T>
	{
		IMongoCollection<T> Collection();
	}
}

