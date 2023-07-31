namespace LearningCommonsLibraryApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Main_ExitBTN = new Button();
            Loans_PctBx = new PictureBox();
            Resources_PctBx = new PictureBox();
            Users_PctBx = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Issue_PctBx = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Loans_PctBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Resources_PctBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Users_PctBx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Issue_PctBx).BeginInit();
            SuspendLayout();
            // 
            // Main_ExitBTN
            // 
            Main_ExitBTN.BackColor = Color.LightGreen;
            Main_ExitBTN.Location = new Point(347, 368);
            Main_ExitBTN.Name = "Main_ExitBTN";
            Main_ExitBTN.Size = new Size(106, 23);
            Main_ExitBTN.TabIndex = 0;
            Main_ExitBTN.Text = "Exit";
            Main_ExitBTN.UseVisualStyleBackColor = false;
            Main_ExitBTN.Click += Main_ExitBTN_Click;
            // 
            // Loans_PctBx
            // 
            Loans_PctBx.BorderStyle = BorderStyle.Fixed3D;
            Loans_PctBx.Image = Properties.Resources.folder;
            Loans_PctBx.Location = new Point(235, 152);
            Loans_PctBx.Name = "Loans_PctBx";
            Loans_PctBx.Size = new Size(138, 139);
            Loans_PctBx.SizeMode = PictureBoxSizeMode.Zoom;
            Loans_PctBx.TabIndex = 1;
            Loans_PctBx.TabStop = false;
            Loans_PctBx.Click += Loans_PctBx_Click;
            // 
            // Resources_PctBx
            // 
            Resources_PctBx.BorderStyle = BorderStyle.Fixed3D;
            Resources_PctBx.Image = Properties.Resources.stack_of_books;
            Resources_PctBx.Location = new Point(425, 152);
            Resources_PctBx.Name = "Resources_PctBx";
            Resources_PctBx.Size = new Size(138, 139);
            Resources_PctBx.SizeMode = PictureBoxSizeMode.Zoom;
            Resources_PctBx.TabIndex = 2;
            Resources_PctBx.TabStop = false;
            Resources_PctBx.Click += Resources_PctBx_Click;
            // 
            // Users_PctBx
            // 
            Users_PctBx.BorderStyle = BorderStyle.Fixed3D;
            Users_PctBx.Image = Properties.Resources.users;
            Users_PctBx.Location = new Point(614, 152);
            Users_PctBx.Name = "Users_PctBx";
            Users_PctBx.Size = new Size(138, 139);
            Users_PctBx.SizeMode = PictureBoxSizeMode.Zoom;
            Users_PctBx.TabIndex = 3;
            Users_PctBx.TabStop = false;
            Users_PctBx.Click += Users_PctBx_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 294);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Manage Loans";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 294);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 5;
            label2.Text = "Manage Resources";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(643, 294);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Manage Users";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(165, 42);
            label4.Name = "label4";
            label4.Size = new Size(464, 52);
            label4.TabIndex = 7;
            label4.Text = "Learning Commons Library";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 294);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Issue";
            // 
            // Issue_PctBx
            // 
            Issue_PctBx.BorderStyle = BorderStyle.Fixed3D;
            Issue_PctBx.Image = Properties.Resources.barcode_scan;
            Issue_PctBx.Location = new Point(48, 152);
            Issue_PctBx.Name = "Issue_PctBx";
            Issue_PctBx.Size = new Size(138, 139);
            Issue_PctBx.SizeMode = PictureBoxSizeMode.Zoom;
            Issue_PctBx.TabIndex = 8;
            Issue_PctBx.TabStop = false;
            Issue_PctBx.Click += Issue_PctBx_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Issue_PctBx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Users_PctBx);
            Controls.Add(Resources_PctBx);
            Controls.Add(Loans_PctBx);
            Controls.Add(Main_ExitBTN);
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Loans_PctBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)Resources_PctBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)Users_PctBx).EndInit();
            ((System.ComponentModel.ISupportInitialize)Issue_PctBx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Main_ExitBTN;
        private PictureBox Loans_PctBx;
        private PictureBox Resources_PctBx;
        private PictureBox Users_PctBx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox Issue_PctBx;
    }
}