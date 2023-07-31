using LearningCommonsLibraryApp.Properties;
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
    public partial class EditResource : Form
    {
        Book book;
        DigitalResource digitalResource;
        Article article;
        String type;
        int resourceID;

        public EditResource(Book book, DigitalResource digitalResource, Article article, int resourceID, String type)
        {
            InitializeComponent();
            this.book = book;
            this.digitalResource = digitalResource;
            this.article = article;
            this.type = type;
            this.resourceID = resourceID;

            if (type == "Book")
            {
                Book resource = book.FindResource(resourceID);
                edit_res_titleTXT.Text = resource.Title;
                edit_res_AuthorTXT.Text = resource.Author;
                edit_res_isbn_doi_urlTXT.Text = resource.ISBN;
                edit_res_statusTXT.Text = resource.Status;
            }
            else if (type == "DigitalResource")
            {
                DigitalResource resource = digitalResource.FindResource(resourceID);
                edit_res_titleTXT.Text = resource.Title;
                edit_res_AuthorTXT.Text = resource.Author;
                edit_res_isbn_doi_urlTXT.Text = resource.URL;
                edit_res_statusTXT.Text = resource.Status;
            }
            else
            {
                Article resource = article.FindResource(resourceID);
                edit_res_titleTXT.Text = resource.Title;
                edit_res_AuthorTXT.Text = resource.Author;
                edit_res_isbn_doi_urlTXT.Text = resource.Doi;
                edit_res_statusTXT.Text = resource.Status;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edt_Res_SaveBTN_Click(object sender, EventArgs e)
        {
            if (type == "Book")
            {
                Book resource = book.FindResource(resourceID);
                resource.Title = edit_res_titleTXT.Text;
                resource.Author = edit_res_AuthorTXT.Text;
                resource.ISBN = edit_res_isbn_doi_urlTXT.Text;
                resource.Status = edit_res_statusTXT.Text;
            }
            else if (type == "DigitalResource")
            {
                DigitalResource resource = digitalResource.FindResource(resourceID);
                resource.Title = edit_res_titleTXT.Text;
                resource.Author = edit_res_AuthorTXT.Text;
                resource.URL = edit_res_isbn_doi_urlTXT.Text;
                resource.Status = edit_res_statusTXT.Text;
            }
            else
            {
                Article resource = article.FindResource(resourceID);
                resource.Title = edit_res_titleTXT.Text;
                resource.Author = edit_res_AuthorTXT.Text;
                resource.Doi = edit_res_isbn_doi_urlTXT.Text;
                resource.Status = edit_res_statusTXT.Text;
            }
            this.Close();
        }
    }
}
