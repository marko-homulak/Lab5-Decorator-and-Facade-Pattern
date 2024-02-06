using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab5
{
    public partial class Form1 : Form
    {
        private CharacterList basic;

        private BindingList<Character> characters;

        public Form1()
        {
            InitializeComponent();
            basic = new CharacterList();
            characters = new BindingList<Character>(basic);
            character_list.DataSource = characters;
        }

        private void updateData()
        {
            character_list.DataSource = null;
            character_list.DataSource = characters;
            character_list.ResetBindings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basic.FillBaseCharacters();
            updateData();
        }

        private void character_list_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = e.ListItem.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddCharacter addCharacter = new AddCharacter(characters);
            addCharacter.Show();
            updateData();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (character_list.SelectedItem != null)
            {
                Character selectedCharacter = (Character)character_list.SelectedItem;
                int selectedindex = character_list.SelectedIndex;

                EditCharacter editCharacter = new EditCharacter(selectedCharacter, selectedindex);
                editCharacter.CharacterEdited += EditCharacter_CharacterEdited;
                editCharacter.Show();
            }
            updateData();
        }

        private void EditCharacter_CharacterEdited(object sender, Character editCharacter, int index)
        {
            characters[index] = editCharacter;
            character_list.Refresh();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (character_list.SelectedItem != null)
            {
                var character = (Character)character_list.SelectedItem;
                basic.Remove(character);
                updateData();
            }
        }

        private void sortByHP_btn_Click(object sender, EventArgs e)
        {
            basic.Sort((o2, o1) => o1.HPeffect().CompareTo(o2.HPeffect()));
            updateData();
        }

        private void viewStats_btn_Click(object sender, EventArgs e)
        {
            if (character_list.SelectedItem != null)
            {
                var character = (Character)character_list.SelectedItem;
                Stats stats = new Stats(character, characters);
                stats.Show();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
