using DTOLayer.DTOs.CustomerDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CustomerRegisterValidator:AbstractValidator<CustomerRegisterDTOs>
	{
		public CustomerRegisterValidator() 
		{
			RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
			RuleFor(x => x.LastName).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
			RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası alanı boş geçilemez.");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez.");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
			RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrarı alanı boş geçilemez.");
			RuleFor(x=>x.Password).MinimumLength(7).WithMessage("Şifreniz en az 7 karakterden oluşmalıdır.");
			RuleFor(x => x.PhoneNumber).MinimumLength(10).MaximumLength(10).WithMessage("Telefon numarası alanı 10 karakterden oluşmalıdır. \n örn. 5xx-xxx-xx-xx");
			RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler uyuşmuyor");
		}
	}
}
