using AutoBazaar.Common.Domain.BaseEntities;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();
app.MapPut("/testMulti", () =>
{
    var entity = new TestEntity();
    return Results.Ok(entity); // return 200 with the object
})
.WithName("testMulti")
.WithOpenApi();

app.Run();

// Ensure TestTranslation inherits from IEntityTranslation in the correct namespace
public class TestTranslation : IEntityTranslation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Language { get; set; }
    public string? Value { get; set; }

    // Implement the required LanguageCode property from IEntityTranslation
    public string LanguageCode
    {
        get => Language ?? string.Empty;
        set => Language = value;
    }
}

// The entity uses BaseMultiLingualEntity<TTranslation>
public class TestEntity : BaseMultiLingualEntity<TestTranslation,Guid>
{
    public string Name { get; set; } = "sample";

    public TestEntity()
    {
        // Provide at least one translation to test Translations list
        Translations.Add(new TestTranslation { Language = "en", Value = "Sample EN" });
        Translations.Add(new TestTranslation { Language = "fr", Value = "Exemple FR" });
    }
}
internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
