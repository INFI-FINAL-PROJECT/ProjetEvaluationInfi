using FetchApiSirene.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;


namespace FetchApiSirene.DataAccess.Data
{
    public class EstablishmentsDbContext : DbContext
    {
        public EstablishmentsDbContext(DbContextOptions<EstablishmentsDbContext> options) : base(options) { }

        public DbSet<Establishments> school{ get; set; }
    }
}
