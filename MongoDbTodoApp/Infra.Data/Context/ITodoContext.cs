using MongoDB.Driver;
using MongoDbTodoApp.Domain.Entities;

namespace MongoDbTodoApp.Infra.Data.Context
{
    public interface ITodoContext
    {
        IMongoCollection<Todo> Todos { get; }
    }
}
