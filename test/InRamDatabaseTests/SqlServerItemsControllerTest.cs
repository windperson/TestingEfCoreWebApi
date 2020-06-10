using Items;
using Items.Models;
using Microsoft.EntityFrameworkCore;

namespace InRamDatabaseTests
{
    public class SqlServerItemsControllerTest : ItemsControllerTest
    {
        public SqlServerItemsControllerTest()
            : base(
                new DbContextOptionsBuilder<ItemsContext>()
                    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFTestSample;ConnectRetryCount=0")
                    .Options)
        {
        }
    }
}