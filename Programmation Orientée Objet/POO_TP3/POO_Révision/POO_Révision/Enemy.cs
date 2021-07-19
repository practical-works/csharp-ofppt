using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Révision
{
    class Enemy : Character
    {
        public Enemy() : base() { }
        public Enemy(string name, int lvl, double xp, int hp, int sp, double atk, double def) 
            : base(name,lvl,xp,hp,sp,atk,def) { }
        public Enemy(Enemy c) : base(c) { }
    }
}
