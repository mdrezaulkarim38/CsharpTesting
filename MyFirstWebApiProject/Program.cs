using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("V10", new OpenApiInfo
    {
        Title = "My Custom API",
        Version = "V10",
        Description = "A Brief Description of My Custom API",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Shuvo",
            Email = "mdrezaulkarim31295@gmail.com",
            Url = new Uri("https://github.com/mdrezaulkarim38")
        },
        License = new OpenApiLicense
        {
            Name = "Use Under Xyz",
            Url = new Uri("https://example.com/license")
        }
    });
});
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/V10/swagger.json", "My Custom API V10");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();