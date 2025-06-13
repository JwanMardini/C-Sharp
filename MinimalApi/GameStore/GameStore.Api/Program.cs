using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStore.Api.Data.GameStoreContext>(connectionString);

var app = builder.Build();


app.MapGamesEndpoints();

app.MigrateDB();

app.Run();
