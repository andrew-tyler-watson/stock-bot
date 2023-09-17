using Alpaca.Markets;
using Environments = Alpaca.Markets.Environments;
using Stockbot.Infrastructure.ProviderSettings;
using StockBot.Application.Interfaces;
using Stockbot.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(
    typeof(AlpacaService), 
    () => {
        AlpacaConnectionSettings alpacaSettings = builder.Configuration.GetValue(typeof(AlpacaConnectionSettings), "AlpacaConnectionSettings") as AlpacaConnectionSettings;
        var dataClient = Environments.Paper.GetAlpacaDataClient(new SecretKey(alpacaSettings.Key, alpacaSettings.Secret));
        var tradingClient = Environments.Paper.GetAlpacaTradingClient(new SecretKey(alpacaSettings.Key, alpacaSettings.Secret));

        return new AlpacaService(tradingClient, dataClient);
    });

builder.Services.AddSingleton(typeof(ITradingService), typeof(AlpacaService));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
