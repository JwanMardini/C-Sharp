using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStoreContext>(connectionString);
// builder .Services.AddScoped<GameStoreContext>();

var app = builder.Build();


app.MapGamesEndpoints();
app.MapGenresEndpoints();

await app.MigrateDBAsync();

app.Run();
