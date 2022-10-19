using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace CaaS
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

    }
}
