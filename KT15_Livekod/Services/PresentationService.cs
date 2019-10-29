using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace KT15_Livekod.Services {
    public interface IPresentationService<T> {
        void Output(T item, Stream targetStream);
    }
    public class PresentationService : IPresentationService<string[,]> {
        public void Output(string[,] item, Stream targetStream) {
            using (var writer = new StreamWriter(targetStream)) {
                for (var y = 0; y < item.GetLength(0); y++) {
                    for (var x = 0; x < item.GetLength(1); x++) {
                        writer.Write(item[y,x]);
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
