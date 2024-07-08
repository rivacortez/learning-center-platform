namespace learning_center_platformRI.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}