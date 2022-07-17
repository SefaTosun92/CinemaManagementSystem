using EntityLayer.Entities;
using System.Data.Entity;


namespace DataAccessLayer
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        { }
        public virtual DbSet<Movies> MoviesTable { get; set; }
        public virtual DbSet<MovieType> MovieTypeTable { get; set; }
        public virtual DbSet<Session> SessionTable { get; set; }
        public virtual DbSet<Saloon> SaloonTable { get; set; }

        public virtual DbSet<Customer> CustomerTable { get; set; }
        public virtual DbSet<SellTicket> SellTicketTable { get; set; }

        public virtual DbSet<Presentation> Presentation { get; set; }


    }
}
