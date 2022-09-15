using BigOn.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BigOn.WebUI.Models.DataContexts
{
    public class BigOnDbContext: DbContext
    {
        public BigOnDbContext(DbContextOptions option)
            :base(option)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductSize> ProductSize { get; set; }
        public DbSet<ProductMaterial> ProductMaterial { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
    }

}
