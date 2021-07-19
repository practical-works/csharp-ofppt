using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO_Révision
{
    class Character
    {
        private int code;
        private string name;
        private int level;
        private double experience;
        private int hit_points;
        private int skill_points;
        private double attack_points;
        private double defense_points;
        private static int count = 0;

        public int Code { get { return code; } }
        public string Name { get { return name; } set { name = value; } }
        public int LVL { get { return level; }
                         set { if (value >= 0) level = value; else throw new InvalidStatException(); } }
        public double XP { get { return experience; }
                           set { if (value >= 0) experience = value; else throw new InvalidStatException(); } }
        public int HP { get { return hit_points; }
                        set { if (value >= 0) hit_points = value; else throw new InvalidStatException(); } }
        public int SP { get { return skill_points; }
                        set { if (value >= 0) skill_points = value; else throw new InvalidStatException(); } }
        public double ATK { get { return attack_points; }
                            set { if (value >= 0) attack_points = value; else throw new InvalidStatException(); } }
        public double DEF { get { return defense_points; }
                            set { if (value >= 0) defense_points = value; else throw new InvalidStatException(); } }
        public static int Count { get { return count; } }

        public Character()
        {
            count++;
            code = count;
        }
        public Character(string name, int lvl, double xp, int hp, int sp, double atk, double def)
        {
            count++;
            code = count;
            this.name = name;
            LVL = lvl;
            XP = xp;
            HP = hp;
            SP = sp;
            ATK = atk;
            DEF = def;
        }
        public Character(Character c)
        {
            count++;
            code = count;
            name = c.name;
            LVL = c.LVL;
            XP = c.XP;
            HP = c.HP;
            SP = c.SP;
            ATK = c.ATK;
            DEF = c.DEF;
        }

        public override string ToString()
        {
            // #117 TheName (LvL.17 / 117XP) ATK:7 / DEF:17
            return "#" + Code + " " + Name + " (LvL." + LVL + " / " + XP + ") HP:" + HP + " SP:" + SP
                + " / ATK:" + ATK + " DEF:" + DEF;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj == this)
            {
                return true;
            }
            else if (obj.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Character c = (Character)obj;
                if (c.Code == Code && c.Name == Name && c.LVL == LVL && c.XP == XP && 
                    c.HP == HP && c.SP == SP && c.ATK == ATK && c.DEF == DEF)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Attack(Character target)
        {
            double damage = ATK - target.DEF;
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
