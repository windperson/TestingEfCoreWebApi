using Items;
using Items.Models;
using Microsoft.EntityFrameworkCore;

namespace InRamDatabaseTests
{
    #region SqliteItemsControllerTest
    public class SqliteItemsControllerTest : ItemsControllerTest
    {
        public SqliteItemsControllerTest()
            : base(
                new DbContextOptionsBuilder<ItemsContext>()
                    .UseSqlite("Filename=Test.db")
                    .Options)
        {
        }
    }
    #endregion
}