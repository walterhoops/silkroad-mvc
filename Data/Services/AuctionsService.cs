using Microsoft.EntityFrameworkCore;
using silkroadmvc.Models;

namespace silkroadmvc.Data.Services
{
    public class AuctionsService : IAuctionsService
    {
        private readonly ApplicationDbContext _context;

        public AuctionsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Auction auction)
        {
            _context.Auctions.Add(auction);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Auction> GetAll()
        {
            var applicationDbContext = _context.Auctions.Include(a => a.User);
            return applicationDbContext;
        }

        public async Task<Auction> GetById(int? id)
        {
            var auction = await _context.Auctions
                .Include(a => a.User)
                .Include(a => a.Comments)
                .Include(a => a.Bids)
                .ThenInclude(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            return auction;
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
