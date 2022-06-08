using BluePrintApi.Model;
using MongoDB.Driver;

namespace BluePrintApi.Repository
{
    //public class UserRepository : IUserRepository
    //{
    //    private readonly IMongoCollection<User> _users;

    //    public UserRepository(IMongoClient client)
    //    {
    //        var database = client.GetDatabase("BluePrint");
    //        var collection = database.GetCollection<User>(nameof(User));

    //        _users = collection;
    //    }
    //    public async Task<User> GetUser(string uname, string pwd)
    //    {
    //        return  _users.Find(_ => _.Email == uname && _.Password == pwd).FirstOrDefault();
    //    }
    //}
}
