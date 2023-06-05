using ShopDomainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()//all tests named by they are doing
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

    }
}
