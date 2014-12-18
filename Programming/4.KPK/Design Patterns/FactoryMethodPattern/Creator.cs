using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    // "Creator" 
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
