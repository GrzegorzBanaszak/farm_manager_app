using FluentValidation;

namespace FarmManagement.Application.Animals.Commands.Validators
{
    public class CreateAnimalValidator : AbstractValidator<CreateAnimalCommand>
    {
        public CreateAnimalValidator()
        {
            RuleFor(x => x.Tag).NotEmpty().MaximumLength(20);
            RuleFor(x => x.Species).NotEmpty();
            RuleFor(x => x.DateOfBirth).LessThanOrEqualTo(DateTime.Today);

        }
    }
}
