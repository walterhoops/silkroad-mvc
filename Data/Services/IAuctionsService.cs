using silkroadmvc.Models;

namespace silkroadmvc.Data.Services
{
    public interface IAuctionsService
    {
        IQueryable<Auction> GetAll();
        Task Add(Auction auction);
        Task<Auction> GetById(int? id);
        Task SaveChanges();
    }
}
