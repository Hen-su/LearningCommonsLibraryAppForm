using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public abstract class Media
    {
        int resourceID;
        public int ResourceID 
        { 
            get { return resourceID; } set { resourceID = value; } 
        }
        string type;
        public string Type
        {
            get { return type; } set { type = value; }
            
        }
        string title;
        public string Title
        {
            get { return title; } set { title = value; }
        }
        string author;
        public string Author
        {
            get { return author; } set { author = value; }   
        }
        string status = "Available";
        public string Status
        {
            get { return status; } set { status = value; }
        }

        
        public Media() { }
        public Media(int id, string title, string author) 
        { 
            this.resourceID = id;
            this.title = title;
            this.author = author;
        }

        public abstract void AddToList(Media resource);
        public abstract int GetID();
        public abstract void DisplayResource(ListView listView);
        public abstract void RemoveResource(int resourceID);
        public abstract List<Media> QueryResources(string query);
        public abstract Media FindResource(int resourceID);
    }       
}
