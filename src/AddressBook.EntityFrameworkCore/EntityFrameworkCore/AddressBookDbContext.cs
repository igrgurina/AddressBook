using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AddressBook.Authorization.Roles;
using AddressBook.Authorization.Users;
using AddressBook.Contacts;
using AddressBook.MultiTenancy;

namespace AddressBook.EntityFrameworkCore
{
    public class AddressBookDbContext : AbpZeroDbContext<Tenant, Role, User, AddressBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

        public AddressBookDbContext(DbContextOptions<AddressBookDbContext> options)
            : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(2048);
        }
    }
}
