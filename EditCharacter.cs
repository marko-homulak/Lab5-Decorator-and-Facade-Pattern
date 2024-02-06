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
    public partial class EditCharacter : Form
    {
        private Character editedCharacter;

        private int index;

        public delegate void CharacterEditedEventHandler(object sender, Character character, int index);

        public event CharacterEditedEventHandler CharacterEdited;

        public EditCharacter(Character character, int index)
        {
            InitializeComponent();

            this.index = index;

            editedCharacter = character;

            SetComboBoxValues(character);
        }

        private Armor FindArmorInInventory()
        {
            foreach (var item in editedCharacter.inventory)
            {
                if (item is Armor armor)
                {
                    return armor;
                }
            }
            return null;
        }

        private Shield FindShieldInInventory()
        {
            foreach (var item in editedCharacter.inventory)
            {
                if (item is Shield shield)
                {
                    return shield;
                }
            }
            return null;
        }

        private Armament FindArmamentInInventory()
        {
            foreach (var item in editedCharacter.inventory)
            {
                if (item is Armament armament)
                {
                    return armament;
                }
            }
            return null;
        }

        private void SetComboBoxValues(Character character)
        {
            switch (character)
            {
                case Human human:
                    character_label.Text = "Human";
                    SetArmorComboBoxValues();
                    SetShieldComboBoxValues();
                    SetArmamentComboBoxValues();
                    break;
                case Troll troll:
                    character_label.Text = "Troll";
                    SetArmorComboBoxValues();
                    SetShieldComboBoxValues();
                    SetArmamentComboBoxValues();
                    break;
                case Orc orc:
                    character_label.Text = "Orc";
                    SetArmorComboBoxValues();
                    SetShieldComboBoxValues();
                    SetArmamentComboBoxValues();
                    break;
            }
        }

        private void SetArmorComboBoxValues()
        {
            var newArmor = FindArmorInInventory();

            if (newArmor == null)
            {
                armor_comboBox.SelectedIndex = -1;
                return;
            }

            switch (newArmor)
            {
                case LeatherArmor leatherArmor:
                    armor_comboBox.Text = "Leather Armor";
                    break;
                case ChainMailArmor chainMailArmor:
                    armor_comboBox.Text = "Chain Mail Armor";
                    break;
                case KnightsArmor knightsArmor:
                    armor_comboBox.Text = "Knight's Armor";
                    break;
                case HolyArmor holyArmor:
                    armor_comboBox.Text = "Holy Armor";
                    break;
            }
        }

        private void SetShieldComboBoxValues()
        {
            var newShield = FindShieldInInventory();

            if (newShield == null)
            {
                shield_comboBox.SelectedIndex = -1;
                return;
            }

            switch (newShield)
            {
                case WoodenShield woodenShield:
                    shield_comboBox.Text = "Wooden Shield";
                    break;
                case IronShield ironShield:
                    shield_comboBox.Text = "Iron Shield";
                    break;
            }
        }

        private void SetArmamentComboBoxValues()
        {
            var newArmament = FindArmamentInInventory();

            if (newArmament == null)
            {
                armament_comboBox.SelectedIndex = -1;
                return;
            }

            switch (newArmament)
            {
                case Bow bow:
                    armament_comboBox.Text = "Bow";
                    break;
                case Sword sword:
                    armament_comboBox.Text = "Sword";
                    break;
                case Mace mace:
                    armament_comboBox.Text = "Mace";
                    break;
                case Daggers daggers:
                    armament_comboBox.Text = "Daggers";
                    break;
                case Hatchet hatchet:
                    armament_comboBox.Text = "Hatchet";
                    break;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            SetEquipment();

            CharacterEdited?.Invoke(this, editedCharacter, index);
            Close();
        }

        private void SetEquipment()
        {
            string type = character_label.Text;
            string armor = armor_comboBox.Text;
            string shield = shield_comboBox.Text;
            string armament = armament_comboBox.Text;

            if (armor != "")
            {
                var newArmor = AddCharacter.AddArmor(armor);
                editedCharacter.EquipItem(newArmor);
            }
            else
            {
                editedCharacter.Remove<Armor>();
            }

            if (shield != "")
            {
                var newShield = AddCharacter.AddShield(shield);
                editedCharacter.EquipItem(newShield);
            }
            else
            {
                editedCharacter.Remove<Shield>();
            }

            if (armament != "")
            {
                var newArmament = AddCharacter.AddArmament(armament);
                editedCharacter.EquipItem(newArmament);
            }
            else
            {
                editedCharacter.Remove<Armament>();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
