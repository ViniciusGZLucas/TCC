using BusinessRule;
using CrossCutting.Services.TokenService;
using Domain.Interface;
using Domain.Interface.BusinessRule;
using Domain.Interface.Repository;
using Infrastructure;
using Infrastructure.Context;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using TCC.StartupConfigurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwagger();
builder.Services.ConfigureToken(TokenService.Secret);
builder.Services.ConfigureCORS("ICT");

builder.Services.AddEntityFrameworkMySql();

var connectionString = builder.Configuration.GetSection("ConnectionString").Value;

builder.Services.AddDbContext<IctDbContext>(option => option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<IUserRoleRepository, UserRoleRepository>();
builder.Services.AddTransient<IArticleRepository, ArticleRepository>();
builder.Services.AddTransient<IArticleDocumentRepository, ArticleDocumentRepository>();

builder.Services.AddTransient<IUserBusinessRule, UserBusinessRule>();
builder.Services.AddTransient<IRoleBusinessRule, RoleBusinessRule>();
builder.Services.AddTransient<IUserRoleBusinessRule, UserRoleBusinessRule>();
builder.Services.AddTransient<IArticleBusinessRule, ArticleBusinessRule>();

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