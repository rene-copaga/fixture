using System.Data.Entity;

namespace Fixture.Model.DbContainer
{
    public class FixtureContext : DbContext
    {
        public FixtureContext() : base("name=FixtureContext")
        {
        }

        public DbSet<Championship> Championships { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Championship>()
                .HasRequired(c => c.Place)
                .WithRequiredDependent(p => p.Championship);

            modelBuilder.Entity<Player>().Map(m => {
                m.MapInheritedProperties();
                m.ToTable("Players");
            });

            modelBuilder.Entity<Team>().Map(m => {
                m.MapInheritedProperties();
                m.ToTable("Teams");
            });
        }
    }
}
