using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace silkroadmvc.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public double Price { get; set; }
        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        public int? AuctionId { get; set; }
        [ForeignKey("AuctionId")]
        public Auction? Auction { get; set; }
    }
}
