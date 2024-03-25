using CrossCutting.Services.TokenService;
using TCC.StartupConfigurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwagger();
builder.Services.ConfigureToken(TokenService.Secret);
builder.Services.ConfigureCORS("ICT");

builder.Services.AddControllers();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapDefaultControllerRoute();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("ICT");

app.UseHttpsRedirection();

app.Run();