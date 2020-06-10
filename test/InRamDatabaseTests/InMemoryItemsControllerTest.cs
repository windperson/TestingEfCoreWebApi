using Items;
using Items.Models;
using Microsoft.EntityFrameworkCore;

namespace InRamDatabaseTests
{
    public class InMemoryItemsControllerTest : ItemsControllerTest
    {
        public InMemoryItemsControllerTest()
            : base(
                new DbContextOptionsBuilder<ItemsContext>()
                    .UseInMemoryDatabase("TestDatabase")
                    .Options)
        {
        }
    }
}