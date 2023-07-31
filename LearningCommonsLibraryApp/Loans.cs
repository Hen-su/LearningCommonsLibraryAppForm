using LearningCommonsLibraryApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public class Loans
    {
        int loanID;
        public int LoanID
        { get; set; }
        int userID;
        public int UserID
        { get { return userID; } set { userID = value; } }
        string userType;
        public string UserType
        { get { return userType; } set { userType = value; } }
        string userName;
        public string UserName
        { get { return userName; } set { userName = value; } }

        int resourceID;
        public int ResourceID
        { get { return resourceID; } set { resourceID = value; } }
        string resourceType;
        public string ResourceType
        { get { return resourceType; } set { resourceType = value; } }
        string resourceTitle;
        public string ResourceTitle
        { get { return resourceTitle; } set { resourceTitle = value; } }
        DateOnly dueDate;
        public DateOnly DueDate
        { get { return dueDate; } set { dueDate = value; } }
        int renewalCount;
        public int RenewalCount
        { get { return renewalCount; } set { renewalCount = value; } }
        string status;
        public string Status
        { get { return status; } set { status = value; } }
        List<Loans> loansList = new List<Loans>();
        public List<Loans> LoansList
        { get { return loansList; } set { loansList = value; } }

        public Loans() { }
        public Loans(int userID, string userType, string userName, int resourceID, string resourceType, string resourceTitle, DateOnly dueDate) 
        {
            this.loanID = GetID();
            this.userID = userID;
            this.userType = userType;
            this.userName = userName;
            this.resourceID = resourceID;
            this.resourceType = resourceType;
            this.resourceTitle = resourceTitle;
            this.dueDate = dueDate;
            this.renewalCount = 0;
            this.status = "Loaned";
        }

        private int GetID()
        {
            int newID;
            if (loansList.Count > 0)
            {
                
                List<int> loanIds = new List<int>();
                foreach (Loans loan in loansList)
                {
                    loanIds.Add(loan.LoanID);
                    loanIds.Sort();
                }
                newID = loanIds[loanIds.Count - 1] + 1;
            }
            else { newID = 1; }
            return newID;
        }

        public void AddToList(Loans loan)
        {
            LoansList.Add(loan);
        }
        public void IssueResource(Media resource, User user)
        {
            DateOnly dueDate;
            if (user.UserType.Equals("Student"))
            {
                user = (Student)user;
                if (user.LoanCount < 5)
                {
                    DateOnly current = DateOnly.FromDateTime(DateTime.Now);
                    dueDate = current.AddMonths(4);
                    Loans newLoan = new Loans(user.Id, user.UserType, user.FirstName+", "+user.LastName, resource.ResourceID, resource.Type, resource.Title, dueDate);
                    LoansList.Add(newLoan);
                    resource.Status = "Loaned";
                    user.LoanCount = user.LoanCount + 1;
                }
                else { MessageBox.Show("The student has reached the maximum borrowing limit"); }
                
                
            }
            else
            {
                user = (Staff)user;
                DateOnly current = DateOnly.FromDateTime(DateTime.Now);
                dueDate = current.AddYears(1);
                Loans newLoan = new Loans(user.Id, user.UserType, user.FirstName + ", " + user.LastName, resource.ResourceID, resource.Type, resource.Title, dueDate);
                LoansList.Add(newLoan);
                resource.Status = "Loaned";
                user.LoanCount = user.LoanCount + 1;
            }
        }

        public List<Loans> QueryLoans(string query)
        {
            List<Loans> filteredLoans = new List<Loans>();
            IEnumerable<Loans> loansquery = from item in loansList
                                           where item.UserName.ToLower().Contains(query.ToLower())
                                           select item;
            foreach (Loans loan in loansquery)
            {
                filteredLoans.Add(loan);
            }
            return filteredLoans;
        }

        public Loans FindLoan(int loanID)
        {
            Loans match = loansList.Find(x => x.loanID == loanID);
            return match;
        }

        public void RenewLoan(Loans selectedLoan)
        {
            int renewalCount = selectedLoan.RenewalCount;
            if (selectedLoan.userType.Equals("Student"))
            {
                if (renewalCount == 0)
                {
                    DateOnly dueDate = selectedLoan.DueDate;
                    DateOnly renewedDate = dueDate.AddMonths(4);
                    selectedLoan.DueDate = renewedDate;
                    selectedLoan.RenewalCount = selectedLoan.RenewalCount + 1;
                    MessageBox.Show("Renewal successful. The duedate is " + renewedDate.ToString());
                }

                else
                {
                    MessageBox.Show("The renewal limit has been reached");
                }
            }
            else
            {
                DateOnly dueDate = selectedLoan.DueDate;
                DateOnly renewedDate = dueDate.AddYears(1);
                selectedLoan.DueDate = renewedDate;
                MessageBox.Show("Renewal successful. The duedate is " + renewedDate.ToString());
            }
        }
        public void DisplayAllLoans(ListView listView)
        {
            foreach (var item in LoansList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.loanID.ToString();
                listViewItem.SubItems.Add(item.UserType);
                listViewItem.SubItems.Add(item.UserID.ToString());
                listViewItem.SubItems.Add(item.UserName);
                listViewItem.SubItems.Add(item.ResourceID.ToString());
                listViewItem.SubItems.Add(item.ResourceType);
                listViewItem.SubItems.Add(item.ResourceTitle);
                listViewItem.SubItems.Add(item.DueDate.ToString());
                listViewItem.SubItems.Add(item.RenewalCount.ToString());
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }

        public void DisplayFilteredLoans(ListView listView, List<Loans> filteredList)
        {
            foreach (var item in filteredList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.loanID.ToString();
                listViewItem.SubItems.Add(item.UserType);
                listViewItem.SubItems.Add(item.UserID.ToString());
                listViewItem.SubItems.Add(item.UserName);
                listViewItem.SubItems.Add(item.ResourceID.ToString());
                listViewItem.SubItems.Add(item.ResourceType);
                listViewItem.SubItems.Add(item.ResourceTitle);
                listViewItem.SubItems.Add(item.DueDate.ToString());
                listViewItem.SubItems.Add(item.RenewalCount.ToString());
                listViewItem.SubItems.Add(item.Status);
                listView.Items.Add(listViewItem);
            }
        }

        public void ReturnResource(Media media, User user, Loans loan)
        {
            user.LoanCount = user.LoanCount - 1;
            media.Status = "Available";
            loan.Status = "Returned";
        }

        public List<Loans> CheckOverdues()
        {
            List<Loans> overdueLoans = new List<Loans>();
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            IEnumerable<Loans> overdueQuery = from loan in loansList
                                              where loan.Status.Equals("Loaned") && loan.DueDate<currentDate
                                              select loan;
            foreach (Loans item in overdueQuery)
            {
                overdueLoans.Add(item);
                item.Status = "Overdue";
            }
            return overdueLoans;
        }

        public void CalculateFines(List<Loans> overdueLoans, List<Student> studentList)
        {
            if (overdueLoans.Count > 0)
            {
                DateOnly currentdate = DateOnly.FromDateTime(DateTime.Now);
                foreach (var loan in overdueLoans)
                {
                    int userID = loan.UserID;
                    DateOnly overdueDate = loan.DueDate;
                    int overdueDays = (currentdate.DayNumber-overdueDate.DayNumber);
                    int fines = overdueDays * 5;

                    if (loan.userType.Equals("Student"))
                    {
                        Student match = studentList.Find(s => s.Id == userID);
                        match.Fines = fines;
                    }

                }
            }

        }
    }
}
