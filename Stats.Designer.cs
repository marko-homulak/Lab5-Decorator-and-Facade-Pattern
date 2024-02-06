namespace lab5
{
    partial class Stats
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
            this.name_label = new System.Windows.Forms.Label();
            this.nameValue_label = new System.Windows.Forms.Label();
            this.character_pictureBox = new System.Windows.Forms.PictureBox();
            this.armor_pictureBox = new System.Windows.Forms.PictureBox();
            this.shield_pictureBox = new System.Windows.Forms.PictureBox();
            this.armament_pictureBox = new System.Windows.Forms.PictureBox();
            this.armorHP_label = new System.Windows.Forms.Label();
            this.armorDP_label = new System.Windows.Forms.Label();
            this.shieldHP_label = new System.Windows.Forms.Label();
            this.stats_panel = new System.Windows.Forms.Panel();
            this.DP_progressBar = new System.Windows.Forms.ProgressBar();
            this.DP_label = new System.Windows.Forms.Label();
            this.AP_progressBar = new System.Windows.Forms.ProgressBar();
            this.HP_progressBar = new System.Windows.Forms.ProgressBar();
            this.AP_label = new System.Windows.Forms.Label();
            this.HP_label = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.fightWith_btn = new System.Windows.Forms.Button();
            this.enemy_comboBox = new System.Windows.Forms.ComboBox();
            this.shieldDP_label = new System.Windows.Forms.Label();
            this.armamentAP_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.character_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armor_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armament_pictureBox)).BeginInit();
            this.stats_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(19, 19);
            this.name_label.Margin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(56, 20);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name:";
            // 
            // nameValue_label
            // 
            this.nameValue_label.AutoSize = true;
            this.nameValue_label.ForeColor = System.Drawing.Color.Brown;
            this.nameValue_label.Location = new System.Drawing.Point(79, 19);
            this.nameValue_label.Margin = new System.Windows.Forms.Padding(2, 10, 10, 10);
            this.nameValue_label.Name = "nameValue_label";
            this.nameValue_label.Size = new System.Drawing.Size(0, 20);
            this.nameValue_label.TabIndex = 3;
            // 
            // character_pictureBox
            // 
            this.character_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.character_pictureBox.Location = new System.Drawing.Point(23, 52);
            this.character_pictureBox.Name = "character_pictureBox";
            this.character_pictureBox.Size = new System.Drawing.Size(190, 265);
            this.character_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character_pictureBox.TabIndex = 4;
            this.character_pictureBox.TabStop = false;
            // 
            // armor_pictureBox
            // 
            this.armor_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.armor_pictureBox.Location = new System.Drawing.Point(226, 52);
            this.armor_pictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.armor_pictureBox.Name = "armor_pictureBox";
            this.armor_pictureBox.Size = new System.Drawing.Size(75, 75);
            this.armor_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.armor_pictureBox.TabIndex = 5;
            this.armor_pictureBox.TabStop = false;
            // 
            // shield_pictureBox
            // 
            this.shield_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.shield_pictureBox.Location = new System.Drawing.Point(226, 147);
            this.shield_pictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.shield_pictureBox.Name = "shield_pictureBox";
            this.shield_pictureBox.Size = new System.Drawing.Size(75, 75);
            this.shield_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shield_pictureBox.TabIndex = 5;
            this.shield_pictureBox.TabStop = false;
            // 
            // armament_pictureBox
            // 
            this.armament_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.armament_pictureBox.Location = new System.Drawing.Point(226, 242);
            this.armament_pictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.armament_pictureBox.Name = "armament_pictureBox";
            this.armament_pictureBox.Size = new System.Drawing.Size(75, 75);
            this.armament_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.armament_pictureBox.TabIndex = 5;
            this.armament_pictureBox.TabStop = false;
            // 
            // armorHP_label
            // 
            this.armorHP_label.AutoSize = true;
            this.armorHP_label.ForeColor = System.Drawing.Color.Brown;
            this.armorHP_label.Location = new System.Drawing.Point(311, 52);
            this.armorHP_label.Margin = new System.Windows.Forms.Padding(0, 65, 2, 10);
            this.armorHP_label.Name = "armorHP_label";
            this.armorHP_label.Size = new System.Drawing.Size(0, 20);
            this.armorHP_label.TabIndex = 3;
            // 
            // armorDP_label
            // 
            this.armorDP_label.AutoSize = true;
            this.armorDP_label.ForeColor = System.Drawing.Color.Brown;
            this.armorDP_label.Location = new System.Drawing.Point(311, 87);
            this.armorDP_label.Margin = new System.Windows.Forms.Padding(0, 5, 2, 10);
            this.armorDP_label.Name = "armorDP_label";
            this.armorDP_label.Size = new System.Drawing.Size(0, 20);
            this.armorDP_label.TabIndex = 3;
            // 
            // shieldHP_label
            // 
            this.shieldHP_label.AutoSize = true;
            this.shieldHP_label.ForeColor = System.Drawing.Color.Brown;
            this.shieldHP_label.Location = new System.Drawing.Point(311, 147);
            this.shieldHP_label.Margin = new System.Windows.Forms.Padding(0, 65, 2, 10);
            this.shieldHP_label.Name = "shieldHP_label";
            this.shieldHP_label.Size = new System.Drawing.Size(0, 20);
            this.shieldHP_label.TabIndex = 3;
            // 
            // stats_panel
            // 
            this.stats_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stats_panel.Controls.Add(this.DP_progressBar);
            this.stats_panel.Controls.Add(this.DP_label);
            this.stats_panel.Controls.Add(this.AP_progressBar);
            this.stats_panel.Controls.Add(this.HP_progressBar);
            this.stats_panel.Controls.Add(this.AP_label);
            this.stats_panel.Controls.Add(this.HP_label);
            this.stats_panel.Location = new System.Drawing.Point(23, 330);
            this.stats_panel.Margin = new System.Windows.Forms.Padding(10);
            this.stats_panel.Name = "stats_panel";
            this.stats_panel.Size = new System.Drawing.Size(278, 110);
            this.stats_panel.TabIndex = 6;
            // 
            // DP_progressBar
            // 
            this.DP_progressBar.ForeColor = System.Drawing.Color.Brown;
            this.DP_progressBar.Location = new System.Drawing.Point(84, 78);
            this.DP_progressBar.Margin = new System.Windows.Forms.Padding(10);
            this.DP_progressBar.Maximum = 150;
            this.DP_progressBar.Name = "DP_progressBar";
            this.DP_progressBar.Size = new System.Drawing.Size(180, 14);
            this.DP_progressBar.TabIndex = 6;
            // 
            // DP_label
            // 
            this.DP_label.AutoSize = true;
            this.DP_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DP_label.ForeColor = System.Drawing.Color.Yellow;
            this.DP_label.Location = new System.Drawing.Point(10, 78);
            this.DP_label.Margin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.DP_label.Name = "DP_label";
            this.DP_label.Size = new System.Drawing.Size(33, 17);
            this.DP_label.TabIndex = 5;
            this.DP_label.Text = "DP:";
            // 
            // AP_progressBar
            // 
            this.AP_progressBar.ForeColor = System.Drawing.Color.Brown;
            this.AP_progressBar.Location = new System.Drawing.Point(85, 44);
            this.AP_progressBar.Margin = new System.Windows.Forms.Padding(10);
            this.AP_progressBar.Name = "AP_progressBar";
            this.AP_progressBar.Size = new System.Drawing.Size(180, 14);
            this.AP_progressBar.TabIndex = 4;
            // 
            // HP_progressBar
            // 
            this.HP_progressBar.ForeColor = System.Drawing.Color.Brown;
            this.HP_progressBar.Location = new System.Drawing.Point(85, 10);
            this.HP_progressBar.Margin = new System.Windows.Forms.Padding(10);
            this.HP_progressBar.Maximum = 500;
            this.HP_progressBar.Name = "HP_progressBar";
            this.HP_progressBar.Size = new System.Drawing.Size(180, 14);
            this.HP_progressBar.TabIndex = 4;
            // 
            // AP_label
            // 
            this.AP_label.AutoSize = true;
            this.AP_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AP_label.ForeColor = System.Drawing.Color.Blue;
            this.AP_label.Location = new System.Drawing.Point(11, 44);
            this.AP_label.Margin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.AP_label.Name = "AP_label";
            this.AP_label.Size = new System.Drawing.Size(33, 17);
            this.AP_label.TabIndex = 3;
            this.AP_label.Text = "AP:";
            // 
            // HP_label
            // 
            this.HP_label.AutoSize = true;
            this.HP_label.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HP_label.ForeColor = System.Drawing.Color.Red;
            this.HP_label.Location = new System.Drawing.Point(10, 10);
            this.HP_label.Margin = new System.Windows.Forms.Padding(10, 10, 2, 10);
            this.HP_label.Name = "HP_label";
            this.HP_label.Size = new System.Drawing.Size(34, 17);
            this.HP_label.TabIndex = 3;
            this.HP_label.Text = "HP:";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.LightPink;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(263, 453);
            this.close_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(100, 40);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click_1);
            // 
            // fightWith_btn
            // 
            this.fightWith_btn.BackColor = System.Drawing.Color.LightPink;
            this.fightWith_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fightWith_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fightWith_btn.Location = new System.Drawing.Point(143, 453);
            this.fightWith_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.fightWith_btn.Name = "fightWith_btn";
            this.fightWith_btn.Size = new System.Drawing.Size(100, 40);
            this.fightWith_btn.TabIndex = 7;
            this.fightWith_btn.Text = "Fight ";
            this.fightWith_btn.UseVisualStyleBackColor = false;
            this.fightWith_btn.Click += new System.EventHandler(this.fightWith_btn_Click);
            // 
            // enemy_comboBox
            // 
            this.enemy_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemy_comboBox.FormattingEnabled = true;
            this.enemy_comboBox.Location = new System.Drawing.Point(23, 460);
            this.enemy_comboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.enemy_comboBox.Name = "enemy_comboBox";
            this.enemy_comboBox.Size = new System.Drawing.Size(107, 28);
            this.enemy_comboBox.TabIndex = 14;
            this.enemy_comboBox.SelectedIndexChanged += new System.EventHandler(this.enemy_comboBox_SelectedIndexChanged);
            // 
            // shieldDP_label
            // 
            this.shieldDP_label.AutoSize = true;
            this.shieldDP_label.ForeColor = System.Drawing.Color.Brown;
            this.shieldDP_label.Location = new System.Drawing.Point(311, 182);
            this.shieldDP_label.Margin = new System.Windows.Forms.Padding(0, 5, 2, 10);
            this.shieldDP_label.Name = "shieldDP_label";
            this.shieldDP_label.Size = new System.Drawing.Size(0, 20);
            this.shieldDP_label.TabIndex = 15;
            // 
            // armamentAP_label
            // 
            this.armamentAP_label.AutoSize = true;
            this.armamentAP_label.ForeColor = System.Drawing.Color.Brown;
            this.armamentAP_label.Location = new System.Drawing.Point(311, 242);
            this.armamentAP_label.Margin = new System.Windows.Forms.Padding(0, 5, 2, 10);
            this.armamentAP_label.Name = "armamentAP_label";
            this.armamentAP_label.Size = new System.Drawing.Size(0, 20);
            this.armamentAP_label.TabIndex = 16;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(382, 513);
            this.Controls.Add(this.armamentAP_label);
            this.Controls.Add(this.shieldDP_label);
            this.Controls.Add(this.enemy_comboBox);
            this.Controls.Add(this.fightWith_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.stats_panel);
            this.Controls.Add(this.armament_pictureBox);
            this.Controls.Add(this.shield_pictureBox);
            this.Controls.Add(this.armor_pictureBox);
            this.Controls.Add(this.character_pictureBox);
            this.Controls.Add(this.nameValue_label);
            this.Controls.Add(this.shieldHP_label);
            this.Controls.Add(this.armorDP_label);
            this.Controls.Add(this.armorHP_label);
            this.Controls.Add(this.name_label);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)(this.character_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armor_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shield_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armament_pictureBox)).EndInit();
            this.stats_panel.ResumeLayout(false);
            this.stats_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label nameValue_label;
        private System.Windows.Forms.PictureBox character_pictureBox;
        private System.Windows.Forms.PictureBox armor_pictureBox;
        private System.Windows.Forms.PictureBox shield_pictureBox;
        private System.Windows.Forms.PictureBox armament_pictureBox;
        private System.Windows.Forms.Label armorHP_label;
        private System.Windows.Forms.Label armorDP_label;
        private System.Windows.Forms.Label shieldHP_label;
        private System.Windows.Forms.Panel stats_panel;
        private System.Windows.Forms.Label AP_label;
        private System.Windows.Forms.Label HP_label;
        private System.Windows.Forms.ProgressBar HP_progressBar;
        private System.Windows.Forms.ProgressBar AP_progressBar;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button fightWith_btn;
        private System.Windows.Forms.ComboBox enemy_comboBox;
        private System.Windows.Forms.ProgressBar DP_progressBar;
        private System.Windows.Forms.Label DP_label;
        private System.Windows.Forms.Label shieldDP_label;
        private System.Windows.Forms.Label armamentAP_label;
    }
}