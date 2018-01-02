namespace UserInterface
{
    partial class HomeWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWindows));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.Showall = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.About_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInfoButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.about,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1180, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Delete,
            this.Edit,
            this.Search,
            this.Showall,
            this.Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.fileToolStripMenuItem.Text = "Home";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save.Size = new System.Drawing.Size(163, 22);
            this.Save.Text = "Add";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.Delete.Size = new System.Drawing.Size(163, 22);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Edit.Size = new System.Drawing.Size(163, 22);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Search.Size = new System.Drawing.Size(163, 22);
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Showall
            // 
            this.Showall.Name = "Showall";
            this.Showall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.Showall.Size = new System.Drawing.Size(163, 22);
            this.Showall.Text = "Show All";
            this.Showall.Click += new System.EventHandler(this.Showall_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Exit.Size = new System.Drawing.Size(163, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_1});
            this.about.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(52, 19);
            this.about.Text = "About";
            // 
            // About_1
            // 
            this.About_1.Name = "About_1";
            this.About_1.Size = new System.Drawing.Size(158, 22);
            this.About_1.Text = "About.................";
            this.About_1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // addInfoButton
            // 
            this.addInfoButton.BackColor = System.Drawing.Color.DarkViolet;
            this.addInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInfoButton.ForeColor = System.Drawing.Color.SpringGreen;
            this.addInfoButton.Location = new System.Drawing.Point(1010, 411);
            this.addInfoButton.Name = "addInfoButton";
            this.addInfoButton.Size = new System.Drawing.Size(155, 52);
            this.addInfoButton.TabIndex = 1;
            this.addInfoButton.Text = "ADD";
            this.addInfoButton.UseVisualStyleBackColor = false;
            this.addInfoButton.Click += new System.EventHandler(this.addInfoButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkGreen;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Crimson;
            this.deleteButton.Location = new System.Drawing.Point(1010, 128);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 52);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Tag = "";
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.DarkCyan;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.editButton.Location = new System.Drawing.Point(1010, 52);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(155, 51);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1010, 218);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 46);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkRed;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(1010, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "SHOW ALL";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Show_all_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.DeepPink;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(1010, 511);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(155, 58);
            this.Exit_button.TabIndex = 7;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 73);
            this.label2.TabIndex = 8;
            this.label2.Text = "Khulna University";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(764, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Computer Science and Engineering Discipline";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::UserInterface.Properties.Resources.Untitled;
            this.pictureBox.Location = new System.Drawing.Point(486, 128);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(69, 97);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(274, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(501, 42);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Information System";
            // 
            // HomeWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1180, 607);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addInfoButton);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeWindows";
            this.Text = "Student Information System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem Showall;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.Button addInfoButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.ToolStripMenuItem About_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

