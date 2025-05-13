using FluentValidation;
using MvcTrainingHub.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MvcTrainingHub.Business.ValidationRules
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName)
                .NotEmpty()
                .WithMessage("Category name cannot be empty.");

            RuleFor(x => x.CategoryDescription)
                .NotEmpty()
                .WithMessage("Description cannot be empty.");

            RuleFor(x => x.CategoryName)
                .MinimumLength(3)
                .WithMessage("Please enter at least 3 characters.");

            RuleFor(x => x.CategoryName)
                .MaximumLength(20)
                .WithMessage("Please enter no more than 20 characters.");

        }
    }
}
