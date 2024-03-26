using CrossCutting.Services.TokenService;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using TCC.StartupConfigurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwagger();
builder.Services.ConfigureToken(TokenService.Secret);
builder.Services.ConfigureCORS("ICT");

builder.Services.AddControllers();
builder.Services.AddDbContext<IctDbContext>(option =>
{
    option.UseMySql(builder.Configuration.GetConnectionString(builder.Configuration.GetSection("ConnectionString").Value), ServerVersion.AutoDetect(builder.Configuration.GetSection("ConnectionString").Value));
});

builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<IctDbContext>();
    // use context
}

app.UseSwagger();
app.UseSwaggerUI();
app.MapDefaultControllerRoute();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("ICT");

app.UseHttpsRedirection();

app.Run();