using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class AddCharacter : Form
    {
        private BindingList<Character> characters;

        public AddCharacter(BindingList<Character> characters)
        {
            InitializeComponent();
            this.characters = characters;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (type_comboBox.Text != "")
            {
                string type = type_comboBox.Text;
                string armor = armor_comboBox.Text;
                string shield = shield_comboBox.Text;
                string armament = armament_comboBox.Text;

                Character character;

                switch (type)
                {
                    case "Human":
                        character = new Human();
                        break;
                    case "Troll":
                        character = new Troll();
                        break;
                    case "Orc":
                        character = new Orc();
                        break;
                    default:
                        MessageBox.Show("Invalid type selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                if (armor != "")
                {
                    var newArmor = AddArmor(armor);
                    character.EquipItem(newArmor);
                }

                if (shield != "")
                {
                    var newShield = AddShield(shield);
                    character.EquipItem(newShield);
                }

                if (armament != "")
                {
                    var newArmament = AddArmament(armament);
                    character.EquipItem(newArmament);
                }

                characters.Add(character);
                Close();
            }
            else
            {
                MessageBox.Show("Select a character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Armor AddArmor(string armorType)
        {
            /* Initialize armor */
            LeatherArmor leatherArmor = new LeatherArmor(new PlayerBaseStatus());
            ChainMailArmor chainMailArmor = new ChainMailArmor(new PlayerBaseStatus());
            KnightsArmor knightsArmor = new KnightsArmor(new PlayerBaseStatus());
            HolyArmor holyArmor = new HolyArmor(new PlayerBaseStatus());
            /* ---------------- */

            switch (armorType)
            {
                case "Leather Armor":
                    return leatherArmor;
                case "Chain Mail Armor":
                    return chainMailArmor;
                case "Knight's Armor":
                    return knightsArmor;
                case "Holy Armor":
                    return holyArmor;
                default:
                    MessageBox.Show("Invalid type selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        public static Shield AddShield(string shieldType)
        { 
            /* Initialize shields */
            Shield woodenShield = new WoodenShield(new PlayerBaseStatus());
            Shield ironShield = new IronShield(new PlayerBaseStatus());
            /* ------------------ */

            switch (shieldType)
            {
                case "Wooden Shield":
                    return woodenShield;
                case "Iron Shield":
                    return ironShield;
                default:
                    MessageBox.Show("Invalid type selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        public static Armament AddArmament(string armamentType)
        {
            /* Initialize armament */
            Sword sword = new Sword(new PlayerBaseStatus());
            Bow bow = new Bow(new PlayerBaseStatus());
            Daggers daggers = new Daggers(new PlayerBaseStatus());
            Mace mace = new Mace(new PlayerBaseStatus());
            Hatchet hatchet = new Hatchet(new PlayerBaseStatus());
            /* ------------------- */

            switch (armamentType)
            {
                case "Bow":
                    return bow;
                case "Sword":
                    return sword;
                case "Mace":
                    return mace;
                case "Daggers":
                    return daggers;
                case "Hatchet":
                    return hatchet;
                default:
                    MessageBox.Show("Invalid type selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
