using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public class Staff : User
    {
        List<Staff> staffList = new List<Staff>();
        public List<Staff> StaffList
        {
            get { return staffList; }
            set { staffList = value; }
        }
        public Staff() { }
        public Staff(string userType, int id, string firstName, string lastName, string email) : base(userType, id, firstName, lastName, email)
        {
            this.UserType = "Staff";
        }

        public override void DisplayUsers(ListView listView)
        {
            foreach (var item in StaffList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Id.ToString();
                listViewItem.SubItems.Add(item.FirstName + ", " + item.LastName);
                listViewItem.SubItems.Add(item.UserType);
                listViewItem.SubItems.Add(item.Email);
                listViewItem.SubItems.Add(item.LoanCount.ToString());
                listView.Items.Add(listViewItem);
            }
        }

        public void DisplayFilteredUsers(ListView listView, List<Staff> filteredList)
        {
            foreach (var item in filteredList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Id.ToString();
                listViewItem.SubItems.Add(item.FirstName + ", " + item.LastName);
                listViewItem.SubItems.Add(item.UserType);
                listViewItem.SubItems.Add(item.Email);
                listViewItem.SubItems.Add(item.LoanCount.ToString());
                listView.Items.Add(listViewItem);
            }
        }

        public override void AddUser(User newStaff)
        {
            StaffList.Add((Staff)newStaff);
        }

        public override User GetUser(int userID)
        {
            Staff match = StaffList.Find(s => s.Id == userID);
            return match;
        }

        public override List<User> QueryUsers(string query)
        {
            List<User> filteredStaff = new List<User>();
            IEnumerable<Staff> staffQuery = from item in staffList
                                            where (item.FirstName+item.LastName).ToLower().Contains(query.ToLower())
                                            select item;
            foreach (Staff staff in staffQuery)
            {
                filteredStaff.Add(staff);
            }
            return filteredStaff;
        }
    }
}
