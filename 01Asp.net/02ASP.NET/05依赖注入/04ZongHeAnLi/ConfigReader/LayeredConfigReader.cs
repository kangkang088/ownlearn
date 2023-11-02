using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigService;

namespace ConfigReader {
    public class LayeredConfigReader : IConfigReader {
        private readonly IEnumerable<IConfigService> services;

        public LayeredConfigReader(IEnumerable<IConfigService> services) {
            this.services = services;
        }

        public string GetValue(string name) {
            string str = null;
            foreach (var service in services) {
                str = service.GetValue(name);
                if (str != null) { return str; }
            }
            return null;
        }
    }
}
