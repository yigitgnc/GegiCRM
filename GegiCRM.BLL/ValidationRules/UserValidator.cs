using FluentValidation;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Boş Geçilemez");
            RuleFor(x => x.PassHash).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Email Boş Geçilemez");
        }
    }
}
