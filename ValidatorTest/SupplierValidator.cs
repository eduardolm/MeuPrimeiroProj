using FluentValidation;

namespace ValidatorTest
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
         public SupplierValidator()
         {
             RuleFor(x => x.CompanyName)
                 .NotEmpty()
                 .WithMessage("Name field must not be empty.")
                 .Length(3, 100)
                 .WithMessage("Name must be between 3 and 100 characters long.")
                 .NotEqual(x => x.CompanyName)
                 .WithMessage("Company already exists. Please check input.");


            RuleFor(x => x.Cnpj)
                .NotEmpty()
                .WithMessage("CNPJ field must not be empty.")
                .Must(Cnpj.IsValidCnpj)
                .WithMessage("Must be a valid CNPJ.")
                .Length(14)
                .WithMessage("CNPJ must be 14 digits long.")
                .NotEqual(x=> x.Cnpj)
                .WithMessage("CNPJ already exists.")
                .When(x => x.Id > 0, ApplyConditionTo.CurrentValidator);


            RuleFor(x => x.TradingName)
                .NotEmpty()
                .WithMessage("TradingName field must not be empty.")
                .Length(3, 100)
                .WithMessage("TradingName must be between 3 and 100 characters long.")
                .NotEqual(x => x.TradingName)
                .WithMessage("Provided Trading Name already exists. Please check input")
                .When(x => x.Id > 0, ApplyConditionTo.CurrentValidator);


            RuleFor(x => x.Address)
                .NotEmpty()
                .WithMessage("Address field must not be empty.")
                .Length(5, 100)
                .WithMessage("Address must be between 5 and 100 characters long.")
                .NotEqual(x => x.Address)
                .WithMessage("A supplier with this address already exists.")
                .When(x => x.Id > 0, ApplyConditionTo.CurrentValidator);


            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage("Phone field must not be empty.")
                .Length(8, 14)
                .WithMessage("Phone must be between 8 and 14 digits long.")
                .NotEqual(x => x.Phone)
                .WithMessage("A Supplier with this phone number already exists.")
                .When(x => x.Id > 0, ApplyConditionTo.CurrentValidator);


            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("Provided e-mail must be a valid address.")
                .NotEmpty()
                .WithMessage("E-mail field must not be empty.")
                .Length(6, 50)
                .WithMessage("E-mail must be between 6 and 50 characters long.")
                .NotEqual(x => x.Email)
                .WithMessage("E-mail already registered.")
                .When(x => x.Id > 0, ApplyConditionTo.CurrentValidator);

        }
    }
}