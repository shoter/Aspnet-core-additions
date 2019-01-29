using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspnet.Additions.Models.Errors
{
    public class ValidationResultModel
    {
        public string Message { get; set; } = "Validation failed";
        public List<FieldValidationError> Errors { get; set; } = new List<FieldValidationError>();

        public ValidationResultModel(ModelStateDictionary modelState)
        {
            foreach (var key in modelState.Keys)
            {
                var errors = modelState[key];
                Errors.Add(new FieldValidationError(errors.Errors.Select(e => e.ErrorMessage), key));
            }
        }
    }
}
