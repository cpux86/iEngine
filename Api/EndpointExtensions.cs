namespace Api
{
    public static class EndpointExtensions
    {
        public static void UseEndpointExtensions(this IEndpointRouteBuilder app)
        {
            app.MapGet("/test", () => "Hello World");
        }
    }
}
