using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class OgrenciProfilKurallar: AbstractValidator<Ogrenci>
    
    {
       public OgrenciProfilKurallar()
        {
            RuleFor(x => x.OgrenciAd).NotEmpty().WithMessage("Öğrenci adı boş geçilemez");
            RuleFor(x => x.OgrenciAd).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.OgrenciSoyad).NotEmpty().WithMessage("Öğrenci soyadı boş geçilemez");           
            
        }
    }
}
