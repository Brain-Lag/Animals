using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Orange : Food
    {
        public override int Health { get; init; }
        public override string TypeName
        {
            get => "orange";
        }
    }
}
