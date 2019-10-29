using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Newtonsoft.Json;

namespace DataLogik.Services {
    public class RealDataService : IDataService<string[,]> {
        private readonly string _filename;
        private readonly JsonSerializer _jsonSerializer;

        public RealDataService(string filename) {
            _filename = filename;
            _jsonSerializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.All };
        }

        public string[,] Load() {
            using (var sr = new StreamReader(_filename)) {
                using (var jtr = new JsonTextReader(sr)) {
                    return _jsonSerializer.Deserialize<string[,]>(jtr);
                }
            }
        }

        public void Save(string[,] items) {
            using (var sw = new StreamWriter(_filename)) {
                using (var jtw = new JsonTextWriter(sw)) {
                    _jsonSerializer.Serialize(jtw, items);
                }
            }
        }
    }
}
