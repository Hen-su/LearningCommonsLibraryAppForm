using LearningCommonsLibraryApp.Properties;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ManageLoans : Form
    {
        Book book;
        DigitalResource digitalResource;
        Article article;
        Student student;
        Staff staff;
        Loans loan;
        int loanID;
        int userID;
        int resourceID;
        string userType;
        string resourceType;
        public ManageLoans(Book book, DigitalResource digitalResource, Article article, Student student, Staff staff, Loans loan)
        {
            InitializeComponent();
            this.book = book;
            this.digitalResource = digitalResource;
            this.article = article;
            this.student = student;
            this.staff = staff;
            this.loan = loan;

            Loans_LstVw.View = View.Details;
            constructLstVw();
            loan.DisplayAllLoans(Loans_LstVw);
        }

        void refreshListView()
        {
            Loans_LstVw.Clear();
            constructLstVw();
            loan.DisplayAllLoans(Loans_LstVw);
        }

        void constructLstVw()
        {
            foreach (ColumnHeader column in Loans_LstVw.Columns)
            {
                column.Width = Loans_LstVw.Width / Loans_LstVw.Columns.Count;
            }
            Loans_LstVw.Columns.Add("ID", "ID");
            Loans_LstVw.Columns.Add("UserType", "UserType");
            Loans_LstVw.Columns.Add("UserID", "UserID");
            Loans_LstVw.Columns.Add("Borrower", "Borrower");
            Loans_LstVw.Columns.Add("ResourceID", "ResourceID");
            Loans_LstVw.Columns.Add("ResourceType", "ResourceType");
            Loans_LstVw.Columns.Add("ResourceTitle", "ResourceTitle");
            Loans_LstVw.Columns.Add("DueDate", "DueDate");
            Loans_LstVw.Columns.Add("RenewalCount", "RenewalCount");
            Loans_LstVw.Columns.Add("Status", "Status");
        }

        private void Loans_ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //get data for selected loan
        private void Loans_LstVw_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = Loans_LstVw.SelectedItems[0];
            loanID = Int32.Parse(Loans_LstVw.SelectedItems[0].Text);
            resourceType = selectedItem.SubItems[Loans_LstVw.Columns.IndexOfKey("ResourceType")].Text;
            userID = Int32.Parse(selectedItem.SubItems[Loans_LstVw.Columns.IndexOfKey("UserID")].Text);
            resourceID = Int32.Parse(selectedItem.SubItems[Loans_LstVw.Columns.IndexOfKey("ResourceID")].Text);
            userType = selectedItem.SubItems[Loans_LstVw.Columns.IndexOfKey("UserType")].Text;
        }

        //search loans by borrower name
        private void Loans_SearchTXT_TextChanged(object sender, EventArgs e)
        {
            if (Loans_SearchTXT.Text != "")
            {
                if (Loans_SearchTXT.Text.Length > 0)
                {
                    Loans_SearchTXT.Select(Loans_SearchTXT.Text.Length, 0);
                }
                filterLoansLists();
            }
            else
            {
                Loans_LstVw.Items.Clear();
                loan.DisplayAllLoans(Loans_LstVw);
            }
        }

        private void filterLoansLists()
        {
            Loans_LstVw.Items.Clear();
            List<Loans> filteredLoans = loan.QueryLoans(Loans_SearchTXT.Text);
            if (filteredLoans.Count > 0)
            {
                List<Loans> loanList = new List<Loans>();
                foreach (var item in filteredLoans)
                {
                    loanList.Add(item);
                }
                loan.DisplayFilteredLoans(Loans_LstVw, loanList);
            }
        }
        //Renew loan by 4 months for student, 1 year for staff
        private void Loans_RenewBTN_Click(object sender, EventArgs e)
        {
            if (loanID.ToString().Length > 0)
            {
                Loans selectedLoan = loan.FindLoan(loanID);
                if (selectedLoan.Status.Equals("Loaned"))
                {
                    loan.RenewLoan(selectedLoan);
                }
            }
            else { MessageBox.Show("Select a loan"); }

        }

        private void Loans_ReturnBTN_Click(object sender, EventArgs e)
        {
            if (loanID.ToString().Length > 0)
            {
                Loans selectedLoan = loan.FindLoan(loanID);
                if (selectedLoan.Status.Equals("Loaned") || selectedLoan.Status.Equals("Overdue"))
                {
                    loan.ReturnResource(GetMedia(), GetUser(), selectedLoan);
                    refreshListView();
                }
            }
            else { MessageBox.Show("Select a loan"); }
        }

        private User GetUser()
        {
            User borrower;
            if (userType.Equals("Student"))
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
            if (resourceType.Equals("Book"))
            {
                media = book.FindResource(resourceID);
            }
            else if (resourceType.Equals("Digital Resource"))
            {
                media = digitalResource.FindResource(resourceID);
            }
            else
            {
                media = article.FindResource(resourceID);
            }
            return media;
        }

        private void Loans_CheckOverduesBTN_Click(object sender, EventArgs e)
        {
            Loans_LstVw.Items.Clear();
            List<Loans> overdueLoans = loan.CheckOverdues();
            if (overdueLoans.Count > 0)
            {
                int overdueCount = overdueLoans.Count;
                loan.DisplayFilteredLoans(Loans_LstVw, overdueLoans);
                loan.CalculateFines(overdueLoans, student.StudentList);
                Loans_CheckDateLBL.Text = DateOnly.FromDateTime(DateTime.Now).ToString();
                MessageBox.Show(overdueCount + " loans overdue. Fines have been applied");
            }
            else { MessageBox.Show("No overdues found"); }
        }

        private void Loans_Reset_LstVwBTN_Click(object sender, EventArgs e)
        {
            refreshListView();
        }
    }
}
