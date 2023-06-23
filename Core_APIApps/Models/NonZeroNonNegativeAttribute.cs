using System.ComponentModel.DataAnnotations;

namespace Core_APIApps.Models
{
    public class NonZeroNonNegativeAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
             if(Convert.ToInt32(value) <=0) return false;
             return true;
        }
    }
}
