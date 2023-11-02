using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogService;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection {
    public static class ConsoleLogExtension {
        public static void AddConsoleLog(this IServiceCollection services) {
            services.AddScoped<ILogProvider,ConsoleLogProvider>();
        }
    }
}
