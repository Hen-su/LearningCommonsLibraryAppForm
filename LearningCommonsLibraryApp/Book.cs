using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public class Book : Media
    {
        string isbn;
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        List<Book> bookList = new List<Book>();
        public List<Book> BookList
        { get { return bookList; } set { bookList = value; } }
        public Book() { }
        public Book(int id, string isbn, string title, string author) : base(id, title, author)
        {
            this.isbn = isbn;
        }

        public override int GetID()
        {
            int newID;
            List<int> bookIDs = new List<int>();
            foreach(Book book in bookList)
            {
                bookIDs.Add(book.ResourceID);
                bookIDs.Sort();
            }
            newID = bookIDs[bookIDs.Count-1] + 1;
            return newID;
        }

        public override void AddToList(Media resource)
        {
            BookList.Add((Book)resource);
        }

        public override void RemoveResource(int resourceID)
        {
            Book match = BookList.Find(x => x.ResourceID == resourceID);
            BookList.Remove(match);
        }

        public override Book FindResource(int resourceID)
        {
            Book match = bookList.Find(x=>x.ResourceID == resourceID);
            return match;
        }

        public override List<Media> QueryResources(string query)
        {
            List<Media> filteredBooks = new List<Media>();
            IEnumerable<Book> booksquery = from item in bookList
                                           where item.Title.ToLower().Contains(query.ToLower())
                                           select item;
            foreach (Book book in booksquery)
            {
                filteredBooks.Add(book);
            }
            return filteredBooks;
        }

        public override void DisplayResource(ListView listView)
        {
            foreach (var item in bookList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.ResourceID.ToString();
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.ISBN);
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }

        public void DisplayFilteredResource(ListView listView, List<Book> filteredList)
        {
            foreach (var item in filteredList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.ResourceID.ToString();
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.ISBN);
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }
    }
}
