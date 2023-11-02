using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigReader;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection {
    public static class LayeredConfigExtension {
        public static void AddLayeredConfig(this IServiceCollection services) {
            services.AddScoped<IConfigReader, LayeredConfigReader>();
        }
    }
}
