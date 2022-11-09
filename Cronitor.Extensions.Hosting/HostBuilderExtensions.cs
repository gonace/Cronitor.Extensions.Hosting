using Microsoft.Extensions.Hosting;
using System;

namespace StatsdClient.Extensions.Hosting
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseCronitor(this IHostBuilder builder, string apiKey)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            ConfigureCronitor(apiKey);

            return builder;
        }

        private static void ConfigureCronitor(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            Cronitor.Cronitor.Configure(apiKey);
        }
    }
}
