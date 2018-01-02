namespace UserInterface
{
    partial class SearchWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWindows));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.cgpaBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.reEnterButton = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID Nmuber : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Turquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Violet;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Year :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CGPA  :";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(425, 107);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(157, 26);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(313, 157);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(518, 26);
            this.nameBox.TabIndex = 6;
            // 
            // idBox
            // 
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(313, 224);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(518, 26);
            this.idBox.TabIndex = 7;
            // 
            // yearBox
            // 
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBox.Location = new System.Drawing.Point(313, 288);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(518, 26);
            this.yearBox.TabIndex = 8;
            // 
            // cgpaBox
            // 
            this.cgpaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cgpaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpaBox.Location = new System.Drawing.Point(313, 359);
            this.cgpaBox.Name = "cgpaBox";
            this.cgpaBox.Size = new System.Drawing.Size(518, 26);
            this.cgpaBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Chartreuse;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(688, 434);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 49);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reEnterButton
            // 
            this.reEnterButton.BackColor = System.Drawing.Color.Blue;
            this.reEnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnterButton.Location = new System.Drawing.Point(352, 434);
            this.reEnterButton.Name = "reEnterButton";
            this.reEnterButton.Size = new System.Drawing.Size(136, 49);
            this.reEnterButton.TabIndex = 11;
            this.reEnterButton.Text = "Again Search";
            this.reEnterButton.UseVisualStyleBackColor = false;
            this.reEnterButton.Click += new System.EventHandler(this.reEnterButton_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.SpringGreen;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(22, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(153, 49);
            this.Back_button.TabIndex = 12;
            this.Back_button.Text = "Back To Home";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Chartreuse;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(345, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student Information";
            // 
            // SearchWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(953, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.reEnterButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cgpaBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchWindows";
            this.Text = "Search Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox cgpaBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button reEnterButton;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label label6;
    }
}