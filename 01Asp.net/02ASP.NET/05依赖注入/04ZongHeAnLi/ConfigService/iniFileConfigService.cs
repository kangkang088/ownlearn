using System.IO;
using System.Linq;
using System.Net;

namespace ConfigService {
    public class iniFileConfigService : IConfigService {
        public string FilePath { get; set; }
        public string GetValue(string name) {
            var kv = File.ReadLines(FilePath).Select(s => s.Split('=')).Select(s => new { Name = s[0], value = s[1] }).SingleOrDefault(kv => kv.Name == name);
            if (kv != null) {
                return kv.value;
            }
            else {
                return null;
            }
        }
    }
}