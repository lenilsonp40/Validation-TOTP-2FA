using Microsoft.EntityFrameworkCore;
using Validacao_TOTP_2FA.API.Utilities.DTOMappings;
using Validacao_TOTP_2FA.Infra.Context;
using Validacao_TOTP_2FA.Infra.Interfaces;
using Validacao_TOTP_2FA.Infra.Repositories;
using Validacao_TOTP_2FA.Services.Interfaces;
using Validacao_TOTP_2FA.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddScoped<ICustomersService, CustomersService>();
builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();

builder.Services.AddAutoMapper(typeof(UserDTOMappingProfile));



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
