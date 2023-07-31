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
    public partial class IssueResource : Form
    {
        Book book;
        DigitalResource digitalResource;
        Article article;
        Staff staff;
        Student student;
        Loans loan;
        int userID;
        string selectedResourceType;
        string selectedResourceStatus;
        string selectedUserType;
        int resourceID;
        String type;
        ListViewItem selectedResourceItem;
        ListViewItem selectedUser;
        public IssueResource(Book book, DigitalResource digiRes, Article article, Staff staff, Student student, Loans loan)
        {
            InitializeComponent();
            this.book = book;
            this.digitalResource = digiRes;
            this.article = article;
            this.staff = staff;
            this.student = student;
            this.loan = loan;
            //add columns to listview
            Iss_Res_ResLstVw.View = View.Details;
            Iss_Res_BrrLstVw.View = View.Details;
            constructResLstVw();
            constructBrrLstVw();
            displayResources();
            displayUsers();

        }
        void refreshResListView()
        {
            Iss_Res_ResLstVw.Clear();
            constructResLstVw();
            displayResources();
        }

        void refreshBrrListView()
        {
            Iss_Res_BrrLstVw.Clear();
            constructBrrLstVw();
            displayUsers();
        }

        void displayResources()
        {
            foreach (ColumnHeader column in Iss_Res_ResLstVw.Columns)
            {
                column.Width = Iss_Res_ResLstVw.Width / Iss_Res_ResLstVw.Columns.Count;
            }
            book.DisplayResource(Iss_Res_ResLstVw);
            digitalResource.DisplayResource(Iss_Res_ResLstVw);
            article.DisplayResource(Iss_Res_ResLstVw);
        }

        void displayUsers()
        {
            foreach (ColumnHeader column in Iss_Res_BrrLstVw.Columns)
            {
                column.Width = Iss_Res_BrrLstVw.Width / Iss_Res_BrrLstVw.Columns.Count;
            }
            staff.DisplayUsers(Iss_Res_BrrLstVw);
            student.DisplayUsers(Iss_Res_BrrLstVw);
        }

        void constructResLstVw()
        {
            Iss_Res_ResLstVw.Columns.Add("ID", "ID");
            Iss_Res_ResLstVw.Columns.Add("Title", "Title");
            Iss_Res_ResLstVw.Columns.Add("Author", "Author");
            Iss_Res_ResLstVw.Columns.Add("Identifier", "Identifier");
            Iss_Res_ResLstVw.Columns.Add("Type", "Type");
            Iss_Res_ResLstVw.Columns.Add("Status", "Status");
        }

        void constructBrrLstVw()
        {
            Iss_Res_BrrLstVw.Columns.Add("ID", "ID");
            Iss_Res_BrrLstVw.Columns.Add("Name", "Name");
            Iss_Res_BrrLstVw.Columns.Add("Usertype", "Usertype");
            Iss_Res_BrrLstVw.Columns.Add("Email", "Email");
            Iss_Res_BrrLstVw.Columns.Add("LoanCount", "LoanCount");
            Iss_Res_BrrLstVw.Columns.Add("Fines", "Fines");
        }

        private void Iss_Res_ResSearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (Iss_Res_ResSearchTXT.Text != "")
            {
                if (Iss_Res_ResSearchTXT.Text.Length > 0)
                {
                    Iss_Res_ResSearchTXT.Select(Iss_Res_ResSearchTXT.Text.Length, 0);
                }
                filterResourcesLists();
            }
            else
            {
                Iss_Res_ResLstVw.Items.Clear();
                displayResources();
            }
        }

        private void filterResourcesLists()
        {
            Iss_Res_ResLstVw.Items.Clear();
            List<Media> filteredBooks = book.QueryResources(Iss_Res_ResSearchTXT.Text);
            if (filteredBooks.Count > 0)
            {
                List<Book> books = new List<Book>();
                foreach (var item in filteredBooks)
                {
                    books.Add((Book)item);
                }
                book.DisplayFilteredResource(Iss_Res_ResLstVw, books);
            }

            List<Media> filteredDigitalResources = digitalResource.QueryResources(Iss_Res_ResSearchTXT.Text);
            if (filteredDigitalResources.Count > 0)
            {
                List<DigitalResource> digitalResources = new List<DigitalResource>();
                foreach (var item in filteredDigitalResources)
                {
                    digitalResources.Add((DigitalResource)item);
                }
                digitalResource.DisplayFilteredResource(Iss_Res_ResLstVw, digitalResources);
            }

            List<Media> filteredArticles = article.QueryResources(Iss_Res_ResSearchTXT.Text);
            if (filteredArticles.Count > 0)
            {
                List<Article> articles = new List<Article>();
                foreach (var item in filteredArticles)
                {
                    articles.Add((Article)item);
                }
                article.DisplayFilteredResource(Iss_Res_ResLstVw, articles);
            }
        }

        private void Iss_Res_BrrSearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (Iss_Res_BrrSearchTXT.Text != "")
            {
                if (Iss_Res_BrrSearchTXT.Text.Length > 0)
                {
                    Iss_Res_BrrSearchTXT.Select(Iss_Res_BrrSearchTXT.Text.Length, 0);
                }
                filterUsersLists();
            }
            else
            {
                Iss_Res_BrrLstVw.Items.Clear();
                displayUsers();
            }
        }

        private void filterUsersLists()
        {
            Iss_Res_BrrLstVw.Items.Clear();
            List<User> filteredStudents = student.QueryUsers(Iss_Res_BrrSearchTXT.Text);
            if (filteredStudents.Count > 0)
            {
                List<Student> studentList = new List<Student>();
                foreach (var item in filteredStudents)
                {
                    studentList.Add((Student)item);
                }
                student.DisplayFilteredUsers(Iss_Res_BrrLstVw, studentList);
            }

            List<User> filteredStaff = staff.QueryUsers(Iss_Res_BrrSearchTXT.Text);
            if (filteredStaff.Count > 0)
            {
                List<Staff> staffList = new List<Staff>();
                foreach (var item in filteredStaff)
                {
                    staffList.Add((Staff)item);
                }
                staff.DisplayFilteredUsers(Iss_Res_BrrLstVw, staffList);
            }
        }

        private void Iss_Res_ResLstVw_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedResourceItem = Iss_Res_ResLstVw.SelectedItems[0];
            resourceID = Int32.Parse(selectedResourceItem.Text);
            selectedResourceType = selectedResourceItem.SubItems[Iss_Res_ResLstVw.Columns.IndexOfKey("Type")].Text;
            selectedResourceStatus = selectedResourceItem.SubItems[Iss_Res_ResLstVw.Columns.IndexOfKey("Status")].Text;
        }

        private void Iss_Res_BrrLstVw_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = Iss_Res_BrrLstVw.SelectedItems[0];
            userID = Int32.Parse(selectedUser.Text);
            selectedUserType = selectedUser.SubItems[Iss_Res_BrrLstVw.Columns.IndexOfKey("UserType")].Text;
        }

        private void Iss_Res_IssBTN_Click(object sender, EventArgs e)
        {
            if (selectedResourceItem != null && selectedUser != null)
            {
                if (selectedResourceStatus.Equals("Available"))
                {
                    Media issueResource = GetMedia();
                    User borrower = GetUser();
                    loan.IssueResource(issueResource, borrower);
                    refreshResListView();
                    refreshBrrListView();
                    MessageBox.Show("Loan Successful");
                }
                else { MessageBox.Show("The selected resource is not available"); }
            }
            else { MessageBox.Show("Select a resource and user"); }
        }

        private User GetUser()
        {
            User borrower;
            if (selectedUserType.Equals("Student"))
            {
                borrower = student.GetUser(userID);
            }
            else
            {
                borrower = staff.GetUser(userID);
            }
            return borrower;
        }

        private Media GetMedia()
        {
            Media media;
            if (selectedResourceType.Equals("Book"))
            {
                media = book.FindResource(resourceID);
            }
            else if (selectedResourceType.Equals("Digital Resource"))
            {
                media = digitalResource.FindResource(resourceID);
            }
            else
            {
                media = article.FindResource(resourceID);
            }
            return media;
        }

        private void Iss_Res_ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
