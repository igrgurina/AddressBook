using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.EntityFrameworkCore
{
    public static class AddressBookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AddressBookDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AddressBookDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
