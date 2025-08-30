using System.ComponentModel.DataAnnotations;

namespace EmployeeMgtSystem.Models.ValidationAttributes
{
    public class HireDateAttribute : ValidationAttribute
    {
        public HireDateAttribute() 
        {
            ErrorMessage = "Hire Date should not be the future date!";
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime hireDate)
            {
                if (hireDate > DateTime.Now)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}
