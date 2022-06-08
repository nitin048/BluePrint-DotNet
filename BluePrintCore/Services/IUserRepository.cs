
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluePrintDomain.Model;

namespace BluePrintCore.Services
{
	public interface IUserRepository : IDisposable
	{
		Task<User> GetUser(string uname, string pwd);
		void CreateUser(User user);
	}
}
