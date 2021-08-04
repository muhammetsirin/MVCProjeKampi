using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class MessageValidator :AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresi Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Boş geçilemez");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen En az 3 karakter girişi yapınızz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterdeen fazla değer girişi yapmayınız");
        }
    }
}
