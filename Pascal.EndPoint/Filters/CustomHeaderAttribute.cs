using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Xml.Linq;

namespace Pascal.EndPoint.Filters
{
    /// <summary>
    /// </summary>
    public class CustomHeaderAttribute : IOperationFilter
    {
        /// <summary>
        /// نمایش داده نمیشود
        /// </summary>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "X-CustomHeader",
                In = ParameterLocation.Header,
                Required = false,
                Schema = new OpenApiSchema
                {
                    Default = new OpenApiString("foobar"),
                    Type = "string"
                }
            });
        }
    }

    public class ApiParameters : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            //<form action="http://example.com/survey" method="post">
            // < input type = "text"   name = "name" />
            // < input type = "number" name = "fav_number" />
            // < input type = "submit" />
            //</ form >
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                
            });
        }
    }
}
