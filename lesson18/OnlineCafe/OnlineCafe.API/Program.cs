using OnlineCafe.API;
using OnlineCafe.Services.Mapper;
using OnlineCafe.Services.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddConfiguration(new ConfigurationBuilder()
         .AddJsonFile("appsettings.json")
         .AddJsonFile("appsettings.Development.json")
         .Build());
builder.Services.ConfigureDbConnection(builder.Configuration);

builder.Services.AddTransient<IGuestService, GuestService>();
builder.Services.AddTransient<IIngredientService, IngredientService>();
builder.Services.AddTransient<IMenuIngredientService, MenuIngredientService>();
builder.Services.AddTransient<IMenuService, MenuService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<ITableService, TableService>();
builder.Services.AddSingleton<IGuestMapper, GuestMapper>();
builder.Services.AddSingleton<IIngredientMapper, IngredientMapper>();
builder.Services.AddSingleton<IMenuIngredientMapper, MenuIngredientMapper>();
builder.Services.AddSingleton<IMenuMapper, MenuMapper>();
builder.Services.AddSingleton<IOrderMapper, OrderMapper>();
builder.Services.AddSingleton<ITableMapper, TableMapper>();

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
