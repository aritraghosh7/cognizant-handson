using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Exercise3.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = $"Exception: {context.Exception.Message} at {DateTime.Now}\n";
            File.AppendAllText("errors.log", message);

            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
