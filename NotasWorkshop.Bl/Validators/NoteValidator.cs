using FluentValidation;
using NotasWorkshop.Bl.Dtos;
using NotasWorkshop.Bl.Validators.Generic;

namespace NotasWorkshop.Bl.Validators
{
    public class NoteValidator : BaseValidator<NoteDto>
    {
        public NoteValidator()
        {
            RuleFor(x => x.Title)
                .Length(11)
                .WithMessage("El campo titulo debe contener 11 dígitos");
        }
    }
}
