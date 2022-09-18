using Microsoft.EntityFrameworkCore;
using OnlineSweetShopy.Models;

namespace OnlineSweetShopy.Models
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public DbSet<SweetCategory> SweetCategories { get; set; }
        public DbSet<SweetProduct> SweetProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Offer> Offers { get; set; }
       
        public DbSet<EventBookingReq> EventBookingReqs { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}
