using Api_Authentication.Adapters.Http;
using Api_Authentication.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlPostgresExtensions(builder.Configuration);
builder.Services.AddDomainExtensions();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.AddEndpointRegister();
app.AddEndpointLogin();

app.Run();