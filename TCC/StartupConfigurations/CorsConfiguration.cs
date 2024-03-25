namespace TCC.StartupConfigurations
{
    public static class CorsConfiguration
    {
        public static IServiceCollection ConfigureCORS(this IServiceCollection services, string corsPolicyName)
        {
            return services.AddCors(options => options.AddPolicy(name: corsPolicyName, builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            }));
        }
    }
}
