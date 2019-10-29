using System;
using System.Collections.Generic;
using System.Text;

namespace DataLogik.Services {
    public class FakeDataService : IDataService<string[,]> {
        public string[,] Load() {
            return new string[,] {
                { " ", "O", " ", " " },
                { " ", "x", " ", " " },
                { " ", "x", " ", " " },
                { " ", ".", " ", " " },
                { " ", ".", " ", " " }
            };
        }

        public void Save(string[,] items) {

        }
    }
}
