using System;

namespace API.DAO.Classes
{
    public class UserAccountDAO
    {
        public Guid UserAccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public short IsDeleted { get; set; }
    }
}
