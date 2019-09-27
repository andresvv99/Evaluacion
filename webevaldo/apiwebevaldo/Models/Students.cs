namespace apiwebevaldo.Models
{

    using System;
    using System.ComponentModel.DataAnnotations;
    public enum Gender
    {
        male, female
    }
    public class Student

    {
        [Key]
        public int ScoreID { get; set; }
        [Required]
        public int Name { get; set; }
        [Required]
        public Gender gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
    }
}