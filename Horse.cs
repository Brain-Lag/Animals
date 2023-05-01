using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Horse : Animal
    {
        public override string TypeName => "horse";
        public void Neigh() => Console.WriteLine("Игого!");

        public override void Voice()
        {
            throw new NotImplementedException();
        }
    }
}
