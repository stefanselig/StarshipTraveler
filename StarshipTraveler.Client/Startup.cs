using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using StarshipTraveler.Model;

namespace StarshipTraveler.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IFlightplan, Flightplan>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<StarshipTraveler.Components.App>("app");
        }
    }
}
