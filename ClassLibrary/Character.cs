using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Character
    {
        //FIEDLS
        private string _name;
        private int _hitChance;
        private int _critChance;
        private int _block;
        private int _life;
        private int _maxLife;


        //PROPS
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int CritChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }
        //CTORS
        //N.A.

        //METHODS
        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcCritChance()
        {
            return CritChance;
        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

    }
}
