namespace OnlineStore.BLL.Models
{
    public class CategoryModel : BaseModel
    {
        public string Name { get; set; } = default!;
        public Guid? ParentCategoryId { get; set; }
        public ICollection<CategoryModel> SubCategories { get; set; } = default!;
    }
}