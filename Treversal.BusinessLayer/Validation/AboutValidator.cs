using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.EntityLayer.Concrete;

namespace Traversal.BusinessLayer.Validation
{
    public class AboutValidator  :AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("The description section cannot be left blank.");
            RuleFor(x => x.Description).MinimumLength(2).WithMessage("The description section must be at least 2 characters.");
            RuleFor(x=> x.Description).MaximumLength(100).WithMessage("The description section must be at most 100 characters.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("The title section cannot be left blank.");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("The title section must be at least 2 characters.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("The title section must be at most 50 characters.");
            RuleFor(x => x.Title2).NotEmpty().WithMessage("Second title section cannot be left blank.");
            RuleFor(x => x.Title2).MinimumLength(2).WithMessage("Second title section must be at least 2 characters.");
            RuleFor(x => x.Title2).MaximumLength(50).WithMessage("Second title section must be at most 50 characters.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Please Choose an Image");

        }
    }
}
