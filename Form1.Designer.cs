namespace lab5
{
    partial class Form1
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
            this.character_list = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.sortByHP_btn = new System.Windows.Forms.Button();
            this.viewStats_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // character_list
            // 
            this.character_list.BackColor = System.Drawing.Color.MediumAquamarine;
            this.character_list.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.character_list.ForeColor = System.Drawing.Color.Black;
            this.character_list.FormattingEnabled = true;
            this.character_list.ItemHeight = 20;
            this.character_list.Location = new System.Drawing.Point(13, 13);
            this.character_list.Margin = new System.Windows.Forms.Padding(4, 4, 10, 10);
            this.character_list.Name = "character_list";
            this.character_list.Size = new System.Drawing.Size(416, 364);
            this.character_list.TabIndex = 0;
            this.character_list.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.character_list_Format);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LightPink;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(449, 19);
            this.add_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 40);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add ";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.LightPink;
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_btn.Location = new System.Drawing.Point(449, 72);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(120, 40);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.LightPink;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.Location = new System.Drawing.Point(449, 125);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 40);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // sortByHP_btn
            // 
            this.sortByHP_btn.BackColor = System.Drawing.Color.LightPink;
            this.sortByHP_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortByHP_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByHP_btn.Location = new System.Drawing.Point(449, 178);
            this.sortByHP_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.sortByHP_btn.Name = "sortByHP_btn";
            this.sortByHP_btn.Size = new System.Drawing.Size(120, 40);
            this.sortByHP_btn.TabIndex = 1;
            this.sortByHP_btn.Text = "Sort by HP";
            this.sortByHP_btn.UseVisualStyleBackColor = false;
            this.sortByHP_btn.Click += new System.EventHandler(this.sortByHP_btn_Click);
            // 
            // viewStats_btn
            // 
            this.viewStats_btn.BackColor = System.Drawing.Color.LightPink;
            this.viewStats_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewStats_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewStats_btn.Location = new System.Drawing.Point(449, 231);
            this.viewStats_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.viewStats_btn.Name = "viewStats_btn";
            this.viewStats_btn.Size = new System.Drawing.Size(120, 40);
            this.viewStats_btn.TabIndex = 1;
            this.viewStats_btn.Text = "View Stats";
            this.viewStats_btn.UseVisualStyleBackColor = false;
            this.viewStats_btn.Click += new System.EventHandler(this.viewStats_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.LightPink;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_btn.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_btn.Location = new System.Drawing.Point(449, 337);
            this.close_btn.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(120, 40);
            this.close_btn.TabIndex = 1;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(592, 401);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.viewStats_btn);
            this.Controls.Add(this.sortByHP_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.character_list);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox character_list;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button sortByHP_btn;
        private System.Windows.Forms.Button viewStats_btn;
        private System.Windows.Forms.Button close_btn;
    }
}

