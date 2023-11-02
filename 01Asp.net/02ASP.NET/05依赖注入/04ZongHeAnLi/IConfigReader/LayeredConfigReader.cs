using ConfigService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigReader {
    public class LayeredConfigReader : IConfigReader {
        private readonly IEnumerable<IConfigService> services;

        public LayeredConfigReader(IEnumerable<IConfigService> services) {
            this.services = services;
        }

        public string GetValue(string name) {
            string value = null;
            foreach (var service in services) {
                value = service.GetValue(name);//最后一个不为null的值，就是最终值
                if (value != null)
                {
                    return value;
                }
            }
            return null;
        }
    }
}
