using System.ComponentModel.DataAnnotations;

namespace Students.DAL
{
    public class Manager
    {
        [Key]
        public int MANAGERID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string TOKEN { get; set; }
        public int STATUS { get; set; }
    }
}
