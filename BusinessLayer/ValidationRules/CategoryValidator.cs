using DTOLayer.DTOs.CategoryDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CategoryValidator:AbstractValidator<CategoryAddDTOs>
	{
		public CategoryValidator()
		{
			RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("İlerlemek için boş alanları doldurun.");
		}
	}
}
