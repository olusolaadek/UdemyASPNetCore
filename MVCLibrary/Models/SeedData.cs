using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;
                }
                context.AddRange(
                    new Book { Title = "Tiny C# Projects", CallNumber = "TN-100021" },
                    new Book { Title = "Tiny Android Projects", CallNumber = "TN-100022" }
                    );
                int result = context.SaveChanges();
            };
        }
    }
}
