using Microsoft.EntityFrameworkCore;
using ServiceActsApi.Models;

namespace ServiceActsApi.Data
{
    public class ServiceActsContext : DbContext
    {
        public ServiceActsContext(DbContextOptions<ServiceActsContext> options) : base(options) { }

        public DbSet<ServiceAct> ServiceActs { get; set; }
    }
}