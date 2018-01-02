namespace UserInterface
{
    partial class Add_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Windows));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.CGPABox = new System.Windows.Forms.TextBox();
            this.addNewButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(176, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(176, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID : ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Turquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(176, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Year :";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(176, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "CGPA :";
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(422, 344);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(379, 26);
            this.NameBox.TabIndex = 4;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // IdBox
            // 
            this.IdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(422, 420);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(379, 26);
            this.IdBox.TabIndex = 5;
            // 
            // CGPABox
            // 
            this.CGPABox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CGPABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CGPABox.Location = new System.Drawing.Point(422, 554);
            this.CGPABox.Name = "CGPABox";
            this.CGPABox.Size = new System.Drawing.Size(379, 26);
            this.CGPABox.TabIndex = 7;
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.Location = new System.Drawing.Point(305, 605);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(134, 45);
            this.addNewButton.TabIndex = 9;
            this.addNewButton.Text = "Again Save";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.AgainAdd_Button_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Violet;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(549, 605);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 45);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // YearComboBox
            // 
            this.YearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.YearComboBox.Location = new System.Drawing.Point(422, 482);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(379, 28);
            this.YearComboBox.TabIndex = 10;
            this.YearComboBox.Text = "Please Select Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Chartreuse;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(432, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(415, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Khulna University";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Chartreuse;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(602, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "Computer Science and Engineering discipline";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UserInterface.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(532, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 96);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.SpringGreen;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(33, 22);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(168, 44);
            this.Back_button.TabIndex = 16;
            this.Back_button.Text = "Back To Home";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Add_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1049, 735);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.CGPABox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Windows";
            this.Text = "AddWindows";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox CGPABox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back_button;
    }
}