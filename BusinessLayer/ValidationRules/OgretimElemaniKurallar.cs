using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class OgretimElemaniKurallar: AbstractValidator<OgretimElemani>
    {
        public OgretimElemaniKurallar()
        {
            RuleFor(x => x.OgretimElemaniAd).NotEmpty().WithMessage("Öğretim elemanı adı boş geçilemez");
            RuleFor(x => x.OgretimElemaniAd).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.OgretimElemaniSoyad).NotEmpty().WithMessage("Öğretim elemanı soyadı boş geçilemez");
            RuleFor(x => x.OgretimElemaniUnvan).NotEmpty().WithMessage("Öğretim elemanı ünvanı boş geçilemez");
            RuleFor(x => x.OgretimElemaniSifre).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(p => p.OgretimElemaniSifre).Matches(@"[A-Z]+").WithMessage("Sifre en az bir büyük harf içermelidir.");
            RuleFor(p => p.OgretimElemaniSifre).Matches(@"[a-z]+").WithMessage("Sifre en az bir küçük harf içermelidir.");
            RuleFor(p => p.OgretimElemaniSifre).Matches(@"[0-9]+").WithMessage("Sifre en az bir rakam içermelidir.");
        }
    }
}
