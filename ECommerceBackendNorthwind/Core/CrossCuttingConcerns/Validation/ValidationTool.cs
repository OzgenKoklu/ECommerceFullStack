﻿using System.ComponentModel.DataAnnotations;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;


namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity) {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
        

    }
}
