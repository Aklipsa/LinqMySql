namespace LinqEntity.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class agentModel : DbContext
    {
        public agentModel()
            : base("name=agentModel")
        {
        }

        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<contract> contract { get; set; }
        public virtual DbSet<factor_risk> factor_risk { get; set; }
        public virtual DbSet<program> program { get; set; }
        public virtual DbSet<life_health> life_health { get; set; }
        public virtual DbSet<ownership> ownership { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.fio)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.contract)
                .WithRequired(e => e.client)
                .HasForeignKey(e => e.client_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<contract>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<factor_risk>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<factor_risk>()
                .HasMany(e => e.life_health)
                .WithRequired(e => e.factor_risk)
                .HasForeignKey(e => e.factor_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<program>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<program>()
                .HasMany(e => e.contract)
                .WithRequired(e => e.program)
                .HasForeignKey(e => e.program_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<life_health>()
                .Property(e => e.group)
                .IsUnicode(false);

            modelBuilder.Entity<ownership>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<ownership>()
                .Property(e => e.price)
                .IsUnicode(false);
        }
    }
}
