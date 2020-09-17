using System.ComponentModel.DataAnnotations;

namespace Students.DAL
{
    public class Class
    {
        [Key]
        public int CLASSID { get; set; }
        [Required]
        public string CODE { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public int SORT { get; set; }
        [Required]
        public int STATUS { get; set; }
    }
}
