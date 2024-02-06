using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Armor : StatusEffectDecorator { } // abstraction for different types of armors

    public class LeatherArmor : Armor
    {
        public LeatherArmor(StatusEffect statusEffect)
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
            return 5;
        }
    }

    public class ChainMailArmor : Armor
    {
        public ChainMailArmor(StatusEffect statusEffect)
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

    public class KnightsArmor : Armor
    {
        public KnightsArmor(StatusEffect statusEffect)
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
            return 40;
        }
    }

    public class HolyArmor : Armor
    {
        public HolyArmor(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

        public override int HPeffect()
        {
            return 10;
        }

        public override int AttackEffect()
        {
            return 10;
        }

        public override int DefenceEffect()
        {
            return 50;
        }
    }

}
