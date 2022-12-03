using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class NeedValidator : AbstractValidator<Need>
    {
        public NeedValidator()
        {
            RuleFor(x => x.NeedName).NotEmpty().WithMessage("Lütfen İhtiyaç Başlığını Boş Bırakmayınız!");
            RuleFor(x => x.NeedNumber).NotEmpty().WithMessage("Lütfen İhtiyaç Sayısını Boş Bırakmayınız!");
          //  RuleFor(x => x.NeedDetail).NotEmpty().WithMessage("Lütfen İhtiyaç Detayını Boş Bırakmayınız!");
        }
    }
}
