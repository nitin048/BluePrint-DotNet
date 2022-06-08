using BluePrintCore.Services;
using MongoDB.Driver;
using BluePrintCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluePrintCore.DbContext;
using BluePrintDomain.Model;

namespace BluePrintBL.Services
{

	public class UserRepository : IUserRepository
	{
		private readonly IDbContext<User> _users;
		public UserRepository(IDbContext<User> dbContext)
		{


			_users = dbContext;

		}

		public void Dispose()
		{
		
		}

		public async Task<User> GetUser(string uname, string pwd)
		{
			return await _users.Collection().Find(_ => _.Email == uname && _.Password == pwd).FirstOrDefaultAsync();
			
		}

		
		public void CreateUser(User user)
        {
            try
            {
				_users.create(user);
			}
            catch (Exception ex)
            {

            }
			//_users.Collection().InsertOne(user);
			
        }
	}
}	
