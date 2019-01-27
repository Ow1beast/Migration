namespace Migration
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MigrationContext : DbContext
    {
        public MigrationContext() : base("name=MigrationContext") { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}