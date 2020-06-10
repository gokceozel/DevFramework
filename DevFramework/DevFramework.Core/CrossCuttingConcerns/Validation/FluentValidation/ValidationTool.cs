using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevFramework.Core.CrossCuttingConcerns.Validation.FluentValidation
{
   public class ValidationTool
    {
        public static void FluentValidate(IValidator validator,object entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
                throw new ValidationException(result.Errors);
        }
    }
}
