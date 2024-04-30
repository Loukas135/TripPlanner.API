using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using TripPlanner.API.Configuration;
using TripPlanner.API.Data;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TripPlanner.API.Contracts;
using TripPlanner.API.Repository;
using TripPlanner.API.Repository.Generics;
using TripPlanner.API.Contracts.Generics;
using TripPlanner.API.Contracts.MiniServices;
using TripPlanner.API.Repository.MiniServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("TripPlannerDbConnectionString");
builder.Services.AddDbContext<TripPlannerDbContext>(options =>
{
	options.UseSqlServer(connectionString);
});

builder.Services.AddIdentityCore<ApiUser> ()
	.AddRoles<IdentityRole>()
	.AddTokenProvider<DataProtectorTokenProvider<ApiUser>>("TripPlannerLoginProvidor")
    .AddEntityFrameworkStores<TripPlannerDbContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll",
		b => b.AllowAnyHeader()
			.AllowAnyOrigin()
			.AllowAnyMethod());
});

builder.Host.UseSerilog((ctx, lc) =>lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IAuthManager, AuthManager>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<ITripRepository, TripRepository>();
builder.Services.AddScoped<ICarRepository, CarRepository>();


builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
	{
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuerSigningKey = true,
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ClockSkew = TimeSpan.Zero,
			ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
			ValidAudience = builder.Configuration["JwtSettings:Audience"],
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
		};
	}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
