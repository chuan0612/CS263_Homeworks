using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterLibrary;

namespace hunterLibrary
{
    public class hunter : public  monster
    {
        public hunter(string name, int blood)
        {
            this.name = "Joe";
            this.blood = 100;
        }
    }
}
