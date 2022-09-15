using BigOn.WebUI.AppCode.Infrastructure;

namespace BigOn.WebUI.Models.Entities
{
    public class Product : BaseEntity
    {
        public int Name { get; set; }
        public decimal Rate { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
