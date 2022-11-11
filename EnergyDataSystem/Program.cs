using EnergyDataSystem;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// IgnoreCycles to get rid of JSON cycle error
// https://docs.microsoft.com/en-us/dotnet/api/system.text.json.serialization.referencehandler.preserve?view=net-6.0
builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions
                .ReferenceHandler = ReferenceHandler.IgnoreCycles);

// Create connection string and DbContext service
var connectionString = builder.Configuration.GetConnectionString("EDS_Db_Connection");

builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer(connectionString));

// Inject dependencies - implementation of the repo's when called
//


// Trigger creation of Automapper maps specified in AutoMapperProfiles.cs
// builder.Services.AddAutoMapper(typeof(Program).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();