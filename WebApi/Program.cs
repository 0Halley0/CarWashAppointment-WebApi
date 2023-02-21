using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using FluentValidation.AspNetCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<Context>();
builder.Services.ContainerDependencies();
builder.Services.AddControllers().AddFluentValidation(options =>
{
	// Validate child properties and root collection elements
	options.ImplicitlyValidateChildProperties = true;
	options.ImplicitlyValidateRootCollectionElements = true;

	// Automatic registration of validators in assembly
	options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});
builder.Services.AddCors(opt =>
{
	opt.AddPolicy("CarWashAPICors", opts =>
	{
		opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
	});
});
builder.Services.AddSwaggerGen(options =>
{
	options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
	{
		Title="CarWashAppointment-WebApi", Version="v1"
	});
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.CustomValidator();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CarWashAPICors");

app.UseAuthorization();

app.MapControllers();

app.Run();
