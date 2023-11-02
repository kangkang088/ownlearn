using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigService;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection {
    public static class iniFileConfigExtension {
        public static void AddIniFileConfig(this IServiceCollection services, string filePath) {
            services.AddScoped(typeof(IConfigService), s => new iniFileConfigService { FilePath = filePath });
        }
    }
}
