using TCC.StartupConfigurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwagger();
builder.Services.ConfigureToken("43efe49b9dfe8fdcc7ffb4bb42e3437ffbe113298348ec7f00a8b5159b3c28a5");
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