namespace OnlineStore.API.Extensions
{
    public static class AddMapperExtension
    {
        public static void AddMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(AppMappingProfile));
        }
    }
}