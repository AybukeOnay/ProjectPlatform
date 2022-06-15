using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class OgretimElemaniCalismaAlaniKurallar : AbstractValidator<OgretimElemaniCalismaAlani>
    {
        public OgretimElemaniCalismaAlaniKurallar()
        {
            //RuleFor(x => x.CalismaAlani.CalismaAlaniI).NotEmpty().WithMessage("Öğretim elemanı adı boş geçilemez");
        }
    }
}
