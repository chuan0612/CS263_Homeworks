using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class monster
    {
        public monster(string name, int blood) //血量
        {
            this.name = name;
            this.blood = blood;
        }
  
        public string name;
        public int blood;

      
    }
}
