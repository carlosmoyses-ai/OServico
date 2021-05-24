using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(OServico.Areas.Identity.IdentityHostingStartup))]

namespace OServico.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}