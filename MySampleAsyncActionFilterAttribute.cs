using Microsoft.AspNetCore.Mvc.Filters;

namespace AspnetFilters
{
    public class MySampleAsyncActionFilterAttribute : Attribute,IAsyncActionFilter
    {
        private readonly string _name;

        public MySampleAsyncActionFilterAttribute(string name)
        {
            _name = name;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Before  filter {_name} ");
            await next();
            Console.WriteLine($"After  filter {_name} ");
        }
    }
}
