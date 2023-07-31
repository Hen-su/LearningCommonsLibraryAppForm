using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LearningCommonsLibraryApp
{
    public partial class ManageUsers : Form
    {
        Student student;
        Staff staff;
        public ManageUsers(Student student, Staff staff)
        {
            InitializeComponent();
            this.student = student;
            this.staff = staff;
            Mng_Users_ErrLBL.Visible = false;


            constructListView();
            displayUsers();
        }

        void refreshListView()
        {
            Mng_Users_LstVw.Clear();
            constructListView();
            displayUsers();
        }

        void constructListView()
        {
            Mng_Users_LstVw.View = View.Details;
            Mng_Users_LstVw.Columns.Add("ID");
            Mng_Users_LstVw.Columns.Add("Name");
            Mng_Users_LstVw.Columns.Add("Usertype");
            Mng_Users_LstVw.Columns.Add("Email");
            Mng_Users_LstVw.Columns.Add("LoanCount");
            Mng_Users_LstVw.Columns.Add("Fines");
        }

        void displayUsers()
        {
            foreach (ColumnHeader column in Mng_Users_LstVw.Columns)
            {
                column.Width = Mng_Users_LstVw.Width / Mng_Users_LstVw.Columns.Count;
            }
            staff.DisplayUsers(Mng_Users_LstVw);
            student.DisplayUsers(Mng_Users_LstVw);
        }

        private void Mng_Users_ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mng_Users_AddBTN_Click(object sender, EventArgs e)
        {
            if (Mng_Users_StdRBTN.Checked || Mng_Users_StfRBTN.Checked)
            {
                if (Mng_Users_FnTXT.Text != null && Mng_Users_LnTXT.Text != null && Mng_Users_EmlTXT.Text != null)
                {
                    if (Mng_Users_StdRBTN.Checked) { student.AddUser(new Student { FirstName = Mng_Users_FnTXT.Text, LastName = Mng_Users_LnTXT.Text, Email = Mng_Users_EmlTXT.Text }); clearControls(); refreshListView(); }
                    else { staff.AddUser(new Staff { FirstName = Mng_Users_FnTXT.Text, LastName = Mng_Users_LnTXT.Text, Email = Mng_Users_EmlTXT.Text }); clearControls(); refreshListView(); }
                }
                else { Mng_Users_ErrLBL.Visible = true; }
            }
            else { Mng_Users_ErrLBL.Visible = true; }
        }

        void clearControls()
        {
            Mng_Users_StdRBTN.Checked = false;
            Mng_Users_StfRBTN.Checked = false;
            Mng_Users_FnTXT.Clear();
            Mng_Users_LnTXT.Clear();
            Mng_Users_EmlTXT.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Mng_Users_SearchTXT.Text != "")
            {
                if (Mng_Users_SearchTXT.Text.Length > 0)
                {
                    Mng_Users_SearchTXT.Select(Mng_Users_SearchTXT.Text.Length, 0);
                }
                filterUsersLists();
            }
            else
            {
                Mng_Users_LstVw.Items.Clear();
                displayUsers();
            }
        }

        private void filterUsersLists()
        {
            Mng_Users_LstVw.Items.Clear();
            List<User> filteredStudents = student.QueryUsers(Mng_Users_SearchTXT.Text);
            if (filteredStudents.Count > 0)
            {
                List<Student> studentList = new List<Student>();
                foreach (var item in filteredStudents)
                {
                    studentList.Add((Student)item);
                }
                student.DisplayFilteredUsers(Mng_Users_LstVw, studentList);
            }

            List<User> filteredStaff = staff.QueryUsers(Mng_Users_SearchTXT.Text);
            if (filteredStaff.Count > 0)
            {
                List<Staff> staffList = new List<Staff>();
                foreach (var item in filteredStaff)
                {
                    staffList.Add((Staff)item);
                }
                staff.DisplayFilteredUsers(Mng_Users_LstVw, staffList);
            }
        }
    }
}
