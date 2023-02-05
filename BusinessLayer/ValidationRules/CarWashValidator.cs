using DTOLayer.DTOs.CarWashDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CarWashValidator : AbstractValidator<CarWashAddDTO>
	{
		public CarWashValidator()
		{
		}
	}
}
