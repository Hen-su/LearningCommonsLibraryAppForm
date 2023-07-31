using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public class Student : User
    {
        int fines;
        public int Fines
        { get { return fines; } set { fines = value; } }

        List<Student> studentList = new List<Student>();
        public List<Student> StudentList
        {
            get { return studentList; }
            set { studentList = value; }
        }
        public Student() { }
        public Student(string userType, int id, string firstName, string lastName, string email) : base(userType, id, firstName, lastName, email)
        {
            this.UserType = "Student";
            this.fines = 0;
        }

        public override void DisplayUsers(ListView listView)
        {
            foreach (var item in StudentList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Id.ToString();
                listViewItem.SubItems.Add(item.FirstName + ", " + item.LastName);
                listViewItem.SubItems.Add(item.UserType);
                listViewItem.SubItems.Add(item.Email);
                listViewItem.SubItems.Add(item.LoanCount.ToString());
                listViewItem.SubItems.Add(item.Fines.ToString());
                listView.Items.Add(listViewItem);
            }
        }

        public void DisplayFilteredUsers(ListView listView, List<Student> filteredList)
        {
            foreach (var item in filteredList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Id.ToString();
                listViewItem.SubItems.Add(item.FirstName + ", " + item.LastName);
                listViewItem.SubItems.Add(item.UserType);
                listViewItem.SubItems.Add(item.Email);
                listViewItem.SubItems.Add(item.LoanCount.ToString());
                listViewItem.SubItems.Add(item.Fines.ToString());
                listView.Items.Add(listViewItem);
            }
        }

        public override void AddUser(User newStudent)
        {
            StudentList.Add((Student)newStudent);
        }

        public override User GetUser(int userID)
        {
            Student match = studentList.Find(s => s.Id == userID);
            return match;
        }

        public override List<User> QueryUsers(string query)
        {
            List<User> filteredStudents = new List<User>();
            IEnumerable<Student> studentQuery = from item in studentList
                                                where (item.FirstName+item.LastName).ToLower().Contains(query.ToLower())
                                            select item;
            foreach (Student student in studentQuery)
            {
                filteredStudents.Add(student);
            }
            return filteredStudents;
        }
    }
}
