namespace LearningCommonsLibraryApp
{
    partial class ManageUsers
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
            Mng_Users_FnTXT = new TextBox();
            Mng_Users_LnTXT = new TextBox();
            Mng_Users_EmlTXT = new TextBox();
            groupBox1 = new GroupBox();
            Mng_Users_ErrLBL = new Label();
            Mng_Users_AddBTN = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Mng_Users_StfRBTN = new RadioButton();
            Mng_Users_StdRBTN = new RadioButton();
            Mng_Users_SearchTXT = new TextBox();
            Mng_Users_LstVw = new ListView();
            Mng_Users_ExitBTN = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Mng_Users_FnTXT
            // 
            Mng_Users_FnTXT.Location = new Point(104, 78);
            Mng_Users_FnTXT.Name = "Mng_Users_FnTXT";
            Mng_Users_FnTXT.Size = new Size(100, 23);
            Mng_Users_FnTXT.TabIndex = 0;
            // 
            // Mng_Users_LnTXT
            // 
            Mng_Users_LnTXT.Location = new Point(104, 107);
            Mng_Users_LnTXT.Name = "Mng_Users_LnTXT";
            Mng_Users_LnTXT.Size = new Size(100, 23);
            Mng_Users_LnTXT.TabIndex = 2;
            // 
            // Mng_Users_EmlTXT
            // 
            Mng_Users_EmlTXT.Location = new Point(104, 136);
            Mng_Users_EmlTXT.Name = "Mng_Users_EmlTXT";
            Mng_Users_EmlTXT.Size = new Size(100, 23);
            Mng_Users_EmlTXT.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Mng_Users_ErrLBL);
            groupBox1.Controls.Add(Mng_Users_AddBTN);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Mng_Users_StfRBTN);
            groupBox1.Controls.Add(Mng_Users_StdRBTN);
            groupBox1.Controls.Add(Mng_Users_FnTXT);
            groupBox1.Controls.Add(Mng_Users_LnTXT);
            groupBox1.Controls.Add(Mng_Users_EmlTXT);
            groupBox1.Location = new Point(531, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 256);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add User";
            // 
            // Mng_Users_ErrLBL
            // 
            Mng_Users_ErrLBL.AutoSize = true;
            Mng_Users_ErrLBL.ForeColor = Color.Red;
            Mng_Users_ErrLBL.Location = new Point(55, 224);
            Mng_Users_ErrLBL.Name = "Mng_Users_ErrLBL";
            Mng_Users_ErrLBL.Size = new Size(145, 15);
            Mng_Users_ErrLBL.TabIndex = 10;
            Mng_Users_ErrLBL.Text = "*All fields must be filled in";
            // 
            // Mng_Users_AddBTN
            // 
            Mng_Users_AddBTN.BackColor = Color.PaleTurquoise;
            Mng_Users_AddBTN.Location = new Point(90, 186);
            Mng_Users_AddBTN.Name = "Mng_Users_AddBTN";
            Mng_Users_AddBTN.Size = new Size(75, 23);
            Mng_Users_AddBTN.TabIndex = 10;
            Mng_Users_AddBTN.Text = "Add user";
            Mng_Users_AddBTN.UseVisualStyleBackColor = false;
            Mng_Users_AddBTN.Click += Mng_Users_AddBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 139);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 110);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 12;
            label2.Text = "Lastname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 81);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Firstname:";
            // 
            // Mng_Users_StfRBTN
            // 
            Mng_Users_StfRBTN.AutoSize = true;
            Mng_Users_StfRBTN.Location = new Point(155, 36);
            Mng_Users_StfRBTN.Name = "Mng_Users_StfRBTN";
            Mng_Users_StfRBTN.Size = new Size(49, 19);
            Mng_Users_StfRBTN.TabIndex = 7;
            Mng_Users_StfRBTN.TabStop = true;
            Mng_Users_StfRBTN.Text = "Staff";
            Mng_Users_StfRBTN.UseVisualStyleBackColor = true;
            // 
            // Mng_Users_StdRBTN
            // 
            Mng_Users_StdRBTN.AutoSize = true;
            Mng_Users_StdRBTN.Location = new Point(55, 36);
            Mng_Users_StdRBTN.Name = "Mng_Users_StdRBTN";
            Mng_Users_StdRBTN.Size = new Size(66, 19);
            Mng_Users_StdRBTN.TabIndex = 6;
            Mng_Users_StdRBTN.TabStop = true;
            Mng_Users_StdRBTN.Text = "Student";
            Mng_Users_StdRBTN.UseVisualStyleBackColor = true;
            // 
            // Mng_Users_SearchTXT
            // 
            Mng_Users_SearchTXT.Location = new Point(166, 39);
            Mng_Users_SearchTXT.Name = "Mng_Users_SearchTXT";
            Mng_Users_SearchTXT.PlaceholderText = "Search by name";
            Mng_Users_SearchTXT.Size = new Size(162, 23);
            Mng_Users_SearchTXT.TabIndex = 7;
            Mng_Users_SearchTXT.TextChanged += textBox6_TextChanged;
            // 
            // Mng_Users_LstVw
            // 
            Mng_Users_LstVw.FullRowSelect = true;
            Mng_Users_LstVw.Location = new Point(27, 68);
            Mng_Users_LstVw.MultiSelect = false;
            Mng_Users_LstVw.Name = "Mng_Users_LstVw";
            Mng_Users_LstVw.Size = new Size(484, 267);
            Mng_Users_LstVw.TabIndex = 8;
            Mng_Users_LstVw.UseCompatibleStateImageBehavior = false;
            // 
            // Mng_Users_ExitBTN
            // 
            Mng_Users_ExitBTN.BackColor = Color.LightGreen;
            Mng_Users_ExitBTN.Location = new Point(339, 364);
            Mng_Users_ExitBTN.Name = "Mng_Users_ExitBTN";
            Mng_Users_ExitBTN.Size = new Size(117, 23);
            Mng_Users_ExitBTN.TabIndex = 9;
            Mng_Users_ExitBTN.Text = "Exit";
            Mng_Users_ExitBTN.UseVisualStyleBackColor = false;
            Mng_Users_ExitBTN.Click += Mng_Users_ExitBTN_Click;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mng_Users_ExitBTN);
            Controls.Add(Mng_Users_LstVw);
            Controls.Add(Mng_Users_SearchTXT);
            Controls.Add(groupBox1);
            Name = "ManageUsers";
            Text = "ManageUsers";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Mng_Users_FnTXT;
        private TextBox Mng_Users_LnTXT;
        private TextBox Mng_Users_EmlTXT;
        private GroupBox groupBox1;
        private RadioButton Mng_Users_StfRBTN;
        private RadioButton Mng_Users_StdRBTN;
        private TextBox Mng_Users_SearchTXT;
        private ListView Mng_Users_LstVw;
        private Button Mng_Users_ExitBTN;
        private Label Mng_Users_ErrLBL;
        private Button Mng_Users_AddBTN;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}