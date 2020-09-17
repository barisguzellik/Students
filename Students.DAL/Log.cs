using System;
using System.ComponentModel.DataAnnotations;

namespace Students.DAL
{
    public class Log
    {
        [Key]
        public int LOGID { get; set; }
        [Required]
        public int MANAGERID { get; set; }
        [Required]
        public DateTime DATETIME { get; set; }
        [Required]
        public string HOSTNAME { get; set; }
        [Required]
        public string HOSTADDRESS { get; set; }
        [Required]
        public string MESSAGE { get; set; }
    }
}
