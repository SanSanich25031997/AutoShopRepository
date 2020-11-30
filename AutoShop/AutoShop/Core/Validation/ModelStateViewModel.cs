using System.Collections.Generic;

namespace AutoShop.Core.Validation
{
    public class ModelStateViewModel
    {
        public bool IsValid { get; set; }
        public IDictionary<string, string> Errors { get; set; }

        public ModelStateViewModel(bool isValid, IDictionary<string, string> errors)
        {
            IsValid = isValid;
            Errors = errors;
        }
    }
}
