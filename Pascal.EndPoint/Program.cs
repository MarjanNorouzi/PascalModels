using FluentValidation;
using Microsoft.AspNetCore.Mvc.Filters;
using Pascal.EndPoint.Filters;
using PascalModels.Validations;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    List<string> xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
    foreach (string fileName in xmlFiles)
    {
        string xmlFilePath = Path.Combine(AppContext.BaseDirectory, fileName);
        if (File.Exists(xmlFilePath))
            options.IncludeXmlComments(xmlFilePath, includeControllerXmlComments: true);
    };
    //options.OperationFilter<CustomHeaderAttribute>();
});


builder.Services.AddValidatorsFromAssemblyContaining<GeneralsListReportByGrCodeReqValidator>();
builder.Services.AddScoped<IActionFilter, ValidateRequestAttribute>();
builder.Services.AddScoped<TempAttribute>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

