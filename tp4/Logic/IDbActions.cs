using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    interface IDbActions
    {
        void Add<T>(T insertedObject);
        void DataCheck<T>(T checkedObject);
        void Delete(int id);
        void Update<T>(T updatedItem);
    }
}
