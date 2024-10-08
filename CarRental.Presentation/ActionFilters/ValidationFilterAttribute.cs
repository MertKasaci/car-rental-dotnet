using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Presentation.ActionFilters
{
    public class ValidationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.HttpContext.Request.Method == "POST" || context.HttpContext.Request.Method == "PUT") { 
           
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];

            //Dto check
            if(context.ActionArguments.Any(p => p.Value.ToString().Contains("Dto")))
            {
              var param = context.ActionArguments.SingleOrDefault(p => p.Value.ToString().Contains("Dto")).Value;
                    if (param is null)
                    {
                        context.Result = new BadRequestObjectResult($"Object is null. " + $"Controller : {controller}" + $" Action : {action}");
                        return; // status code -> 400;
                    }

                    if (!context.ModelState.IsValid)
                        context.Result = new UnprocessableEntityObjectResult(context.ModelState); // status code -> 422

                }
            }
           

            

        }

    }
}
