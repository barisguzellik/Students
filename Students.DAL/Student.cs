using System.ComponentModel.DataAnnotations;

namespace Students.DAL
{
    public class Student
    {
        [Key]
        public int STUDENTID { get; set; }
        [Required]
        public int CLASSID { get; set; }
        [Required]
        public long IDENTITYNUMBER { get; set; }
        [Required]
        public string FIRSTNAME { get; set; }
        [Required]
        public string LASTNAME { get; set; }
        [Required]
        public int NUMBER { get; set; }
        [Required]
        public int STATUS { get; set; }
    }
}
