using BlogStore.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.ValidationRules
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator() {

            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanını Boş bırakmayınız").MinimumLength(10).WithMessage("Lütfen en az 10 karakter veri girişi yapınız").MaximumLength(100).WithMessage("Lütfen en Fazla 100 karakter veri girişi yapınız");
        }

    }
}
