using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCommonsLibraryApp
{
    public abstract class User
    {
        string userType;
        public string UserType { get { return userType; } set { userType = value; } }
        int id;
        public int Id
        { get { return id; } set { id = value; } }
        string firstName;
        public string FirstName { get { return firstName; } set { firstName = value; } }
        string lastName;
        public string LastName { get { return lastName; } set { lastName = value; } }
        string email;
        public string Email { get { return email; } set { email = value; } }
        int loanCount;
        public int LoanCount
        {get { return loanCount; } set { loanCount = value; }}

        public User(string userType, int id, string firstName, string lastName, string email) 
        { 
            this.userType = userType;
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.loanCount = 0;
        }

        public User() { }
        public abstract void AddUser(User user);

        public abstract List<User> QueryUsers(string query); 

        public abstract User GetUser(int userID);
        public abstract void DisplayUsers(ListView listView);
    }
}
