namespace LearningCommonsLibraryApp
{
    partial class ManageResource
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
            Mng_Res_SearchTXT = new TextBox();
            Mng_Res_TitleTXT = new TextBox();
            Mng_Res_AuthorTXT = new TextBox();
            Mng_Res_ISBN_Doi_Url_TXT = new TextBox();
            Mng_Res_EditBTN = new Button();
            Mng_Res_AddBTN = new Button();
            Mng_Res_BookRB = new RadioButton();
            Mng_Res_DigiResRB = new RadioButton();
            Mng_Res_ArticleRB = new RadioButton();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Mng_Res_LstVw = new ListView();
            Mng_Res_ExitBTN = new Button();
            Mng_Res_DeleteBTN = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Mng_Res_SearchTXT
            // 
            Mng_Res_SearchTXT.Location = new Point(229, 48);
            Mng_Res_SearchTXT.Name = "Mng_Res_SearchTXT";
            Mng_Res_SearchTXT.PlaceholderText = "Search by title";
            Mng_Res_SearchTXT.Size = new Size(100, 23);
            Mng_Res_SearchTXT.TabIndex = 0;
            Mng_Res_SearchTXT.TextChanged += Mng_Res_SearchTXT_TextChanged;
            // 
            // Mng_Res_TitleTXT
            // 
            Mng_Res_TitleTXT.Location = new Point(93, 139);
            Mng_Res_TitleTXT.Name = "Mng_Res_TitleTXT";
            Mng_Res_TitleTXT.Size = new Size(100, 23);
            Mng_Res_TitleTXT.TabIndex = 1;
            // 
            // Mng_Res_AuthorTXT
            // 
            Mng_Res_AuthorTXT.Location = new Point(93, 168);
            Mng_Res_AuthorTXT.Name = "Mng_Res_AuthorTXT";
            Mng_Res_AuthorTXT.Size = new Size(100, 23);
            Mng_Res_AuthorTXT.TabIndex = 2;
            // 
            // Mng_Res_ISBN_Doi_Url_TXT
            // 
            Mng_Res_ISBN_Doi_Url_TXT.Location = new Point(93, 197);
            Mng_Res_ISBN_Doi_Url_TXT.Name = "Mng_Res_ISBN_Doi_Url_TXT";
            Mng_Res_ISBN_Doi_Url_TXT.Size = new Size(100, 23);
            Mng_Res_ISBN_Doi_Url_TXT.TabIndex = 3;
            // 
            // Mng_Res_EditBTN
            // 
            Mng_Res_EditBTN.BackColor = Color.LightYellow;
            Mng_Res_EditBTN.Location = new Point(48, 343);
            Mng_Res_EditBTN.Name = "Mng_Res_EditBTN";
            Mng_Res_EditBTN.Size = new Size(75, 23);
            Mng_Res_EditBTN.TabIndex = 0;
            Mng_Res_EditBTN.Text = "Edit";
            Mng_Res_EditBTN.UseVisualStyleBackColor = false;
            Mng_Res_EditBTN.Click += button1_Click;
            // 
            // Mng_Res_AddBTN
            // 
            Mng_Res_AddBTN.BackColor = Color.PaleTurquoise;
            Mng_Res_AddBTN.Location = new Point(63, 231);
            Mng_Res_AddBTN.Name = "Mng_Res_AddBTN";
            Mng_Res_AddBTN.Size = new Size(75, 23);
            Mng_Res_AddBTN.TabIndex = 1;
            Mng_Res_AddBTN.Text = "Add";
            Mng_Res_AddBTN.UseVisualStyleBackColor = false;
            Mng_Res_AddBTN.Click += Mng_Res_AddBTN_Click;
            // 
            // Mng_Res_BookRB
            // 
            Mng_Res_BookRB.AutoSize = true;
            Mng_Res_BookRB.Location = new Point(14, 36);
            Mng_Res_BookRB.Name = "Mng_Res_BookRB";
            Mng_Res_BookRB.Size = new Size(52, 19);
            Mng_Res_BookRB.TabIndex = 7;
            Mng_Res_BookRB.TabStop = true;
            Mng_Res_BookRB.Text = "Book";
            Mng_Res_BookRB.UseVisualStyleBackColor = true;
            // 
            // Mng_Res_DigiResRB
            // 
            Mng_Res_DigiResRB.AutoSize = true;
            Mng_Res_DigiResRB.Location = new Point(14, 61);
            Mng_Res_DigiResRB.Name = "Mng_Res_DigiResRB";
            Mng_Res_DigiResRB.Size = new Size(110, 19);
            Mng_Res_DigiResRB.TabIndex = 8;
            Mng_Res_DigiResRB.TabStop = true;
            Mng_Res_DigiResRB.Text = "Digital Resource";
            Mng_Res_DigiResRB.UseVisualStyleBackColor = true;
            // 
            // Mng_Res_ArticleRB
            // 
            Mng_Res_ArticleRB.AutoSize = true;
            Mng_Res_ArticleRB.Location = new Point(14, 86);
            Mng_Res_ArticleRB.Name = "Mng_Res_ArticleRB";
            Mng_Res_ArticleRB.Size = new Size(59, 19);
            Mng_Res_ArticleRB.TabIndex = 9;
            Mng_Res_ArticleRB.TabStop = true;
            Mng_Res_ArticleRB.Text = "Article";
            Mng_Res_ArticleRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(Mng_Res_DigiResRB);
            groupBox2.Controls.Add(Mng_Res_ArticleRB);
            groupBox2.Controls.Add(Mng_Res_TitleTXT);
            groupBox2.Controls.Add(Mng_Res_AddBTN);
            groupBox2.Controls.Add(Mng_Res_AuthorTXT);
            groupBox2.Controls.Add(Mng_Res_BookRB);
            groupBox2.Controls.Add(Mng_Res_ISBN_Doi_Url_TXT);
            groupBox2.Location = new Point(543, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(204, 260);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Resource";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 142);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 11;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 171);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 12;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 200);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 13;
            label3.Text = "ISBN/doi/url";
            // 
            // Mng_Res_LstVw
            // 
            Mng_Res_LstVw.FullRowSelect = true;
            Mng_Res_LstVw.Location = new Point(48, 77);
            Mng_Res_LstVw.MultiSelect = false;
            Mng_Res_LstVw.Name = "Mng_Res_LstVw";
            Mng_Res_LstVw.Size = new Size(489, 260);
            Mng_Res_LstVw.TabIndex = 14;
            Mng_Res_LstVw.UseCompatibleStateImageBehavior = false;
            Mng_Res_LstVw.SelectedIndexChanged += Mng_Res_LstVw_SelectedIndexChanged;
            // 
            // Mng_Res_ExitBTN
            // 
            Mng_Res_ExitBTN.BackColor = Color.LightGreen;
            Mng_Res_ExitBTN.Location = new Point(360, 413);
            Mng_Res_ExitBTN.Name = "Mng_Res_ExitBTN";
            Mng_Res_ExitBTN.Size = new Size(112, 23);
            Mng_Res_ExitBTN.TabIndex = 15;
            Mng_Res_ExitBTN.Text = "Exit";
            Mng_Res_ExitBTN.UseVisualStyleBackColor = false;
            Mng_Res_ExitBTN.Click += Mng_Res_ExitBTN_Click;
            // 
            // Mng_Res_DeleteBTN
            // 
            Mng_Res_DeleteBTN.BackColor = Color.LightCoral;
            Mng_Res_DeleteBTN.Location = new Point(462, 343);
            Mng_Res_DeleteBTN.Name = "Mng_Res_DeleteBTN";
            Mng_Res_DeleteBTN.Size = new Size(75, 23);
            Mng_Res_DeleteBTN.TabIndex = 16;
            Mng_Res_DeleteBTN.Text = "Delete";
            Mng_Res_DeleteBTN.UseVisualStyleBackColor = false;
            Mng_Res_DeleteBTN.Click += Mng_Res_DeleteBTN_Click;
            // 
            // ManageResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(Mng_Res_DeleteBTN);
            Controls.Add(Mng_Res_ExitBTN);
            Controls.Add(Mng_Res_LstVw);
            Controls.Add(groupBox2);
            Controls.Add(Mng_Res_EditBTN);
            Controls.Add(Mng_Res_SearchTXT);
            Name = "ManageResource";
            Text = "MnaageResource";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Mng_Res_SearchTXT;
        private TextBox Mng_Res_TitleTXT;
        private TextBox Mng_Res_AuthorTXT;
        private TextBox Mng_Res_ISBN_Doi_Url_TXT;
        private Button Mng_Res_EditBTN;
        private Button Mng_Res_AddBTN;
        private RadioButton Mng_Res_BookRB;
        private RadioButton Mng_Res_DigiResRB;
        private RadioButton Mng_Res_ArticleRB;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView Mng_Res_LstVw;
        private Button Mng_Res_ExitBTN;
        private Button Mng_Res_DeleteBTN;
    }
}