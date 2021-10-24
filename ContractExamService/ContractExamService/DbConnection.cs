using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ContractExamService
{
    public partial class DbConnection : DbContext
    {
        public DbConnection()
            : base("name=ContactExamDB")
        {
        }

        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractDate> ContractDates { get; set; }
        public virtual DbSet<ContractDateType> ContractDateTypes { get; set; }
        public virtual DbSet<ContractPrice> ContractPrices { get; set; }
        public virtual DbSet<ContractPriceType> ContractPriceTypes { get; set; }
        public virtual DbSet<ContractState> ContractStates { get; set; }
        public virtual DbSet<ContractXSubject> ContractXSubjects { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Individual> Individuals { get; set; }
        public virtual DbSet<SubjectRole> SubjectRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractDateType>()
                .HasMany(e => e.ContractDates)
                .WithOptional(e => e.ContractDateType1)
                .HasForeignKey(e => e.ContractDateType);

            modelBuilder.Entity<ContractPrice>()
                .Property(e => e.Value)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContractState>()
                .HasMany(e => e.Contracts)
                .WithOptional(e => e.ContractState)
                .HasForeignKey(e => e.IDState);
        }
    }
}
