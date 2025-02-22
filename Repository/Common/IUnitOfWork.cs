using Repository.Repositories;

namespace Repository.Common;

public interface IUnitOfWork
{
    public IBookRepository BookRepository { get; }
    public IUserRepository UserRepository { get; }
}