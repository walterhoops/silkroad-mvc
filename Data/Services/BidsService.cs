using Microsoft.EntityFrameworkCore;
using silkroadmvc.Models;

namespace silkroadmvc.Data.Services
{
    public class BidsService : IBidsService
    {
        private readonly ApplicationDbContext _context;
        public BidsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Bid bid)
        {
            _context.Bids.Add(bid);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Bid> GetAll()
        {
            var applicationDbContext = from b in _context.Bids.Include(a => a.Auction).ThenInclude(a => a.User)
                                       select b;
            return applicationDbContext;
        }
    }
}
