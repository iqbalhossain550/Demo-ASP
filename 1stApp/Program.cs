var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Run(async (HttpContext context) =>
{

    context.Response.StatusCode = 400;

   await context.Response.WriteAsync("Hello");

});


app.Run();
