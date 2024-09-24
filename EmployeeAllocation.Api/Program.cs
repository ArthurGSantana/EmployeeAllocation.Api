using EmployeeAllocation.IoC;

var builder = WebApplication.CreateBuilder(args);

DependencyContainer.RegisterServices(builder.Services, builder.Configuration.GetConnectionString("PostgresConnectionString"));

builder.Services.AddControllers();
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

DependencyContainer.InitializeDatabase(app.Services);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();
