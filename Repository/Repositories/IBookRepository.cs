using Domain.Entities;

namespace Repository.Repositories;

public interface IBookRepository
{
    Task AddAsync(Book book);
    void Update(Book book);
    bool Delete(int id , int deletedBy);
    IQueryable<Book> GetAll();
    Task<Book> GetByIdAsync(int id);
}