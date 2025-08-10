using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PropertyBookingAPI.Data;
using PropertyBookingAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add SQL Server support with your connection string
builder.Services.AddDbContext<PropertyBookingAPI.Models.ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Add Identity using your custom user model
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<PropertyBookingAPI.Models.ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ⚙️ Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseAuthentication(); // ✅ Important
app.UseAuthorization();

app.MapControllers();

app.Run();

