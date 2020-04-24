using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures
{
    public class MaxWordsAttribute : ValidationAttribute
    {
        public MaxWordsAttribute(int maxWords)
        {
            _maxWords = maxWords;
        }
        public int _maxWords { get; set; }
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            string valueAsString;
            if (value != null)
            {
                valueAsString = value.ToString();
                while (valueAsString.Contains("  "))
                {
                    valueAsString = valueAsString.Replace("  ", " ");
                }
                int length = valueAsString.Split(' ').Length;
                if (length > _maxWords)
                {
                    return new ValidationResult("Incorrect!");
                }
            }

            
            return base.IsValid(value, validationContext);
        }
    }
}
