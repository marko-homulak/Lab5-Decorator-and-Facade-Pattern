namespace lab5
{
    partial class EditCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.armament_comboBox = new System.Windows.Forms.ComboBox();
            this.shield_comboBox = new System.Windows.Forms.ComboBox();
            this.armor_comboBox = new System.Windows.Forms.ComboBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.armament_label = new System.Windows.Forms.Label();
            this.shield_label = new System.Windows.Forms.Label();
            this.armor_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.character_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // armament_comboBox
            // 
            this.armament_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.armament_comboBox.FormattingEnabled = true;
            this.armament_comboBox.Items.AddRange(new object[] {
            "",
            "Bow",
            "Sword",
            "Mace",
            "Daggers",
            "Hatchet"});
            this.armament_comboBox.Location = new System.Drawing.Point(123, 140);
            this.armament_comboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.armament_comboBox.Name = "armament_comboBox";
            this.armament_comboBox.Size = new System.Drawing.Size(160, 28);
            this.armament_comboBox.TabIndex = 10;
            // 
            // shield_comboBox
            // 
            this.shield_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shield_comboBox.FormattingEnabled = true;
            this.shield_comboBox.Items.AddRange(new object[] {
            "",
            "Wooden Shield",
            "Iron Shield"});
            this.shield_comboBox.Location = new System.Drawing.Point(123, 99);
            this.shield_comboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.shield_comboBox.Name = "shield_comboBox";
            this.shield_comboBox.Size = new System.Drawing.Size(160, 28);
            this.shield_comboBox.TabIndex = 11;
            // 
            // armor_comboBox
            // 
            this.armor_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.armor_comboBox.FormattingEnabled = true;
            this.armor_comboBox.Items.AddRange(new object[] {
            "",
            "Leather Armor",
            "Chain Mail Armor",
            "Knight\'s Armor",
            "Holy Armor"});
            this.armor_comboBox.Location = new System.Drawing.Point(123, 58);
            this.armor_comboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.armor_comboBox.Name = "armor_comboBox";
            this.armor_comboBox.Size = new System.Drawing.Size(160, 28);
            this.armor_comboBox.TabIndex = 12;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.LightPink;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(163, 176);
            this.close_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(120, 40);
            this.close_btn.TabIndex = 8;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.LightPink;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.Location = new System.Drawing.Point(23, 176);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(120, 40);
            this.edit_btn.TabIndex = 9;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // armament_label
            // 
            this.armament_label.AutoSize = true;
            this.armament_label.Location = new System.Drawing.Point(19, 141);
            this.armament_label.Margin = new System.Windows.Forms.Padding(10);
            this.armament_label.Name = "armament_label";
            this.armament_label.Size = new System.Drawing.Size(89, 20);
            this.armament_label.TabIndex = 4;
            this.armament_label.Text = "Armament:";
            // 
            // shield_label
            // 
            this.shield_label.AutoSize = true;
            this.shield_label.Location = new System.Drawing.Point(19, 101);
            this.shield_label.Margin = new System.Windows.Forms.Padding(10);
            this.shield_label.Name = "shield_label";
            this.shield_label.Size = new System.Drawing.Size(57, 20);
            this.shield_label.TabIndex = 5;
            this.shield_label.Text = "Shield:";
            // 
            // armor_label
            // 
            this.armor_label.AutoSize = true;
            this.armor_label.Location = new System.Drawing.Point(19, 61);
            this.armor_label.Margin = new System.Windows.Forms.Padding(10);
            this.armor_label.Name = "armor_label";
            this.armor_label.Size = new System.Drawing.Size(60, 20);
            this.armor_label.TabIndex = 6;
            this.armor_label.Text = "Armor:";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(19, 21);
            this.type_label.Margin = new System.Windows.Forms.Padding(10);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(50, 20);
            this.type_label.TabIndex = 7;
            this.type_label.Text = "Type:";
            // 
            // character_label
            // 
            this.character_label.AutoSize = true;
            this.character_label.ForeColor = System.Drawing.Color.Red;
            this.character_label.Location = new System.Drawing.Point(119, 21);
            this.character_label.Margin = new System.Windows.Forms.Padding(10);
            this.character_label.Name = "character_label";
            this.character_label.Size = new System.Drawing.Size(0, 20);
            this.character_label.TabIndex = 13;
            // 
            // EditCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(302, 233);
            this.Controls.Add(this.character_label);
            this.Controls.Add(this.armament_comboBox);
            this.Controls.Add(this.shield_comboBox);
            this.Controls.Add(this.armor_comboBox);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.armament_label);
            this.Controls.Add(this.shield_label);
            this.Controls.Add(this.armor_label);
            this.Controls.Add(this.type_label);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox armament_comboBox;
        private System.Windows.Forms.ComboBox shield_comboBox;
        private System.Windows.Forms.ComboBox armor_comboBox;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label armament_label;
        private System.Windows.Forms.Label shield_label;
        private System.Windows.Forms.Label armor_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label character_label;
    }
}