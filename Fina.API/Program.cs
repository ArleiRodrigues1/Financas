using Fina.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string connectionString = "Server=localhost,1433;Database=Fina;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False;TrustServerCertificate=True;";

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));

app.MapGet("/", () => "Hello World!");

app.Run();
