using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(BooksDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
