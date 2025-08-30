using EmployeeMgtSystem.Models.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMgtSystem.Models
{
    public class tbl_Employee
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        
        public Department Department { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [HireDateAttribute]
        public DateTime HireDate { get; set; }

        [Range(0.01, double.MaxValue,ErrorMessage = "Salary must be Positive value")]
        public decimal Salary { get; set; }
    }

    public enum Department
    {
        IT,
        HR,
        Finance,
        Marketing
    }
}
