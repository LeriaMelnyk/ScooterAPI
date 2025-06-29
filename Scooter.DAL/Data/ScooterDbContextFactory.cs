using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ScooterDAL.Data
{
    public class ScooterDbContextFactory : IDesignTimeDbContextFactory<ScooterDbContext>
    {
        public ScooterDbContext CreateDbContext(string[] args) =>
            new(new DbContextOptionsBuilder<ScooterDbContext>()
                .UseNpgsql("Host=localhost;Port=5432;Database=ScooterDB;Username=postgres;Password=545292;")
                .Options);
    }
}
