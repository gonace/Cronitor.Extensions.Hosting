using Microsoft.Extensions.Hosting;
using System;

namespace Cronitor.Extensions.Hosting
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseCronitor(this IHostBuilder builder, string apiKey)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            ConfigureCronitor(apiKey);

            return builder;
        }

        public static IHostBuilder UseCronitor(this IHostBuilder builder, Func<HostBuilderContext, string> options)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            builder.ConfigureServices((context, services) =>
            {
                var apiKey = options(context);
                ConfigureCronitor(apiKey);
            });

            return builder;
        }

        private static void ConfigureCronitor(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentNullException(nameof(apiKey));

            Cronitor.Configure(apiKey);
        }
    }
}
