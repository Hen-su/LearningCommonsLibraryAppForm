using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCommonsLibraryApp
{
    public partial class ManageResource : Form
    {
        //global instances of objects, they are referenced in other forms to access same instance of each list
        Book book;
        DigitalResource digitalResource;
        Article article;
        int resourceID;
        String type;
        ListViewItem selectedlistItem;
        public ManageResource(Book book, DigitalResource digitalResource, Article article)
        {
            InitializeComponent();
            this.book = book;
            this.digitalResource = digitalResource;
            this.article = article;
            //add columns to listview
            Mng_Res_LstVw.View = View.Details;
            constructResLstVw();
            displayResources();
        }
        //updates listview after changes have been made
        void refreshListView()
        {
            Mng_Res_LstVw.Clear();
            constructResLstVw();
            displayResources();
        }

        void constructResLstVw()
        {
            Mng_Res_LstVw.Columns.Add("ID", "ID");
            Mng_Res_LstVw.Columns.Add("Title", "Title");
            Mng_Res_LstVw.Columns.Add("Author", "Author");
            Mng_Res_LstVw.Columns.Add("Identifier", "Identifier");
            Mng_Res_LstVw.Columns.Add("Type", "Type");
            Mng_Res_LstVw.Columns.Add("Status", "Status");
        }
        //populates listview with lists
        void displayResources()
        {
            foreach (ColumnHeader column in Mng_Res_LstVw.Columns)
            {
                column.Width = Mng_Res_LstVw.Width / Mng_Res_LstVw.Columns.Count;
            }
            book.DisplayResource(Mng_Res_LstVw);
            digitalResource.DisplayResource(Mng_Res_LstVw);
            article.DisplayResource(Mng_Res_LstVw);
        }

        private void Mng_Res_ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditResource editResource = new EditResource(book, digitalResource, article, resourceID, type);
            editResource.FormClosed += new FormClosedEventHandler(EditResourceFormClosed);
            editResource.Show();
        }
        //obtains data from selected items to get list item
        private void Mng_Res_LstVw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Mng_Res_LstVw.SelectedItems.Count > 0)
            {
                selectedlistItem = Mng_Res_LstVw.SelectedItems[0];
                resourceID = Int32.Parse(selectedlistItem.Text);
                type = selectedlistItem.SubItems[Mng_Res_LstVw.Columns.IndexOfKey("Type")].Text;
            }

        }

        private void EditResourceFormClosed(Object sender, FormClosedEventArgs e)
        {
            refreshListView();
        }
        //deletes selected item
        private void Mng_Res_DeleteBTN_Click(object sender, EventArgs e)
        {
            if (selectedlistItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete resource: " + resourceID + "?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    if (type == "Book")
                    {
                        book.RemoveResource(resourceID);
                    }
                    else if (type == "DigitalResource")
                    {
                        digitalResource.RemoveResource(resourceID);
                    }
                    else
                    {
                        article.RemoveResource(resourceID);
                    }
                    refreshListView();
                }
                else { return; }
            }
            else { MessageBox.Show("Select a resource first"); }

        }
        //filters listview items by title
        private void Mng_Res_SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (Mng_Res_SearchTXT.Text != "")
            {
                if (Mng_Res_SearchTXT.Text.Length > 0)
                {
                    Mng_Res_SearchTXT.Select(Mng_Res_SearchTXT.Text.Length, 0);
                }
                filterLists();
            }
            else
            {
                Mng_Res_LstVw.Items.Clear();
                displayResources();
            }
        }
        //filters through lists
        private void filterLists()
        {
            Mng_Res_LstVw.Items.Clear();
            List<Media> filteredBooks = book.QueryResources(Mng_Res_SearchTXT.Text);
            if (filteredBooks.Count > 0)
            {
                List<Book> books = new List<Book>();
                foreach (var item in filteredBooks)
                {
                    books.Add((Book)item);
                }
                book.DisplayFilteredResource(Mng_Res_LstVw, books);
            }

            List<Media> filteredDigitalResources = digitalResource.QueryResources(Mng_Res_SearchTXT.Text);
            if (filteredDigitalResources.Count > 0)
            {
                List<DigitalResource> digitalResources = new List<DigitalResource>();
                foreach (var item in filteredDigitalResources)
                {
                    digitalResources.Add((DigitalResource)item);
                }
                digitalResource.DisplayFilteredResource(Mng_Res_LstVw, digitalResources);
            }

            List<Media> filteredArticles = article.QueryResources(Mng_Res_SearchTXT.Text);
            if (filteredArticles.Count > 0)
            {
                List<Article> articles = new List<Article>();
                foreach (var item in filteredArticles)
                {
                    articles.Add((Article)item);
                }
                article.DisplayFilteredResource(Mng_Res_LstVw, articles);
            }
        }
        //adds new resource to list
        private void Mng_Res_AddBTN_Click(object sender, EventArgs e)
        {
            string title = Mng_Res_TitleTXT.Text;
            string author = Mng_Res_AuthorTXT.Text;
            string isbn_doi_url = Mng_Res_ISBN_Doi_Url_TXT.Text;
            string type;
            if (title.Length > 0 && author.Length > 0 && isbn_doi_url.Length > 0)
            {
                if (Mng_Res_BookRB.Checked || Mng_Res_DigiResRB.Checked || Mng_Res_ArticleRB.Checked)
                {
                    if (Mng_Res_BookRB.Checked)
                    {
                        type = "Book";
                        book.AddToList(new Book { ResourceID = book.GetID(), Title = title, Author = author, ISBN = isbn_doi_url, Type = "Book" });
                    }
                    if (Mng_Res_DigiResRB.Checked)
                    {
                        type = "Digital Resource";
                        book.AddToList(new Book { ResourceID = book.GetID(), Title = title, Author = author, ISBN = isbn_doi_url, Type = "Book" });
                    }

                    if (Mng_Res_ArticleRB.Checked)
                    {
                        type = "Article";
                        book.AddToList(new Book { ResourceID = book.GetID(), Title = title, Author = author, ISBN = isbn_doi_url, Type = "Book" });
                    }
                    refreshListView();
                    ClearTextboxes();
                }
                else { MessageBox.Show("Please select a resource type"); }
            }
            else { MessageBox.Show("All fields must be filled in"); }

        }
        //clear controls after adding resource to reduce accidental duplicate entries
        void ClearTextboxes()
        {
            Mng_Res_BookRB.Checked = false;
            Mng_Res_DigiResRB.Checked = false;
            Mng_Res_ArticleRB.Checked = false;
            Mng_Res_TitleTXT.Clear();
            Mng_Res_AuthorTXT.Clear();
            Mng_Res_ISBN_Doi_Url_TXT.Clear();
        }
    }
}
