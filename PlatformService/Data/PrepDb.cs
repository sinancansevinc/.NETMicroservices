namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var platformService = serviceScope.ServiceProvider.
            }
        }

        private static void SeedData(AppDbContext context)
        {

        }
    }
}
