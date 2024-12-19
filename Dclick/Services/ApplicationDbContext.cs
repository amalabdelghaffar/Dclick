using System.Net.Mail;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Dclick.Services.EmailSender;

namespace Dclick.Services
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> products {  get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmailSender.Attachment> Attachments { get; set; }
    }
}
