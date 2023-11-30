using Microsoft.EntityFrameworkCore;
using Tourism_Application.Data;
using Tourism_Application.Repositories.BookingRepositories;
using Tourism_Application.Repositories.DestinationRepositories;
using Tourism_Application.Repositories.HotelRepositories;
using Tourism_Infrastructure.Services.BookingServices;
using Tourism_Infrastructure.Services.DestinationServices;
using Tourism_Infrastructure.Services.HotelServices;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TourismDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IBookingService, BookingService>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();    
builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();
builder.Services.AddScoped<IDestinationService, DestinationService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
