namespace OnlineStore.API.DTOs
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public Guid? ParentCategoryId { get; set; }
        public ICollection<CategoryDto> SubCategories { get; set; } = default!;
    }
}