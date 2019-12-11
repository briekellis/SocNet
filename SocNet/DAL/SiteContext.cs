using SocNet.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SocNet.DAL
{
    public class SiteContext : DbContext
    {
        public SiteContext() : base("SiteContext") 
        { 
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}