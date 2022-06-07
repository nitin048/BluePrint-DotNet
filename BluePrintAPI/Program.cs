using BluePrintApi.Repository;
using BluePrintBL.Services;
using BluePrintCore.Services;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddSingleton<IMongoClient, MongoClient>
    (
        sp => new MongoClient(builder.Configuration.GetConnectionString("MongoDb"))
    );
builder.Services.AddCors(builder => builder.AddPolicy("AllowAllOrigin",
               builder =>
               {
                   builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
               }));
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

//app.UseCors();
app.UseCors("AllowAllOrigin");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
