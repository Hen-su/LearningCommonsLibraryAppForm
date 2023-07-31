namespace LearningCommonsLibraryApp
{
    partial class EditResource
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
            Edit_Res_CancelBTN = new Button();
            Edt_Res_SaveBTN = new Button();
            edit_res_titleTXT = new TextBox();
            edit_res_AuthorTXT = new TextBox();
            edit_res_isbn_doi_urlTXT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            edit_res_statusTXT = new TextBox();
            SuspendLayout();
            // 
            // Edit_Res_CancelBTN
            // 
            Edit_Res_CancelBTN.BackColor = Color.LightGreen;
            Edit_Res_CancelBTN.Location = new Point(95, 174);
            Edit_Res_CancelBTN.Name = "Edit_Res_CancelBTN";
            Edit_Res_CancelBTN.Size = new Size(75, 23);
            Edit_Res_CancelBTN.TabIndex = 0;
            Edit_Res_CancelBTN.Text = "Cancel";
            Edit_Res_CancelBTN.UseVisualStyleBackColor = false;
            Edit_Res_CancelBTN.Click += button1_Click;
            // 
            // Edt_Res_SaveBTN
            // 
            Edt_Res_SaveBTN.BackColor = Color.PaleTurquoise;
            Edt_Res_SaveBTN.Location = new Point(252, 174);
            Edt_Res_SaveBTN.Name = "Edt_Res_SaveBTN";
            Edt_Res_SaveBTN.Size = new Size(75, 23);
            Edt_Res_SaveBTN.TabIndex = 1;
            Edt_Res_SaveBTN.Text = "Save";
            Edt_Res_SaveBTN.UseVisualStyleBackColor = false;
            Edt_Res_SaveBTN.Click += Edt_Res_SaveBTN_Click;
            // 
            // edit_res_titleTXT
            // 
            edit_res_titleTXT.Location = new Point(169, 36);
            edit_res_titleTXT.Name = "edit_res_titleTXT";
            edit_res_titleTXT.Size = new Size(100, 23);
            edit_res_titleTXT.TabIndex = 2;
            // 
            // edit_res_AuthorTXT
            // 
            edit_res_AuthorTXT.Location = new Point(169, 65);
            edit_res_AuthorTXT.Name = "edit_res_AuthorTXT";
            edit_res_AuthorTXT.Size = new Size(100, 23);
            edit_res_AuthorTXT.TabIndex = 3;
            // 
            // edit_res_isbn_doi_urlTXT
            // 
            edit_res_isbn_doi_urlTXT.Location = new Point(169, 94);
            edit_res_isbn_doi_urlTXT.Name = "edit_res_isbn_doi_urlTXT";
            edit_res_isbn_doi_urlTXT.Size = new Size(100, 23);
            edit_res_isbn_doi_urlTXT.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 39);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 6;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 68);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 102);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "ISBN/Doi/URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 126);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Status";
            // 
            // edit_res_statusTXT
            // 
            edit_res_statusTXT.Location = new Point(169, 123);
            edit_res_statusTXT.Name = "edit_res_statusTXT";
            edit_res_statusTXT.Size = new Size(100, 23);
            edit_res_statusTXT.TabIndex = 9;
            // 
            // EditResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 223);
            Controls.Add(label4);
            Controls.Add(edit_res_statusTXT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(edit_res_isbn_doi_urlTXT);
            Controls.Add(edit_res_AuthorTXT);
            Controls.Add(edit_res_titleTXT);
            Controls.Add(Edt_Res_SaveBTN);
            Controls.Add(Edit_Res_CancelBTN);
            Name = "EditResource";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Edit_Res_CancelBTN;
        private Button Edt_Res_SaveBTN;
        private TextBox edit_res_titleTXT;
        private TextBox edit_res_AuthorTXT;
        private TextBox edit_res_isbn_doi_urlTXT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox edit_res_statusTXT;
    }
}