namespace LearningCommonsLibraryApp
{
    partial class ManageLoans
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
            Loans_SearchTXT = new TextBox();
            Loans_RenewBTN = new Button();
            Loans_ReturnBTN = new Button();
            Loans_CheckOverduesBTN = new Button();
            Loans_ExitBTN = new Button();
            Loans_LstVw = new ListView();
            label1 = new Label();
            Loans_CheckDateLBL = new Label();
            Loans_Reset_LstVwBTN = new Button();
            SuspendLayout();
            // 
            // Loans_SearchTXT
            // 
            Loans_SearchTXT.Location = new Point(321, 28);
            Loans_SearchTXT.Name = "Loans_SearchTXT";
            Loans_SearchTXT.PlaceholderText = "Search by name.";
            Loans_SearchTXT.Size = new Size(160, 23);
            Loans_SearchTXT.TabIndex = 0;
            Loans_SearchTXT.TextChanged += Loans_SearchTXT_TextChanged;
            // 
            // Loans_RenewBTN
            // 
            Loans_RenewBTN.BackColor = Color.PaleTurquoise;
            Loans_RenewBTN.Location = new Point(165, 362);
            Loans_RenewBTN.Name = "Loans_RenewBTN";
            Loans_RenewBTN.Size = new Size(108, 23);
            Loans_RenewBTN.TabIndex = 2;
            Loans_RenewBTN.Text = "Renew";
            Loans_RenewBTN.UseVisualStyleBackColor = false;
            Loans_RenewBTN.Click += Loans_RenewBTN_Click;
            // 
            // Loans_ReturnBTN
            // 
            Loans_ReturnBTN.BackColor = Color.PaleTurquoise;
            Loans_ReturnBTN.Location = new Point(357, 362);
            Loans_ReturnBTN.Name = "Loans_ReturnBTN";
            Loans_ReturnBTN.Size = new Size(111, 23);
            Loans_ReturnBTN.TabIndex = 3;
            Loans_ReturnBTN.Text = "Return";
            Loans_ReturnBTN.UseVisualStyleBackColor = false;
            Loans_ReturnBTN.Click += Loans_ReturnBTN_Click;
            // 
            // Loans_CheckOverduesBTN
            // 
            Loans_CheckOverduesBTN.BackColor = Color.LightYellow;
            Loans_CheckOverduesBTN.Location = new Point(501, 362);
            Loans_CheckOverduesBTN.Name = "Loans_CheckOverduesBTN";
            Loans_CheckOverduesBTN.Size = new Size(102, 23);
            Loans_CheckOverduesBTN.TabIndex = 4;
            Loans_CheckOverduesBTN.Text = "Check Overdues";
            Loans_CheckOverduesBTN.UseVisualStyleBackColor = false;
            Loans_CheckOverduesBTN.Click += Loans_CheckOverduesBTN_Click;
            // 
            // Loans_ExitBTN
            // 
            Loans_ExitBTN.BackColor = Color.LightGreen;
            Loans_ExitBTN.Location = new Point(357, 404);
            Loans_ExitBTN.Name = "Loans_ExitBTN";
            Loans_ExitBTN.Size = new Size(111, 23);
            Loans_ExitBTN.TabIndex = 5;
            Loans_ExitBTN.Text = "Exit";
            Loans_ExitBTN.UseVisualStyleBackColor = false;
            Loans_ExitBTN.Click += Loans_ExitBTN_Click;
            // 
            // Loans_LstVw
            // 
            Loans_LstVw.FullRowSelect = true;
            Loans_LstVw.Location = new Point(78, 57);
            Loans_LstVw.MultiSelect = false;
            Loans_LstVw.Name = "Loans_LstVw";
            Loans_LstVw.Size = new Size(646, 283);
            Loans_LstVw.TabIndex = 6;
            Loans_LstVw.UseCompatibleStateImageBehavior = false;
            Loans_LstVw.SelectedIndexChanged += Loans_LstVw_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(611, 366);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 7;
            label1.Text = "Last Checked:";
            // 
            // Loans_CheckDateLBL
            // 
            Loans_CheckDateLBL.AutoSize = true;
            Loans_CheckDateLBL.Location = new Point(697, 366);
            Loans_CheckDateLBL.Name = "Loans_CheckDateLBL";
            Loans_CheckDateLBL.Size = new Size(0, 15);
            Loans_CheckDateLBL.TabIndex = 8;
            // 
            // Loans_Reset_LstVwBTN
            // 
            Loans_Reset_LstVwBTN.BackColor = Color.PaleTurquoise;
            Loans_Reset_LstVwBTN.Location = new Point(625, 27);
            Loans_Reset_LstVwBTN.Name = "Loans_Reset_LstVwBTN";
            Loans_Reset_LstVwBTN.Size = new Size(99, 23);
            Loans_Reset_LstVwBTN.TabIndex = 9;
            Loans_Reset_LstVwBTN.Text = "Reset ListView";
            Loans_Reset_LstVwBTN.UseVisualStyleBackColor = false;
            Loans_Reset_LstVwBTN.Click += Loans_Reset_LstVwBTN_Click;
            // 
            // ManageLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Loans_Reset_LstVwBTN);
            Controls.Add(Loans_CheckDateLBL);
            Controls.Add(label1);
            Controls.Add(Loans_LstVw);
            Controls.Add(Loans_ExitBTN);
            Controls.Add(Loans_CheckOverduesBTN);
            Controls.Add(Loans_ReturnBTN);
            Controls.Add(Loans_RenewBTN);
            Controls.Add(Loans_SearchTXT);
            Name = "ManageLoans";
            Text = "ManageLoans";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Loans_SearchTXT;
        private ListBox Loans_LstBx;
        private Button Loans_RenewBTN;
        private Button Loans_ReturnBTN;
        private Button Loans_CheckOverduesBTN;
        private Button Loans_ExitBTN;
        private ListView Loans_LstVw;
        private Label label1;
        private Label Loans_CheckDateLBL;
        private Button Loans_Reset_LstVwBTN;
    }
}