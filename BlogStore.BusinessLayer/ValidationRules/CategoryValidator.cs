﻿using BlogStore.EntityLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore.BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Adını Giriniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen En az 3 Karakter Giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Lütfen En az 3 Karakter Giriniz");

        }
    }
}
