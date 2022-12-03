using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactName).NotEmpty().WithMessage("Lütfen İsminizi Boş Bırakmayınız!");
            RuleFor(x => x.ContactEmail).NotEmpty().WithMessage("Lütfen Email Adresinizi Boş Bırakmayınız!");
            RuleFor(x => x.ContactPhone).NotEmpty().WithMessage("Lütfen Telefon Numaranızı Boş Bırakmayınız!");
            RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Lütfen Mesaj Bölümünü Boş Bırakmayınız!");
        }
    }
}
