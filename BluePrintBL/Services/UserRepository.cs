using BluePrintCore.Services;
using BluePrintDAL.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrintBL.Services
{

	public class UserRepository : IUserRepository
	{
		private readonly IMongoCollection<UserModel> _users;
		public UserRepository(IMongoClient client)
		{
			var database = client.GetDatabase("BluePrint");
			var collection = database.GetCollection<UserModel>(nameof(UserModel));

			_users = collection;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public async Task<UserModel> GetUser(string uname, string pwd)
		{
			return await _users.Find(_ => _.Email == uname && _.Password == pwd).FirstOrDefaultAsync();
			
		}
	}
}	
