using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Middlewares
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IScopedService scoped, ISingletonService singleton, ITransientService transient)
        {
            context.Items.Add("scoped-ticks", scoped.GetTimeTicks());
            context.Items.Add("transient-ticks", transient.GetTimeTicks());
            context.Items.Add("singleton-ticks", singleton.GetTimeTicks());

            // Call the next delegate/middleware in the pipeline.
            await _next(context);
        }

    }


}