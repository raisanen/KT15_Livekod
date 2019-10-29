using System;
using System.Collections.Generic;
using System.Text;

namespace DataLogik.Services {
    public interface IDataService<T> {
        T Load();
        void Save(T items);
    }
}
