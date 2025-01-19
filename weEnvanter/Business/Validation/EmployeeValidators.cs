using FluentValidation;
using weEnvanter.Business.DTOs;

namespace weEnvanter.Business.Validation
{
    public class EmployeeCreateDtoValidator : AbstractValidator<EmployeeCreateDto>
    {
        public EmployeeCreateDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Ad boş olamaz")
                .MaximumLength(50).WithMessage("Ad 50 karakterden uzun olamaz");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad boş olamaz")
                .MaximumLength(50).WithMessage("Soyad 50 karakterden uzun olamaz");

            RuleFor(x => x.EmployeeNumber)
                .NotEmpty().WithMessage("Personel numarası boş olamaz")
                .MaximumLength(20).WithMessage("Personel numarası 20 karakterden uzun olamaz");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz")
                .When(x => !string.IsNullOrEmpty(x.Email));

            RuleFor(x => x.Phone)
                .MaximumLength(20).WithMessage("Telefon numarası 20 karakterden uzun olamaz");

            RuleFor(x => x.DepartmentId)
                .GreaterThan(0).WithMessage("Departman seçilmelidir");

            RuleFor(x => x.HireDate)
                .NotEmpty().WithMessage("İşe giriş tarihi boş olamaz");
        }
    }

    public class EmployeeUpdateDtoValidator : AbstractValidator<EmployeeUpdateDto>
    {
        public EmployeeUpdateDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Ad boş olamaz")
                .MaximumLength(50).WithMessage("Ad 50 karakterden uzun olamaz")
                .When(x => !string.IsNullOrEmpty(x.FirstName));

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad boş olamaz")
                .MaximumLength(50).WithMessage("Soyad 50 karakterden uzun olamaz")
                .When(x => !string.IsNullOrEmpty(x.LastName));

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz")
                .When(x => !string.IsNullOrEmpty(x.Email));

            RuleFor(x => x.Phone)
                .MaximumLength(20).WithMessage("Telefon numarası 20 karakterden uzun olamaz")
                .When(x => !string.IsNullOrEmpty(x.Phone));

            RuleFor(x => x.DepartmentId)
                .GreaterThan(0).WithMessage("Departman seçilmelidir")
                .When(x => x.DepartmentId != 0);
        }
    }
} 