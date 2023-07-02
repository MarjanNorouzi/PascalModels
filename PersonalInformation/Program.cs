using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Filters;
using PersonalInformation.Filters;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen(options =>
//{
//    List<string> xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
//    foreach (string fileName in xmlFiles)
//    {
//        string xmlFilePath = Path.Combine(AppContext.BaseDirectory, fileName);
//        if (File.Exists(xmlFilePath))
//            options.IncludeXmlComments(xmlFilePath, includeControllerXmlComments: true);
//    };
//});


////builder.Services.AddValidatorsFromAssemblyContaining<PersonalInformation.Validation.RefoundRequestValidator>();
//builder.Services.AddScoped<IActionFilter, ValidateRequestAttribute>();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseAuthorization();

app.MapControllers();

app.Run();
