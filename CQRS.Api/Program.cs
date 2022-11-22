using CQRS.Api;
using CQRS.Api.Handlers.CommandHandlers;
using CQRS.Api.Handlers.QueryHandlers;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddMediatR(typeof(AppDbContext));
builder.Services.AddTransient<CreateCustomerCommandHandler>();
builder.Services.AddTransient<DeleteCustomerCommandHandler>();
builder.Services.AddTransient<GetAllCustomerQueryHandler>();
builder.Services.AddTransient<GetByIdCustomerQueryHandler>();

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
