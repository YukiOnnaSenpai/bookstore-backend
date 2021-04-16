using System;

namespace API.DAO.Classes
{
    public class BookDAO
    {
        public Guid BookID { get; set; }
        public string ISBN{ get; set; }
        public string Title{ get; set; }
        public string Author{ get; set; }
        public string Genre{ get; set; }
        public short IsDeleted { get; set; }
    }
}
