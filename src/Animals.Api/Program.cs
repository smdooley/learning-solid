using Animals.Domain;
using Animals.Application.Abstractions;
using Animals.Application.Services;
using Animals.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Register DI
builder.Services.AddScoped<IAnimalRepository, AnimalRepository>();
builder.Services.AddScoped<IAnimalService, AnimalService>();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Global error handler (simple)
app.UseExceptionHandler(a =>
{
    a.Run(async ctx =>
    {
        ctx.Response.StatusCode = 500;
        await ctx.Response.WriteAsJsonAsync(new { error = "Unexpected error occurred." });
    });
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Launch the app and navigate to https://localhost:<port>/openapi/v1.json to view the generated OpenAPI document.
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/animals", async (IAnimalService animalService) =>
{
    var result = await animalService.GetAllAsync();
    return Results.Ok(result);
});

app.Run();