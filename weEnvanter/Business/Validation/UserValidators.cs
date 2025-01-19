using FluentValidation;
using weEnvanter.Business.DTOs;

namespace weEnvanter.Business.Validation
{
    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Kullanıcı adı boş olamaz")
                .Length(3, 50).WithMessage("Kullanıcı adı 3-50 karakter arasında olmalıdır");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre boş olamaz")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz")
                .When(x => !string.IsNullOrEmpty(x.Email));

            RuleFor(x => x.FirstName)
                .MaximumLength(50).WithMessage("Ad 50 karakterden uzun olamaz");

            RuleFor(x => x.LastName)
                .MaximumLength(50).WithMessage("Soyad 50 karakterden uzun olamaz");
        }
    }

    public class UserUpdateDtoValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateDtoValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz")
                .When(x => !string.IsNullOrEmpty(x.Email));

            RuleFor(x => x.FirstName)
                .MaximumLength(50).WithMessage("Ad 50 karakterden uzun olamaz")
                .When(x => !string.IsNullOrEmpty(x.FirstName));

            RuleFor(x => x.LastName)
                .MaximumLength(50).WithMessage("Soyad 50 karakterden uzun olamaz")
                .When(x => !string.IsNullOrEmpty(x.LastName));

            RuleFor(x => x.NewPassword)
                .MinimumLength(6).WithMessage("Yeni şifre en az 6 karakter olmalıdır")
                .When(x => !string.IsNullOrEmpty(x.NewPassword));

            RuleFor(x => x.CurrentPassword)
                .NotEmpty().WithMessage("Mevcut şifre gereklidir")
                .When(x => !string.IsNullOrEmpty(x.NewPassword));
        }
    }

    public class UserLoginDtoValidator : AbstractValidator<UserLoginDto>
    {
        public UserLoginDtoValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Kullanıcı adı boş olamaz");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre boş olamaz");
        }
    }
} 