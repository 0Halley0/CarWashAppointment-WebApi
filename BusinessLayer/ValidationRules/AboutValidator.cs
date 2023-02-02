using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Details1).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
			RuleFor(x => x.Details1).MinimumLength(50).MaximumLength(1500).WithMessage("Karakter sayısı 50-1500 arası olmalıdır.");
		}
	}
}
