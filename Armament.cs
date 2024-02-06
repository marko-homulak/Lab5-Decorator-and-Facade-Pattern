using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Armament : StatusEffectDecorator { } // abstraction for different types of weapons

    public class Sword : Armament
    {
        public Sword(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

        public override int HPeffect()
        {
            return 0;
        }

        public override int AttackEffect()
        {
            return 16;
        }

        public override int DefenceEffect()
        {
            return 0;
        }
    }

    public class Bow : Armament
    {
        public Bow(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

        public override int HPeffect()
        {
            return 0;
        }

        public override int AttackEffect()
        {
            return 10;
        }

        public override int DefenceEffect()
        {
            return 0;
        }
    }

    public class Daggers : Armament
    {
        public Daggers(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

        public override int HPeffect()
        {
            return 0;
        }

        public override int AttackEffect()
        {
            return 12;
        }

        public override int DefenceEffect()
        {
            return 0;
        }
    }

    public class Mace : Armament
    {
        public Mace(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

        public override int HPeffect()
        {
            return 0;
        }

        public override int AttackEffect()
        {
            return 20;
        }

        public override int DefenceEffect()
        {
            return 0;
        }
    }

    public class Hatchet : Armament
    {
        public Hatchet(StatusEffect statusEffect)
        {
            this.statusEffect = statusEffect;
        }

        public override int HPeffect()
        {
            return 0;
        }

        public override int AttackEffect()
        {
            return 24;
        }

        public override int DefenceEffect()
        {
            return 0;
        }
    }

}
