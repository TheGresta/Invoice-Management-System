using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RezervationSystem.Entity.Concrete;

namespace RezervationSystem.DataAccess.Contexts
{
    public class InvoiceManagementSystemDbContext : DbContext
    {
        public InvoiceManagementSystemDbContext()
        {
            #region PostgreSql EnableLegacyTimestampBehavior
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            #endregion
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(getConnectionString("PostgreSql"));
        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Style> Styles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Apartment[] apartmentEntitySeeds = {
                new() {BlockID=1,IsEmpty=true,StyleID=1,Floor=18,CustomerID=1},
                new() {BlockID=2,IsEmpty=true,StyleID=2,Floor=19,CustomerID=2},
                new() {BlockID=3,IsEmpty=true,StyleID=3,Floor=20,CustomerID=3},
            };

            modelBuilder.Entity<Apartment>().HasData(apartmentEntitySeeds);

            Block[] blockEntitySeeds = {
                new() {Name="A Block"},
                new() {Name="B Block"},
                new() {Name="C Block"},
            };

            modelBuilder.Entity<Block>().HasData(blockEntitySeeds);

            Card[] cardEntitySeeds = {
                new() {CustomerID=1,CardNumber=11223344,CardPassword=1234,Balance=3000},
                new() {CustomerID=2,CardNumber=11112222,CardPassword=4321,Balance=4000},
                new() {CustomerID=3,CardNumber=33334444,CardPassword=1221,Balance=5000},
            };

            modelBuilder.Entity<Card>().HasData(cardEntitySeeds);

            Style[] styleEntitySeeds = {
                new() {Name="1+1"},
                new() {Name="2+1"},
                new() {Name="3+1"},
                new() {Name="4+1"},
                new() {Name="5+1"},
            };

            modelBuilder.Entity<Style>().HasData(styleEntitySeeds);
        }

        private string getConnectionString(string name)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            IConfigurationRoot configurationManager = builder.Build();

            return configurationManager.GetConnectionString(name);
        }
    }
}
