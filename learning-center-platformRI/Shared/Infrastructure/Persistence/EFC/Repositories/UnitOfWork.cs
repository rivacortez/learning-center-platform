using learning_center_platformRI.Shared.Domain.Repositories;
using learning_center_platformRI.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace learning_center_platformRI.Shared.Infrastructure.Persistence.EFC.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context) => _context = context;

    public async Task CompleteAsync() => await _context.SaveChangesAsync();
}