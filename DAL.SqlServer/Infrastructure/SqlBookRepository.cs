using DAL.SqlServer.Context;
using Dapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories;

namespace DAL.SqlServer.Infrastructure;

public class SqlBookRepository(AppDbContext context) : IBookRepository
{
    private readonly AppDbContext _context = context;

    public async Task AddAsync(Book book)
    {
         await _context.Books.AddAsync(book);
        await _context.SaveChangesAsync();
    }

    public bool Delete(int id, int deletedBy)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == id);
        return book != null;
    }

    public IQueryable<Book> GetAll()
    {
        return _context.Books;
    }

    public async Task<Book> GetByIdAsync(int id)
    {
        return (await _context.Books.FirstOrDefaultAsync(x => x.Id == id)!);

    }

    public void Update(Book book)
    {
        book.UpdatedDate = DateTime.Now;
        _context.Update(book);
    }
}
