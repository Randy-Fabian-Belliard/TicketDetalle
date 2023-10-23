using Microsoft.EntityFrameworkCore;
using TicketsDetalle.Server.DAL;

namespace TicketsDetalle.Server.DAL;

public class TicketContext : DbContext
{
   public DbSet<Tickets> Tickets { get; set; }
    public TicketContext(DbContextOptions<TicketContext> options)
        : base(options) { }
   

}