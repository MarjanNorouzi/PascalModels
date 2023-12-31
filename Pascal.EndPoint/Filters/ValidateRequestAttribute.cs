﻿using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pascal.EndPoint.Filters
{
    public class ValidateRequestAttribute : IActionFilter
    {
        private readonly IServiceProvider _sp;

        public ValidateRequestAttribute(IServiceProvider sp)
        {
            _sp = sp;
        }

        public async void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.ActionArguments.FirstOrDefault().Value;

            if (request == null)
                return;

            var requestType = request.GetType();
            var validationType = typeof(IValidator<>).MakeGenericType(requestType);

            var validationContext = new ValidationContext<object>(request);

            if (_sp.GetRequiredService(validationType) is IValidator validator)
            {
                var result = await validator.ValidateAsync(validationContext);

                if (!result.IsValid)
                {
                    var errors = result.Errors.Select(x => x.ErrorMessage);
                    context.Result = new BadRequestObjectResult(errors);
                }
                    
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
