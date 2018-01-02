namespace UserInterface
{
    partial class DeleteWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteWindows));
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.reEnterButton = new System.Windows.Forms.Button();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(437, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student ID :";
            // 
            // deleteBox
            // 
            this.deleteBox.BackColor = System.Drawing.SystemColors.Window;
            this.deleteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBox.ForeColor = System.Drawing.Color.Crimson;
            this.deleteBox.Location = new System.Drawing.Point(402, 64);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(227, 26);
            this.deleteBox.TabIndex = 1;
            // 
            // reEnterButton
            // 
            this.reEnterButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.reEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnterButton.ForeColor = System.Drawing.Color.Cyan;
            this.reEnterButton.Location = new System.Drawing.Point(461, 163);
            this.reEnterButton.Name = "reEnterButton";
            this.reEnterButton.Size = new System.Drawing.Size(121, 41);
            this.reEnterButton.TabIndex = 3;
            this.reEnterButton.Text = "Again Delete";
            this.reEnterButton.UseVisualStyleBackColor = false;
            this.reEnterButton.Click += new System.EventHandler(this.Again_delete_Button_Click);
            // 
            // deleteButton2
            // 
            this.deleteButton2.BackColor = System.Drawing.Color.Tomato;
            this.deleteButton2.Enabled = false;
            this.deleteButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton2.Location = new System.Drawing.Point(623, 163);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(117, 41);
            this.deleteButton2.TabIndex = 2;
            this.deleteButton2.Text = "Delete";
            this.deleteButton2.UseVisualStyleBackColor = false;
            this.deleteButton2.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Turquoise;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Crimson;
            this.searchButton.Location = new System.Drawing.Point(309, 163);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 41);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.SpringGreen;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Crimson;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(159, 49);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back To Home";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DeleteWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(824, 311);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reEnterButton);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteWindows";
            this.Text = "Delete Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button reEnterButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button Back;
    }
}