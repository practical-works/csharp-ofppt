using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Révision
{
    class Player : Character
    {
        public Player() : base() { }
        public Player(string name, int lvl, double xp, int hp, int sp, double atk, double def) 
            : base(name,lvl,xp,hp,sp,atk,def) { }
        public Player(Player c) : base(c) { }

        public void Attack(Enemy target)
        {
            double damage = 2*ATK - target.DEF;
            if (damage >= 0 && damage <= target.HP)
            {
                target.HP -= (int)damage;
            }
            else
            {
                target.HP -= 1;
            }
        }
    }
}
