using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class ClassesLogic
    {
        protected readonly NorthwindContext context;
        public ClassesLogic()
        {
            context = new NorthwindContext();
        }

        public List<T> GetAll<T>()
            where T:class
        {
            return context.Set<T>().ToList();
        }

        public abstract String ShowInfo();

    }
}

