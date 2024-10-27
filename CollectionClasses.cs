using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class CollectionIntValueClass
    {
        public string Name;
        public int Value;

        public override string ToString()
        {
            return $"Name: {Name}, IntValue: {Value}";
        }
    }

    internal class CollectionDoubleValueClass
    {
        public string Name;
        public double Value;

        public override string ToString()
        {
            return $"Name: {Name}, DoubleValue: {Value:N2}";
        }
    }
}
