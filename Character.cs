using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Character : StatusEffectDecorator
    {
        private int hp;
        private int attack;
        private int defence;

        public string name { get; private set; }

        public List<StatusEffectDecorator> inventory;

        private static int instanceCount = 0;

        public Character(StatusEffect statusEffect, int _hp, int _attack, int _defence, string _name = "Unknown")
        {
            this.statusEffect = statusEffect;
            this.hp = _hp;
            this.attack = _attack;
            this.defence = _defence;
            this.name = $"{_name}#{instanceCount++}";
            this.inventory = new List<StatusEffectDecorator>(3); // allocate 3 slots for armament, shield, and armor
        }

        public override int HPeffect()
        {
            int newHP = statusEffect.HPeffect() + hp; // the initial hp of the character

            return newHP;
        }

        public override int AttackEffect()
        {
            int newAttack = statusEffect.AttackEffect() + attack; // the initial attack of the character

            return newAttack;
        }

        public override int DefenceEffect()
        {
            int newDefence = statusEffect.DefenceEffect() + defence; // the initial defence of the character

            return newDefence;
        }

        public void EquipItem(StatusEffectDecorator item)
        {
            if (item is Armament)
            {
                Remove<Armament>();
            }
            else if (item is Shield)
            {
                Remove<Shield>();
            }
            else if (item is Armor)
            {
                Remove<Armor>();
            }
            else
            {
                Console.WriteLine("Error! Invalid players decoration type.");
            }

            inventory.Add(item);
            ApplyEffects(item);
        }

        public void Remove<T>() where T : StatusEffectDecorator
        {
            var removedItem = inventory.OfType<T>().FirstOrDefault();
            if (removedItem != null)
            {
                inventory.Remove(removedItem);
                EffectsReversed(removedItem);
            }
        }

        private void ApplyEffects(StatusEffectDecorator item)
        {
            hp += item.HPeffect();
            attack += item.AttackEffect();
            defence += item.DefenceEffect();
        }

        private void EffectsReversed(StatusEffectDecorator item)
        {
            hp -= item.HPeffect();
            attack -= item.AttackEffect();
            defence -= item.DefenceEffect();
        }

        public override string ToString()
        {
            return $"{name} [ HP: {this.HPeffect()}; Attack: {this.AttackEffect()}; Defense: {this.DefenceEffect()}; ]";
        }
    }

    public class Human : Character
    {
        public Human() : base(new PlayerBaseStatus(), 100, 10, 0, "Human")
        {

        }
    }

    public class Troll : Character
    {
        public Troll() : base(new PlayerBaseStatus(), 180, 20, 10, "Troll")
        {

        }
    }

    public class Orc : Character
    {
        public Orc() : base(new PlayerBaseStatus(), 240, 35, 20, "Orc")
        {

        }
    }

    public class CharacterList : IList<Character>
    {
        private List<Character> characterList = new List<Character>();

        public int Count
        {
            get { return characterList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public Character this[int index]
        {
            get { return characterList[index]; }
            set { characterList[index] = value; }
        }

        public void FillBaseCharacters()
        {
            Add(new Human());
            Add(new Troll());
            Add(new Orc());
        }

        public List<Character> GetBy(Func<Character, bool> suitableCharacter)
        {
            return characterList.Where(suitableCharacter).ToList();
        }

        public int IndexOf(Character item)
        {
            return characterList.IndexOf(item);
        }

        public void Insert(int index, Character item)
        {
            characterList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            characterList.RemoveAt(index);
        }

        public void Add(Character item)
        {
            characterList.Add(item);
        }

        public void Clear()
        {
            characterList.Clear();
        }

        public bool Contains(Character item)
        {
            return characterList.Contains(item);
        }

        public void CopyTo(Character[] array, int arrayIndex)
        {
            characterList.CopyTo(array, arrayIndex);
        }

        public bool Remove(Character item)
        {
            return characterList.Remove(item);
        }

        public IEnumerator<Character> GetEnumerator()
        {
            return characterList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return characterList.GetEnumerator();
        }

        public void Sort(Comparison<Character> comparator)
        {
            characterList.Sort(comparator);
        }

    }

}
