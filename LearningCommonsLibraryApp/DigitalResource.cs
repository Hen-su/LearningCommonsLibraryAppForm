using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public class DigitalResource : Media
    {
        string url;
        public string URL
        {
            get { return url; }
            set { url = value; }
        }
        List<DigitalResource> digitalResourceList = new List<DigitalResource>();
        public List<DigitalResource> DigitalResourceList
        { get { return digitalResourceList; } set { digitalResourceList = value; } }
        public DigitalResource() { }
        public DigitalResource(int id, string url, string title, string author) : base(id, title, author)
        {
            this.Type = "Digital Resource";
            this.url = url;
        }
        public override int GetID()
        {
            int newID;
            List<int> digiResIDs = new List<int>();
            foreach (DigitalResource digiRes in digitalResourceList)
            {
                digiResIDs.Add(digiRes.ResourceID);
                digiResIDs.Sort();
            }
            newID = digiResIDs[digiResIDs.Count - 1] + 1;
            return newID;
        }

        public override void AddToList(Media resource)
        {
            DigitalResourceList.Add((DigitalResource)resource);
        }

        public override void RemoveResource(int resourceID)
        {
            DigitalResource match = DigitalResourceList.Find(x => x.ResourceID == resourceID);
            DigitalResourceList.Remove(match);
            Console.WriteLine("Removed resource");
        }
        public override DigitalResource FindResource(int resourceID)
        {
            var match = from item in DigitalResourceList
                        where item.ResourceID == resourceID
                        select item;
            return (DigitalResource) match;
        }

        public override List<Media> QueryResources(string query)
        {
            List<Media> filteredBooks = new List<Media>();
            IEnumerable<DigitalResource> digiResQuery = from item in DigitalResourceList
                                           where item.Title.ToLower().Contains(query.ToLower())
                                           select item;
            foreach (DigitalResource digitalResource in digiResQuery)
            {
                filteredBooks.Add(digitalResource);
            }
            return filteredBooks;
        }

        public override void DisplayResource(ListView listView)
        {
            foreach (var item in digitalResourceList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.ResourceID.ToString();
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.URL);
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }

        public void DisplayFilteredResource(ListView listView, List<DigitalResource> filteredList)
        {
            foreach (var item in filteredList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.ResourceID.ToString();
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.URL);
                listViewItem.SubItems.Add(item.Type);
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }
    }
}
