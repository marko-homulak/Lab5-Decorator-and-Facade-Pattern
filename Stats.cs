using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab5
{
    public partial class Stats : Form
    {
        private Character character;

        private BindingList<Character> enemies;

        private int armorHP = 0;
        private int armorDP = 0;
        private int shieldHP = 0;
        private int shieldDP = 0;
        private int armamentAP = 0;

        public Stats(Character character, BindingList<Character> enemies)
        {
            InitializeComponent();
            this.character = character;
            this.enemies = enemies;

            SetCharacterStats();

            enemy_comboBox.DataSource = enemies;
            enemy_comboBox.DisplayMember = "Name";
            enemy_comboBox.SelectedIndex = -1;
        }

        private void SetCharacterStats()
        {
            nameValue_label.Text = character.name;

            SetCharacterImg();
            SetArmorImg();
            SetShieldImg();
            SetArmamentImg();

            SetStatsView();
        }

        private Armor FindArmorInInventory()
        {
            foreach (var item in character.inventory)
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
            foreach (var item in character.inventory)
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
            foreach (var item in character.inventory)
            {
                if (item is Armament armament)
                {
                    return armament;
                }
            }
            return null;
        }
        
        private void SetCharacterImg()
        {
            switch (character)
            {
                case Human human:
                    character_pictureBox.Image = Image.FromFile("../../assets/character/human.png");
                    break;
                case Troll troll:
                    character_pictureBox.Image = Image.FromFile("../../assets/character/troll.png");
                    break;
                case Orc orc:
                    character_pictureBox.Image = Image.FromFile("../../assets/character/orc.png");
                    break;
            }
        }

        private void SetArmorImg()
        {
            var armor = FindArmorInInventory();

            if (armor == null) return;               

            switch (armor)
            {
                case LeatherArmor leatherArmor:
                    armor_pictureBox.Image = Image.FromFile("../../assets/armor/leatherArmor.png");
                    armorHP = leatherArmor.HPeffect();
                    armorDP = leatherArmor.DefenceEffect();
                    break;
                case ChainMailArmor chainMailArmor:
                    armor_pictureBox.Image = Image.FromFile("../../assets/armor/chainMailArmor.png");
                    armorHP = chainMailArmor.HPeffect();
                    armorDP = chainMailArmor.DefenceEffect();
                    break;
                case KnightsArmor knightsArmor:
                    armor_pictureBox.Image = Image.FromFile("../../assets/armor/knightsArmor.png");
                    armorHP = knightsArmor.HPeffect();
                    armorDP = knightsArmor.DefenceEffect();
                    break;
                case HolyArmor holyArmor:
                    armor_pictureBox.Image = Image.FromFile("../../assets/armor/holyArmor.png");
                    armorHP = holyArmor.HPeffect();
                    armorDP = holyArmor.DefenceEffect();
                    break;
            }
        }       

        private void SetShieldImg()
        {
            var shield = FindShieldInInventory();

            if (shield == null) return;            

            switch (shield)
            {
                case WoodenShield woodenShield:
                    shield_pictureBox.Image = Image.FromFile("../../assets/shield/woodenShield.png");
                    shieldHP = woodenShield.HPeffect();
                    shieldDP = woodenShield.DefenceEffect();
                    break;
                case IronShield ironShield:
                    shield_pictureBox.Image = Image.FromFile("../../assets/shield/ironShield.png");
                    shieldHP = ironShield.HPeffect();
                    shieldDP = ironShield.DefenceEffect();
                    break;
            }
        }

        private void SetArmamentImg()
        {
            var armament = FindArmamentInInventory();

            if (armament == null) return;

            switch (armament)
            {
                case Bow bow:
                    armament_pictureBox.Image = Image.FromFile("../../assets/armament/bow.png");
                    armamentAP = bow.AttackEffect();
                    break;
                case Sword sword:
                    armament_pictureBox.Image = Image.FromFile("../../assets/armament/sword.png");
                    armamentAP = sword.AttackEffect();
                    break;
                case Mace mace:
                    armament_pictureBox.Image = Image.FromFile("../../assets/armament/mace.png");
                    armamentAP = mace.AttackEffect();
                    break;
                case Daggers daggers:
                    armament_pictureBox.Image = Image.FromFile("../../assets/armament/daggers.png");
                    armamentAP = daggers.AttackEffect();
                    break;
                case Hatchet hatchet:
                    armament_pictureBox.Image = Image.FromFile("../../assets/armament/hatchet.png");
                    armamentAP = hatchet.AttackEffect();
                    break;
            }
        }

        private void SetStatsView()
        {
            armorHP_label.Text = $"+{armorHP} HP";
            armorDP_label.Text = $"+{armorDP} DP";
            shieldHP_label.Text = $"+{shieldHP} HP";
            shieldDP_label.Text = $"+{shieldDP} DP";
            armamentAP_label.Text = $"+{armamentAP} AP";

            SetHpProgressBarValue(character.HPeffect());
            SetApProgressBarValue(character.AttackEffect());
            SetDpProgressBarValue(character.DefenceEffect());

            int hp = character.HPeffect();
            int ap = character.AttackEffect();
            int dp = character.DefenceEffect();

            HP_label.Text = $"HP: [{hp}]";
            AP_label.Text = $"AP: [{ap}]";
            DP_label.Text = $"DP: [{dp}]";
        }

        private void SetHpProgressBarValue(int value)
        {
            HP_progressBar.Value = value;
        }

        private void SetApProgressBarValue(int value)
        {
            AP_progressBar.Value = value;
        }

        private void SetDpProgressBarValue(int value)
        {
            DP_progressBar.Value = value;
        }

        private void enemy_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (enemy_comboBox.SelectedItem != null && enemy_comboBox.SelectedItem == character)
            {
                enemy_comboBox.SelectedIndex = -1;
            }
        }

        private void fightWith_btn_Click(object sender, EventArgs e)
        {
            if (enemy_comboBox.SelectedIndex != -1)
            {
                var enemy = (Character)enemy_comboBox.SelectedItem;
                CharacterFacade.DetermineWinner(character, enemy);
            }
            else
            {
                MessageBox.Show("Enemy don't selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
