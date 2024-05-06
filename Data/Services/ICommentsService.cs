using silkroadmvc.Models;

namespace silkroadmvc.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
