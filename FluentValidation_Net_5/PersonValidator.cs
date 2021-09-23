using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidation_Net_5
{
	class PersonValidator : AbstractValidator<Person>
	{
		public PersonValidator()
		{
			RuleFor(x => x.Id).NotNull();
			RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(15).WithMessage(@"Invalid Name");
			RuleFor(x => x.Email).EmailAddress().NotEmpty();
			RuleFor(x => x.Age).InclusiveBetween(18, 65);
		}
	}
}
