using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Apple : Food
    {
        public override int Health { get; init; }
        public override string TypeName
        {
            get => "apple";
        }
    }
}
