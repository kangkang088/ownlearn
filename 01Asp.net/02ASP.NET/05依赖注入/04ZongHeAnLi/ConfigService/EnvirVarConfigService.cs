using System;

namespace ConfigService {
    public class EnvirVarConfigService : IConfigService {
        public string GetValue(string name){
            return Environment.GetEnvironmentVariable(name);
        }
    }
}