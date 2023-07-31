using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public class Article : Media
    {
        string doi;
        public string Doi
        {
            get { return doi; }
            set { doi = value; }
        }
        List<Article> articleList = new List<Article>();
        public List<Article> ArticleList
        { get { return articleList; } set { articleList = value; } }
        public Article() { }
        public Article(int id, string doi, string title, string author) : base(id, title, author)
        {
            this.Type = "Article";
            this.doi = doi;
        }
        public override int GetID()
        {
            int newID;
            List<int> articlesIDs = new List<int>();
            foreach (Article article in articleList)
            {
                articlesIDs.Add(article.ResourceID);
                articlesIDs.Sort();
            }
            newID = articlesIDs[articlesIDs.Count - 1] + 1;
            return newID;
        }

        public override void AddToList(Media resource)
        {
            ArticleList.Add((Article)resource);
        }

        public override void RemoveResource(int resourceID)
        {
            Article match = ArticleList.Find(x => x.ResourceID == resourceID);
            ArticleList.Remove(match);
        }
        public override Article FindResource(int resourceID)
        {
            var match = from item in ArticleList
                        where item.ResourceID == resourceID
                        select item;
            return (Article) match;
        }

        public override List<Media> QueryResources(string query)
        {
            List<Media> filteredBooks = new List<Media>();
            IEnumerable<Article> articleQuery = from item in ArticleList
                                           where item.Title.ToLower().Contains(query.ToLower())
                                           select item;
            foreach (Article article in articleQuery)
            {
                filteredBooks.Add(article);
            }
            return filteredBooks;
        }

        public override void DisplayResource(ListView listView)
        {
            foreach (var item in ArticleList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.ResourceID.ToString();
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.Doi);
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }

        public void DisplayFilteredResource(ListView listView, List<Article> filteredList)
        {
            foreach (var item in filteredList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.ResourceID.ToString();
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.Doi);
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }
    }
}
