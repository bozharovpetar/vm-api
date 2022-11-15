using Microsoft.EntityFrameworkCore;
using VM.Repository;
using VM.Repository.Implementation;
using VM.Service;
using VM.Service.Implementation;
using VM.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

#region Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICoffeeRepository), typeof(CoffeeRepository));
builder.Services.AddScoped(typeof(IIngredientRepository), typeof(IngredientRepository));
builder.Services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
#endregion

#region Services
builder.Services.AddTransient(typeof(ICoffeeService), typeof(CoffeeService));
builder.Services.AddTransient(typeof(IIngredientService), typeof(IngredientService));
builder.Services.AddTransient(typeof(IOrderService), typeof(OrderService));
builder.Services.AddTransient(typeof(IBuilder), typeof(CoffeeBuilder));
// builder.Services.AddTransient(typeof(IBuilder), typeof(ReceiptBuilder));
#endregion

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPolicy", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CORSPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
