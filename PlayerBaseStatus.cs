using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class PlayerBaseStatus : StatusEffect
    {
        public PlayerBaseStatus() { }

        public override int HPeffect()
        {
            return 0;
        }

        public override int AttackEffect()
        {
            return 0;
        }

        public override int DefenceEffect()
        {
            return 0;
        }
    }
}
