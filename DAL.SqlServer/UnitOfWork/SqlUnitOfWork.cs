﻿using DAL.SqlServer.Context;
using DAL.SqlServer.Infrastructure;
using Repository.Common;
using Repository.Repositories;

namespace DAL.SqlServer.UnitOfWork;

public class SqlUnitOfWork(string connectionString, AppDbContext context) : IUnitOfWork
{
    private readonly string _connectionString = connectionString;
    private readonly AppDbContext _context = context;

    public SqlBookRepository _bookRepository;
    public SqlUserRepository _userRepository;

    public IBookRepository CategoryRepository => _=_bookRepository ?? new SqlBookRepository(_context);

    public IUserRepository UserRepository => _userRepository ?? new SqlUserRepository(_connectionString, _context);
}