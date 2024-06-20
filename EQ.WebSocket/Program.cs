using EQ.WebSocket;
using EQ.WebSocket.Common;
using EQ.WebSocket.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Add services to the container.

builder.Services.AddMediatR(x =>
{
    x.RegisterServicesFromAssemblies(typeof(Program).Assembly);
});

builder.Services.AddSingleton<TimerControl>();
builder.Services.AddSingleton<TimerControlPreparing>();
builder.Services.AddDbContext<WpSzikeContext>(options =>
    options.UseMySQL(config.GetConnectionString("Production")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSignalR();
builder.Services.AddHttpClient();

const string clientPermission = "_clientPermission";

builder.Services.AddCors(x => x.AddPolicy(clientPermission, p =>
    { p.SetIsOriginAllowed(_ => true)
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials(); 
    }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.UseCors(clientPermission);

app.MapHub<OrdersHub>("/orders");

app.Run();
