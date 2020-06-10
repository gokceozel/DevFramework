using DevFramework.Northwind.Entities.Concree;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DevFramework.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Lütfen kategori seçiniz");
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.UnitPrice).GreaterThan(0);
            RuleFor(x => x.ProductName).Length(2);
            RuleFor(x => x.UnitPrice).GreaterThan(20).When(c => c.CategoryId == 1);
            RuleFor(x => x.ProductName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
