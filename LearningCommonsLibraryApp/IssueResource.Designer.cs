namespace LearningCommonsLibraryApp
{
    partial class IssueResource
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
            textBox2 = new TextBox();
            Iss_Res_IssBTN = new Button();
            Iss_Res_ResLstVw = new ListView();
            Iss_Res_BrrLstVw = new ListView();
            Iss_Res_BrrSearchTXT = new TextBox();
            groupBox1 = new GroupBox();
            Iss_Res_ResSearchTXT = new TextBox();
            groupBox2 = new GroupBox();
            Iss_Res_ExitBTN = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // Iss_Res_IssBTN
            // 
            Iss_Res_IssBTN.BackColor = Color.PaleTurquoise;
            Iss_Res_IssBTN.Location = new Point(425, 412);
            Iss_Res_IssBTN.Name = "Iss_Res_IssBTN";
            Iss_Res_IssBTN.Size = new Size(123, 23);
            Iss_Res_IssBTN.TabIndex = 4;
            Iss_Res_IssBTN.Text = "Issue";
            Iss_Res_IssBTN.UseVisualStyleBackColor = false;
            Iss_Res_IssBTN.Click += Iss_Res_IssBTN_Click;
            // 
            // Iss_Res_ResLstVw
            // 
            Iss_Res_ResLstVw.FullRowSelect = true;
            Iss_Res_ResLstVw.Location = new Point(6, 50);
            Iss_Res_ResLstVw.MultiSelect = false;
            Iss_Res_ResLstVw.Name = "Iss_Res_ResLstVw";
            Iss_Res_ResLstVw.Size = new Size(461, 317);
            Iss_Res_ResLstVw.TabIndex = 5;
            Iss_Res_ResLstVw.UseCompatibleStateImageBehavior = false;
            Iss_Res_ResLstVw.SelectedIndexChanged += Iss_Res_ResLstVw_SelectedIndexChanged;
            // 
            // Iss_Res_BrrLstVw
            // 
            Iss_Res_BrrLstVw.FullRowSelect = true;
            Iss_Res_BrrLstVw.Location = new Point(6, 50);
            Iss_Res_BrrLstVw.MultiSelect = false;
            Iss_Res_BrrLstVw.Name = "Iss_Res_BrrLstVw";
            Iss_Res_BrrLstVw.Size = new Size(406, 317);
            Iss_Res_BrrLstVw.TabIndex = 7;
            Iss_Res_BrrLstVw.UseCompatibleStateImageBehavior = false;
            Iss_Res_BrrLstVw.SelectedIndexChanged += Iss_Res_BrrLstVw_SelectedIndexChanged;
            // 
            // Iss_Res_BrrSearchTXT
            // 
            Iss_Res_BrrSearchTXT.Location = new Point(128, 21);
            Iss_Res_BrrSearchTXT.Name = "Iss_Res_BrrSearchTXT";
            Iss_Res_BrrSearchTXT.PlaceholderText = "Search by name";
            Iss_Res_BrrSearchTXT.Size = new Size(153, 23);
            Iss_Res_BrrSearchTXT.TabIndex = 6;
            Iss_Res_BrrSearchTXT.TextChanged += Iss_Res_BrrSearchTXT_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Iss_Res_ResSearchTXT);
            groupBox1.Controls.Add(Iss_Res_ResLstVw);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 373);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resources";
            // 
            // Iss_Res_ResSearchTXT
            // 
            Iss_Res_ResSearchTXT.Location = new Point(132, 21);
            Iss_Res_ResSearchTXT.Name = "Iss_Res_ResSearchTXT";
            Iss_Res_ResSearchTXT.PlaceholderText = "Search by title";
            Iss_Res_ResSearchTXT.Size = new Size(167, 23);
            Iss_Res_ResSearchTXT.TabIndex = 10;
            Iss_Res_ResSearchTXT.TextChanged += Iss_Res_ResSearchTXT_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Iss_Res_BrrLstVw);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(Iss_Res_BrrSearchTXT);
            groupBox2.Location = new Point(491, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 373);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borrower";
            // 
            // Iss_Res_ExitBTN
            // 
            Iss_Res_ExitBTN.BackColor = Color.LightGreen;
            Iss_Res_ExitBTN.ForeColor = SystemColors.ControlText;
            Iss_Res_ExitBTN.Location = new Point(449, 454);
            Iss_Res_ExitBTN.Name = "Iss_Res_ExitBTN";
            Iss_Res_ExitBTN.Size = new Size(75, 23);
            Iss_Res_ExitBTN.TabIndex = 10;
            Iss_Res_ExitBTN.Text = "Exit";
            Iss_Res_ExitBTN.UseVisualStyleBackColor = false;
            Iss_Res_ExitBTN.Click += Iss_Res_ExitBTN_Click;
            // 
            // IssueResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 508);
            Controls.Add(Iss_Res_ExitBTN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Iss_Res_IssBTN);
            Name = "IssueResource";
            Text = "IssueResource";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox2;
        private Button Iss_Res_IssBTN;
        private ListView Iss_Res_ResLstVw;
        private ListView Iss_Res_BrrLstVw;
        private TextBox Iss_Res_BrrSearchTXT;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox Iss_Res_ResSearchTXT;
        private Button Iss_Res_ExitBTN;
    }
}