using FluentValidation;
using GegiCRM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegiCRM.BLL.ValidationRules
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Boş Geçilemez");
            RuleFor(x => x.PasswordHash).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Email Boş Geçilemez");
        }
    }
}
