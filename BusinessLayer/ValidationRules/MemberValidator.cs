using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class MemberValidator : AbstractValidator<Member>
    {
		public MemberValidator()
		{
			RuleFor(x => x.MemberName).NotEmpty().WithMessage("Ad Soyad Boş Geçilemez");
            RuleFor(x => x.MemberEmail).NotEmpty().WithMessage("Mail Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Geçilemez");
            RuleFor(x => x.SchoolName).NotEmpty().WithMessage("Okul Adı Boş Geçilemez");
            RuleFor(x => x.Adress).NotEmpty().WithMessage("Adres Boş Geçilemez");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon Numarası Boş Geçilemez");

        }
	}
}
