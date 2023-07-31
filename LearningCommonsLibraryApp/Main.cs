using System.Runtime.CompilerServices;

namespace LearningCommonsLibraryApp
{
    public partial class Main : Form
    {
        Staff staff = new Staff();
        Student student = new Student();

        Book book = new Book();
        DigitalResource digitalResource = new DigitalResource();
        Article article = new Article();

        Loans loan = new Loans();
        public Main()
        {
            InitializeComponent();
            staff.AddUser(new Staff { FirstName = "Bruce", LastName = "Wayne", Email = "brucewayne@gmail.com", Id = 100001, UserType = "Staff" });
            student.AddUser(new Student { FirstName = "Dick", LastName = "Grayson", Email = "dickgrayson@gmail.com", Id = 200001, UserType = "Student", LoanCount = 1 });

            book.AddToList(new Book { ResourceID = 100001, Title = "The Shining", Author = "Stephen King", ISBN = "9780345806789", Type = "Book" });
            book.AddToList(new Book { ResourceID = 100002, Title = "Northern Lights", Author = "Philip Pullman", ISBN = "9780590660549", Type = "Book", Status = "Loaned" });

            digitalResource.AddToList(new DigitalResource { ResourceID = 200001, Title = "CompTIA Network+ Self-Paced Study Guide (Exam N10-008)", Author = "James Pengelly", URL = "N/A", Type = "Digital Resource" });

            article.AddToList(new Article { ResourceID = 300001, Title = "Algorithms in Low-Code-No-Code for Research Applications: A Practical Review", Author = "Fahim Sufi", Doi = "https://doi.org/10.3390/a16020108", Type = "Article" });

            loan.AddToList(new Loans { LoanID = 1, UserType = "Student", UserID = 200001, UserName = "Dick, Grayson", ResourceID = 100002, ResourceType = "Book", ResourceTitle = "Northern Lights", DueDate = DateOnly.FromDateTime(DateTime.Now).AddDays(-1), RenewalCount = 1, Status = "Loaned" });
        }

        private void Main_ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Resources_PctBx_Click(object sender, EventArgs e)
        {
            ManageResource manageResource = new ManageResource(book, digitalResource, article);
            manageResource.Show();
        }

        private void Users_PctBx_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers(student, staff);
            manageUsers.Show();
        }

        private void Loans_PctBx_Click(object sender, EventArgs e)
        {
            ManageLoans manageLoans = new ManageLoans(book, digitalResource, article, student, staff, loan);
            manageLoans.Show();
        }

        private void Issue_PctBx_Click(object sender, EventArgs e)
        {
            IssueResource issueResource = new IssueResource(book, digitalResource, article, staff, student, loan);
            issueResource.Show();
        }
    }
}