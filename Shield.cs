using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Shield : StatusEffectDecorator { } // abstraction for different types of shields

    public class WoodenShield : Shield
    {
        public WoodenShield(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

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
            return 20;
        }
    }

    public class IronShield : Shield
    {
        public IronShield(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

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
            return 50;
        }
    }

}
