using BluePrintDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluePrintCore.Services
{
	public interface IUserRepository : IDisposable
	{
		Task<UserModel> GetUser(string uname, string pwd);
	}
}
