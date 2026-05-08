using Microsoft.EntityFrameworkCore;
using Npgsql;
using ComicoApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

var connectionString = new NpgsqlConnectionStringBuilder(databaseUrl)
{
    SslMode = SslMode.Require,
    TrustServerCertificate = true
}.ConnectionString;

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// รับ PORT จาก Railway
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    db.Database.Migrate();
    await DbSeeder.SeedAsync(db);
}

if (app.Environment.IsDevelopment())
    app.MapOpenApi();

app.MapControllers();
app.Run();