namespace OnlineStore.DAL.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;
        public Guid? ParentCategoryId { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
        public virtual Category? ParentCategory { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; } = default!;
    }
}
