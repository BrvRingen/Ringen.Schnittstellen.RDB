﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ringen.Schnittstellen.RDB.Helpers
{
    internal class ValidationHelper
    {

        public static IList<ValidationResult> Validate(object model)
        {
            var results = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, validationContext, results, true);
            if (model is IValidatableObject)
            {
                (model as IValidatableObject).Validate(validationContext);
            }

            return results;
        }

        public static bool IsValidate(object model, Action<List<ValidationResult>> onValidierungsFehler)
        {
            var results = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);
            bool isValid = Validator.TryValidateObject(model, validationContext, results, true);
            if (!isValid)
            {
                onValidierungsFehler(results);
            }

            return isValid;
        }
    }
}
